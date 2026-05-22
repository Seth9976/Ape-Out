using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.IO
{
	// Token: 0x02000222 RID: 546
	[StructLayout(2)]
	public struct MonoIOStat
	{
		// Token: 0x060023C2 RID: 9154 RVA: 0x000C5B88 File Offset: 0x000C3D88
		// Note: this type is marked as 'beforefieldinit'.
		static MonoIOStat()
		{
			Il2CppClassPointerStore<MonoIOStat>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "MonoIOStat");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoIOStat>.NativeClassPtr);
			MonoIOStat.NativeFieldInfoPtr_fileAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoIOStat>.NativeClassPtr, "fileAttributes");
			MonoIOStat.NativeFieldInfoPtr_Length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoIOStat>.NativeClassPtr, "Length");
			MonoIOStat.NativeFieldInfoPtr_CreationTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoIOStat>.NativeClassPtr, "CreationTime");
			MonoIOStat.NativeFieldInfoPtr_LastAccessTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoIOStat>.NativeClassPtr, "LastAccessTime");
			MonoIOStat.NativeFieldInfoPtr_LastWriteTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoIOStat>.NativeClassPtr, "LastWriteTime");
		}

		// Token: 0x060023C3 RID: 9155 RVA: 0x0000BECE File Offset: 0x0000A0CE
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MonoIOStat>.NativeClassPtr, ref this));
		}

		// Token: 0x04002029 RID: 8233
		private static readonly IntPtr NativeFieldInfoPtr_fileAttributes;

		// Token: 0x0400202A RID: 8234
		private static readonly IntPtr NativeFieldInfoPtr_Length;

		// Token: 0x0400202B RID: 8235
		private static readonly IntPtr NativeFieldInfoPtr_CreationTime;

		// Token: 0x0400202C RID: 8236
		private static readonly IntPtr NativeFieldInfoPtr_LastAccessTime;

		// Token: 0x0400202D RID: 8237
		private static readonly IntPtr NativeFieldInfoPtr_LastWriteTime;

		// Token: 0x0400202E RID: 8238
		[FieldOffset(0)]
		public FileAttributes fileAttributes;

		// Token: 0x0400202F RID: 8239
		[FieldOffset(8)]
		public long Length;

		// Token: 0x04002030 RID: 8240
		[FieldOffset(16)]
		public long CreationTime;

		// Token: 0x04002031 RID: 8241
		[FieldOffset(24)]
		public long LastAccessTime;

		// Token: 0x04002032 RID: 8242
		[FieldOffset(32)]
		public long LastWriteTime;
	}
}
