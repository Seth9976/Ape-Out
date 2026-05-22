using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000004 RID: 4
	public class AssetBundleRecompressOperation : AsyncOperation
	{
		// Token: 0x0600004A RID: 74 RVA: 0x00002E28 File Offset: 0x00001028
		// Note: this type is marked as 'beforefieldinit'.
		static AssetBundleRecompressOperation()
		{
			Il2CppClassPointerStore<AssetBundleRecompressOperation>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AssetBundleModule.dll", "UnityEngine", "AssetBundleRecompressOperation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetBundleRecompressOperation>.NativeClassPtr);
			AssetBundleRecompressOperation.get_humanReadableResultDelegateField = IL2CPP.ResolveICall<AssetBundleRecompressOperation.get_humanReadableResultDelegate>("UnityEngine.AssetBundleRecompressOperation::get_humanReadableResult");
			AssetBundleRecompressOperation.get_inputPathDelegateField = IL2CPP.ResolveICall<AssetBundleRecompressOperation.get_inputPathDelegate>("UnityEngine.AssetBundleRecompressOperation::get_inputPath");
			AssetBundleRecompressOperation.get_outputPathDelegateField = IL2CPP.ResolveICall<AssetBundleRecompressOperation.get_outputPathDelegate>("UnityEngine.AssetBundleRecompressOperation::get_outputPath");
			AssetBundleRecompressOperation.get_resultDelegateField = IL2CPP.ResolveICall<AssetBundleRecompressOperation.get_resultDelegate>("UnityEngine.AssetBundleRecompressOperation::get_result");
			AssetBundleRecompressOperation.get_successDelegateField = IL2CPP.ResolveICall<AssetBundleRecompressOperation.get_successDelegate>("UnityEngine.AssetBundleRecompressOperation::get_success");
		}

		// Token: 0x0600004B RID: 75 RVA: 0x000020D4 File Offset: 0x000002D4
		public AssetBundleRecompressOperation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600004C RID: 76 RVA: 0x00002EA4 File Offset: 0x000010A4
		public string humanReadableResult
		{
			get
			{
				IntPtr intPtr = AssetBundleRecompressOperation.get_humanReadableResultDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600004D RID: 77 RVA: 0x00002EC8 File Offset: 0x000010C8
		public string inputPath
		{
			get
			{
				IntPtr intPtr = AssetBundleRecompressOperation.get_inputPathDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600004E RID: 78 RVA: 0x00002EEC File Offset: 0x000010EC
		public string outputPath
		{
			get
			{
				IntPtr intPtr = AssetBundleRecompressOperation.get_outputPathDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600004F RID: 79 RVA: 0x000020DD File Offset: 0x000002DD
		public AssetBundleLoadResult result
		{
			get
			{
				return AssetBundleRecompressOperation.get_resultDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000050 RID: 80 RVA: 0x000020EF File Offset: 0x000002EF
		public bool success
		{
			get
			{
				return AssetBundleRecompressOperation.get_successDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x04000019 RID: 25
		private static readonly AssetBundleRecompressOperation.get_humanReadableResultDelegate get_humanReadableResultDelegateField;

		// Token: 0x0400001A RID: 26
		private static readonly AssetBundleRecompressOperation.get_inputPathDelegate get_inputPathDelegateField;

		// Token: 0x0400001B RID: 27
		private static readonly AssetBundleRecompressOperation.get_outputPathDelegate get_outputPathDelegateField;

		// Token: 0x0400001C RID: 28
		private static readonly AssetBundleRecompressOperation.get_resultDelegate get_resultDelegateField;

		// Token: 0x0400001D RID: 29
		private static readonly AssetBundleRecompressOperation.get_successDelegate get_successDelegateField;

		// Token: 0x0200001E RID: 30
		// (Invoke) Token: 0x0600008C RID: 140
		private delegate IntPtr get_humanReadableResultDelegate(IntPtr @this);

		// Token: 0x0200001F RID: 31
		// (Invoke) Token: 0x0600008E RID: 142
		private delegate IntPtr get_inputPathDelegate(IntPtr @this);

		// Token: 0x02000020 RID: 32
		// (Invoke) Token: 0x06000090 RID: 144
		private delegate IntPtr get_outputPathDelegate(IntPtr @this);

		// Token: 0x02000021 RID: 33
		// (Invoke) Token: 0x06000092 RID: 146
		private delegate AssetBundleLoadResult get_resultDelegate(IntPtr @this);

		// Token: 0x02000022 RID: 34
		// (Invoke) Token: 0x06000094 RID: 148
		private delegate bool get_successDelegate(IntPtr @this);
	}
}
