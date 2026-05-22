using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000020 RID: 32
	public sealed class Microphone
	{
		// Token: 0x060001C6 RID: 454 RVA: 0x00002FF8 File Offset: 0x000011F8
		public static int GetMicrophoneDeviceIDFromName(string name)
		{
			return Microphone.GetMicrophoneDeviceIDFromNameDelegateField(IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00007BB0 File Offset: 0x00005DB0
		public static AudioClip StartRecord(int deviceID, bool loop, float lengthSec, int frequency)
		{
			IntPtr intPtr = Microphone.StartRecordDelegateField(deviceID, loop, lengthSec, frequency);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x0000300A File Offset: 0x0000120A
		public static void EndRecord(int deviceID)
		{
			Microphone.EndRecordDelegateField(deviceID);
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00003017 File Offset: 0x00001217
		public static bool IsRecording(int deviceID)
		{
			return Microphone.IsRecordingDelegateField(deviceID);
		}

		// Token: 0x060001CA RID: 458 RVA: 0x00003024 File Offset: 0x00001224
		public static int GetRecordPosition(int deviceID)
		{
			return Microphone.GetRecordPositionDelegateField(deviceID);
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00003031 File Offset: 0x00001231
		public static void GetDeviceCaps(int deviceID, out int minFreq, out int maxFreq)
		{
			Microphone.GetDeviceCapsDelegateField(deviceID, out minFreq, out maxFreq);
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00007BDC File Offset: 0x00005DDC
		public static AudioClip Start(string deviceName, bool loop, int lengthSec, int frequency)
		{
			int microphoneDeviceIDFromName = Microphone.GetMicrophoneDeviceIDFromName(deviceName);
			bool flag = microphoneDeviceIDFromName == -1;
			if (flag)
			{
				throw new ArgumentException(String.Concat("Couldn't acquire device ID for device name ", deviceName));
			}
			bool flag2 = lengthSec <= 0;
			if (flag2)
			{
				throw new ArgumentException(String.Concat("Length of recording must be greater than zero seconds (was: ", lengthSec.ToString(), " seconds)"));
			}
			bool flag3 = lengthSec > 3600;
			if (flag3)
			{
				throw new ArgumentException(String.Concat("Length of recording must be less than one hour (was: ", lengthSec.ToString(), " seconds)"));
			}
			bool flag4 = frequency <= 0;
			if (flag4)
			{
				throw new ArgumentException(String.Concat("Frequency of recording must be greater than zero (was: ", frequency.ToString(), " Hz)"));
			}
			return Microphone.StartRecord(microphoneDeviceIDFromName, loop, (float)lengthSec, frequency);
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00007C94 File Offset: 0x00005E94
		public static void End(string deviceName)
		{
			int microphoneDeviceIDFromName = Microphone.GetMicrophoneDeviceIDFromName(deviceName);
			bool flag = microphoneDeviceIDFromName == -1;
			if (!flag)
			{
				Microphone.EndRecord(microphoneDeviceIDFromName);
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060001CE RID: 462 RVA: 0x00007CBC File Offset: 0x00005EBC
		public static Il2CppStringArray devices
		{
			get
			{
				IntPtr intPtr = Microphone.get_devicesDelegateField();
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060001CF RID: 463 RVA: 0x00003040 File Offset: 0x00001240
		public static bool isAnyDeviceRecording
		{
			get
			{
				return Microphone.get_isAnyDeviceRecordingDelegateField();
			}
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x00007CE4 File Offset: 0x00005EE4
		public static bool IsRecording(string deviceName)
		{
			int microphoneDeviceIDFromName = Microphone.GetMicrophoneDeviceIDFromName(deviceName);
			bool flag = microphoneDeviceIDFromName == -1;
			return !flag && Microphone.IsRecording(microphoneDeviceIDFromName);
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00007D10 File Offset: 0x00005F10
		public static int GetPosition(string deviceName)
		{
			int microphoneDeviceIDFromName = Microphone.GetMicrophoneDeviceIDFromName(deviceName);
			bool flag = microphoneDeviceIDFromName == -1;
			int num;
			if (flag)
			{
				num = 0;
			}
			else
			{
				num = Microphone.GetRecordPosition(microphoneDeviceIDFromName);
			}
			return num;
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00007D3C File Offset: 0x00005F3C
		public static void GetDeviceCaps(string deviceName, out int minFreq, out int maxFreq)
		{
			minFreq = 0;
			maxFreq = 0;
			int microphoneDeviceIDFromName = Microphone.GetMicrophoneDeviceIDFromName(deviceName);
			bool flag = microphoneDeviceIDFromName == -1;
			if (!flag)
			{
				Microphone.GetDeviceCaps(microphoneDeviceIDFromName, out minFreq, out maxFreq);
			}
		}

		// Token: 0x04000194 RID: 404
		private static readonly Microphone.GetMicrophoneDeviceIDFromNameDelegate GetMicrophoneDeviceIDFromNameDelegateField = IL2CPP.ResolveICall<Microphone.GetMicrophoneDeviceIDFromNameDelegate>("UnityEngine.Microphone::GetMicrophoneDeviceIDFromName");

		// Token: 0x04000195 RID: 405
		private static readonly Microphone.StartRecordDelegate StartRecordDelegateField = IL2CPP.ResolveICall<Microphone.StartRecordDelegate>("UnityEngine.Microphone::StartRecord");

		// Token: 0x04000196 RID: 406
		private static readonly Microphone.EndRecordDelegate EndRecordDelegateField = IL2CPP.ResolveICall<Microphone.EndRecordDelegate>("UnityEngine.Microphone::EndRecord");

		// Token: 0x04000197 RID: 407
		private static readonly Microphone.IsRecordingDelegate IsRecordingDelegateField = IL2CPP.ResolveICall<Microphone.IsRecordingDelegate>("UnityEngine.Microphone::IsRecording");

		// Token: 0x04000198 RID: 408
		private static readonly Microphone.GetRecordPositionDelegate GetRecordPositionDelegateField = IL2CPP.ResolveICall<Microphone.GetRecordPositionDelegate>("UnityEngine.Microphone::GetRecordPosition");

		// Token: 0x04000199 RID: 409
		private static readonly Microphone.GetDeviceCapsDelegate GetDeviceCapsDelegateField = IL2CPP.ResolveICall<Microphone.GetDeviceCapsDelegate>("UnityEngine.Microphone::GetDeviceCaps");

		// Token: 0x0400019A RID: 410
		private static readonly Microphone.get_devicesDelegate get_devicesDelegateField = IL2CPP.ResolveICall<Microphone.get_devicesDelegate>("UnityEngine.Microphone::get_devices");

		// Token: 0x0400019B RID: 411
		private static readonly Microphone.get_isAnyDeviceRecordingDelegate get_isAnyDeviceRecordingDelegateField = IL2CPP.ResolveICall<Microphone.get_isAnyDeviceRecordingDelegate>("UnityEngine.Microphone::get_isAnyDeviceRecording");

		// Token: 0x020000D7 RID: 215
		// (Invoke) Token: 0x0600037B RID: 891
		private delegate int GetMicrophoneDeviceIDFromNameDelegate(IntPtr name);

		// Token: 0x020000D8 RID: 216
		// (Invoke) Token: 0x0600037D RID: 893
		private delegate IntPtr StartRecordDelegate(int deviceID, bool loop, float lengthSec, int frequency);

		// Token: 0x020000D9 RID: 217
		// (Invoke) Token: 0x0600037F RID: 895
		private delegate void EndRecordDelegate(int deviceID);

		// Token: 0x020000DA RID: 218
		// (Invoke) Token: 0x06000381 RID: 897
		private delegate bool IsRecordingDelegate(int deviceID);

		// Token: 0x020000DB RID: 219
		// (Invoke) Token: 0x06000383 RID: 899
		private delegate int GetRecordPositionDelegate(int deviceID);

		// Token: 0x020000DC RID: 220
		// (Invoke) Token: 0x06000385 RID: 901
		private delegate void GetDeviceCapsDelegate(int deviceID, [Out] IntPtr minFreq, [Out] IntPtr maxFreq);

		// Token: 0x020000DD RID: 221
		// (Invoke) Token: 0x06000387 RID: 903
		private delegate IntPtr get_devicesDelegate();

		// Token: 0x020000DE RID: 222
		// (Invoke) Token: 0x06000389 RID: 905
		private delegate bool get_isAnyDeviceRecordingDelegate();
	}
}
