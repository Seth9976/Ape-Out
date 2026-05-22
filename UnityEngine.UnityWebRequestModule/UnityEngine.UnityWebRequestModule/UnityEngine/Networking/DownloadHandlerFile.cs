using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.IO;

namespace UnityEngine.Networking
{
	// Token: 0x02000010 RID: 16
	public sealed class DownloadHandlerFile : DownloadHandler
	{
		// Token: 0x0600013B RID: 315 RVA: 0x000026BA File Offset: 0x000008BA
		public static IntPtr Create(DownloadHandlerFile obj, string path, bool append)
		{
			return DownloadHandlerFile.CreateDelegateField(IL2CPP.Il2CppObjectBaseToPtr(obj), IL2CPP.ManagedStringToIl2Cpp(path), append);
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00006444 File Offset: 0x00004644
		public void InternalCreateVFS(string path, bool append)
		{
			string directoryName = Path.GetDirectoryName(path);
			bool flag = !Directory.Exists(directoryName);
			if (flag)
			{
				Directory.CreateDirectory(directoryName);
			}
			base.m_Ptr = DownloadHandlerFile.Create(this, path, append);
		}

		// Token: 0x0600013D RID: 317 RVA: 0x000026D3 File Offset: 0x000008D3
		public override Il2CppStructArray<byte> GetData()
		{
			throw new NotSupportedException("Raw data access is not supported");
		}

		// Token: 0x0600013E RID: 318 RVA: 0x000026E0 File Offset: 0x000008E0
		public override string GetText()
		{
			throw new NotSupportedException("String access is not supported");
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x0600013F RID: 319 RVA: 0x000026ED File Offset: 0x000008ED
		// (set) Token: 0x06000140 RID: 320 RVA: 0x000026FF File Offset: 0x000008FF
		public bool removeFileOnAbort
		{
			get
			{
				return DownloadHandlerFile.get_removeFileOnAbortDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				DownloadHandlerFile.set_removeFileOnAbortDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x040000A1 RID: 161
		private static readonly DownloadHandlerFile.CreateDelegate CreateDelegateField = IL2CPP.ResolveICall<DownloadHandlerFile.CreateDelegate>("UnityEngine.Networking.DownloadHandlerFile::Create");

		// Token: 0x040000A2 RID: 162
		private static readonly DownloadHandlerFile.get_removeFileOnAbortDelegate get_removeFileOnAbortDelegateField = IL2CPP.ResolveICall<DownloadHandlerFile.get_removeFileOnAbortDelegate>("UnityEngine.Networking.DownloadHandlerFile::get_removeFileOnAbort");

		// Token: 0x040000A3 RID: 163
		private static readonly DownloadHandlerFile.set_removeFileOnAbortDelegate set_removeFileOnAbortDelegateField = IL2CPP.ResolveICall<DownloadHandlerFile.set_removeFileOnAbortDelegate>("UnityEngine.Networking.DownloadHandlerFile::set_removeFileOnAbort");

		// Token: 0x02000036 RID: 54
		// (Invoke) Token: 0x06000186 RID: 390
		private delegate IntPtr CreateDelegate(IntPtr obj, IntPtr path, bool append);

		// Token: 0x02000037 RID: 55
		// (Invoke) Token: 0x06000188 RID: 392
		private delegate bool get_removeFileOnAbortDelegate(IntPtr @this);

		// Token: 0x02000038 RID: 56
		// (Invoke) Token: 0x0600018A RID: 394
		private delegate void set_removeFileOnAbortDelegate(IntPtr @this, bool value);
	}
}
