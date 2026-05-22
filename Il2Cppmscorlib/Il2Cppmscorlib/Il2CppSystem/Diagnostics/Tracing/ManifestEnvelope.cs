using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x02000524 RID: 1316
	[StructLayout(2)]
	public struct ManifestEnvelope
	{
		// Token: 0x06004DA0 RID: 19872 RVA: 0x001650D4 File Offset: 0x001632D4
		// Note: this type is marked as 'beforefieldinit'.
		static ManifestEnvelope()
		{
			Il2CppClassPointerStore<ManifestEnvelope>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "ManifestEnvelope");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManifestEnvelope>.NativeClassPtr);
			ManifestEnvelope.NativeFieldInfoPtr_Format = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManifestEnvelope>.NativeClassPtr, "Format");
			ManifestEnvelope.NativeFieldInfoPtr_MajorVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManifestEnvelope>.NativeClassPtr, "MajorVersion");
			ManifestEnvelope.NativeFieldInfoPtr_MinorVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManifestEnvelope>.NativeClassPtr, "MinorVersion");
			ManifestEnvelope.NativeFieldInfoPtr_Magic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManifestEnvelope>.NativeClassPtr, "Magic");
			ManifestEnvelope.NativeFieldInfoPtr_TotalChunks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManifestEnvelope>.NativeClassPtr, "TotalChunks");
			ManifestEnvelope.NativeFieldInfoPtr_ChunkNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManifestEnvelope>.NativeClassPtr, "ChunkNumber");
		}

		// Token: 0x06004DA1 RID: 19873 RVA: 0x0001CF8E File Offset: 0x0001B18E
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ManifestEnvelope>.NativeClassPtr, ref this));
		}

		// Token: 0x04003EA1 RID: 16033
		private static readonly IntPtr NativeFieldInfoPtr_Format;

		// Token: 0x04003EA2 RID: 16034
		private static readonly IntPtr NativeFieldInfoPtr_MajorVersion;

		// Token: 0x04003EA3 RID: 16035
		private static readonly IntPtr NativeFieldInfoPtr_MinorVersion;

		// Token: 0x04003EA4 RID: 16036
		private static readonly IntPtr NativeFieldInfoPtr_Magic;

		// Token: 0x04003EA5 RID: 16037
		private static readonly IntPtr NativeFieldInfoPtr_TotalChunks;

		// Token: 0x04003EA6 RID: 16038
		private static readonly IntPtr NativeFieldInfoPtr_ChunkNumber;

		// Token: 0x04003EA7 RID: 16039
		[FieldOffset(0)]
		public ManifestEnvelope.ManifestFormats Format;

		// Token: 0x04003EA8 RID: 16040
		[FieldOffset(1)]
		public byte MajorVersion;

		// Token: 0x04003EA9 RID: 16041
		[FieldOffset(2)]
		public byte MinorVersion;

		// Token: 0x04003EAA RID: 16042
		[FieldOffset(3)]
		public byte Magic;

		// Token: 0x04003EAB RID: 16043
		[FieldOffset(4)]
		public ushort TotalChunks;

		// Token: 0x04003EAC RID: 16044
		[FieldOffset(6)]
		public ushort ChunkNumber;

		// Token: 0x0200068F RID: 1679
		[OriginalName("mscorlib.dll", "", "ManifestFormats")]
		public enum ManifestFormats : byte
		{
			// Token: 0x04004770 RID: 18288
			SimpleXmlFormat = 1
		}
	}
}
