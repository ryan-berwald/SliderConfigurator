using CSCore.CoreAudioAPI;
using System;
using System.Collections.Generic;
using System.Threading;

namespace AudioControl
{
    class Audio
    { 

        public static AudioSessionControl2[] getSessions()
        {
            List<AudioSessionControl2> allSessions = new List<AudioSessionControl2>();
            var sessionManagers = GetAudioSessionManagers(DataFlow.Render);
            {
                foreach (var sm in sessionManagers)
                {
                    var sessionEnumerator = sm.GetSessionEnumerator();
                    {
                        foreach (var session in sessionEnumerator)
                        {
                            AudioSessionControl2 app = session.QueryInterface<AudioSessionControl2>();
                            var sessionEvents = new AudioSessionEvents();
                            if (session.SessionState == AudioSessionState.AudioSessionStateActive)
                            {
                                var appVolume = app.QueryInterface<SimpleAudioVolume>();

                                //DisplaySessionDetails(app, appVolume);
                                allSessions.Add(app);
                    
                                //appVolume.SetMasterVolumeNative(0.5f, getAppGUID(app));
                            }

                        }
                    }
                }
            }
            return allSessions.ToArray();
        }
        public static List<AudioSessionManager2> GetAudioSessionManagers(DataFlow dataFlow)
        {
            var enumerator = new MMDeviceEnumerator();
            List<AudioSessionManager2> sessionManager = new List<AudioSessionManager2>();
            var devices = enumerator.EnumAudioEndpoints(dataFlow, DeviceState.Active);
            {
                foreach (var device in devices)
                {
                    Console.WriteLine(device.FriendlyName);
                    sessionManager.Add(AudioSessionManager2.FromMMDevice(device));
                }
                return sessionManager;
            }
        }

        public static Guid getAppGUID(AudioSessionControl2 app)
        {
            return Guid.Parse(app.SessionIdentifier.Substring(18, 36));
        }

        private static void DisplaySessionDetails(AudioSessionControl2 app, SimpleAudioVolume appVolume)
        {
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("SessionIdentifier: {0}\nSessionInstanceIdentifier: {1}\nProcessID: {2}\nProcessWindowTitle: {3}\nIsSingleProcessSession: {4}\nIsSystemSoundSession: {5}\nFriendly Name: {6}\nVolume: {7}",
                app.SessionIdentifier,
                app.SessionInstanceIdentifier,
                app.ProcessID,
                app.Process == null ? String.Empty : app.Process.MainWindowTitle,
                app.IsSingleProcessSession,
                app.IsSystemSoundSession,
                app.DisplayName,
                appVolume.MasterVolume
                );
            Console.WriteLine("------------------------------------------------------------");
        }
    }
}
