// Telnyx Blazor Interop
window.TelnyxBlazor = {
    clients: {}, calls: {}, dotNetReferences: {},

    // Initialize a new TelnyxRTC client
    createClient: async function (clientId, options, dotNetReference) {
        try {
            // Import the Telnyx WebRTC SDK dynamically
            if (!window.TelnyxRTC) {
                const script = document.createElement('script');
                script.src = 'https://app.unpkg.com/@telnyx/webrtc@2.22.12/files/lib/bundle.js';
                document.head.appendChild(script);

                await new Promise((resolve, reject) => {
                    script.onload = resolve;
                    script.onerror = reject;
                });
            }

            const client = new window.TelnyxRTC(options);

            // Store client and .NET reference
            this.clients[clientId] = client;
            this.dotNetReferences[clientId] = dotNetReference;

            // Set up event handlers
            client.on('telnyx.ready', () => {
                dotNetReference.invokeMethodAsync('OnReady');
            });

            client.on('telnyx.error', (error) => {
                dotNetReference.invokeMethodAsync('OnError', error.message || 'Unknown error');
            });

            client.on('telnyx.notification', (notification) => {
                dotNetReference.invokeMethodAsync('OnNotification', JSON.stringify(notification));
            });

            client.on('telnyx.socket.open', () => {
                dotNetReference.invokeMethodAsync('OnSocketOpen');
            });

            client.on('telnyx.socket.close', () => {
                dotNetReference.invokeMethodAsync('OnSocketClose');
            });

            return true;
        } catch (error) {
            console.error('Error creating Telnyx client:', error);
            return false;
        }
    },

    // Connect the client
    connect: async function (clientId) {
        const client = this.clients[clientId];
        if (!client) {
            throw new Error('Client not found');
        }

        await client.connect();
    },

    // Disconnect the client
    disconnect: async function (clientId) {
        const client = this.clients[clientId];
        if (!client) {
            throw new Error('Client not found');
        }

        await client.disconnect();
        delete this.clients[clientId];
        delete this.dotNetReferences[clientId];
    },

    // Check if client is connected
    isConnected: function (clientId) {
        const client = this.clients[clientId];
        return client ? client.connected : false;
    },

    // Create a new call
    newCall: function (clientId, callOptions) {
        const client = this.clients[clientId];
        if (!client) {
            throw new Error('Client not found');
        }

        const call = client.newCall(callOptions);
        const callId = call.id;
        this.calls[callId] = call;

        return {
            id: callId, state: call.state, prevState: call.prevState, direction: call.direction
        };
    },

    // Answer an incoming call
    answerCall: function (callId, options) {
        const call = this.calls[callId];
        if (!call) {
            throw new Error('Call not found');
        }

        call.answer(options || {});
    },

    // Hangup a call
    hangupCall: function (callId) {
        const call = this.calls[callId];
        if (!call) {
            throw new Error('Call not found');
        }

        call.hangup();
        delete this.calls[callId];
    },

    // Hold/unhold call
    holdCall: async function (callId) {
        const call = this.calls[callId];
        if (!call) {
            throw new Error('Call not found');
        }

        await call.hold();
    },

    unholdCall: async function (callId) {
        const call = this.calls[callId];
        if (!call) {
            throw new Error('Call not found');
        }

        await call.unhold();
    },

    // Toggle hold state
    toggleHold: async function (callId) {
        const call = this.calls[callId];
        if (!call) {
            throw new Error('Call not found');
        }

        await call.toggleHold();
    },

    // Mute/unmute audio
    muteAudio: function (callId) {
        const call = this.calls[callId];
        if (!call) {
            throw new Error('Call not found');
        }

        call.muteAudio();
    },

    unmuteAudio: function (callId) {
        const call = this.calls[callId];
        if (!call) {
            throw new Error('Call not found');
        }

        call.unmuteAudio();
    },

    toggleAudioMute: function (callId) {
        const call = this.calls[callId];
        if (!call) {
            throw new Error('Call not found');
        }

        call.toggleAudioMute();
    },

    // Send DTMF
    sendDTMF: function (callId, digit) {
        const call = this.calls[callId];
        if (!call) {
            throw new Error('Call not found');
        }

        call.dtmf(digit);
    },

    // Get devices
    getDevices: async function (clientId) {
        const client = this.clients[clientId];
        if (!client) {
            throw new Error('Client not found');
        }

        return await client.getDevices();
    },

    getAudioInDevices: async function (clientId) {
        const client = this.clients[clientId];
        if (!client) {
            throw new Error('Client not found');
        }

        return await client.getAudioInDevices();
    },

    getAudioOutDevices: async function (clientId) {
        const client = this.clients[clientId];
        if (!client) {
            throw new Error('Client not found');
        }

        return await client.getAudioOutDevices();
    },

    getVideoDevices: async function (clientId) {
        const client = this.clients[clientId];
        if (!client) {
            throw new Error('Client not found');
        }

        return await client.getVideoDevices();
    },

    // Set media elements
    setLocalElement: function (clientId, elementId) {
        const client = this.clients[clientId];
        if (!client) {
            throw new Error('Client not found');
        }

        client.localElement = elementId;
    },

    setRemoteElement: function (clientId, elementId) {
        const client = this.clients[clientId];
        if (!client) {
            throw new Error('Client not found');
        }

        client.remoteElement = elementId;
    },

    // Check permissions
    checkPermissions: async function (clientId, audio, video) {
        const client = this.clients[clientId];
        if (!client) {
            throw new Error('Client not found');
        }

        return await client.checkPermissions(audio, video);
    },

    // Clean up
    dispose: function (clientId) {
        const client = this.clients[clientId];
        if (client && client.connected) {
            client.disconnect();
        }

        delete this.clients[clientId];
        delete this.dotNetReferences[clientId];
    }
};