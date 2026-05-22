using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppTMPro
{
	// Token: 0x02000066 RID: 102
	[StructLayout(2)]
	public struct TMP_PageInfo
	{
		// Token: 0x06000C50 RID: 3152 RVA: 0x000340E8 File Offset: 0x000322E8
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_PageInfo()
		{
			Il2CppClassPointerStore<TMP_PageInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_PageInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_PageInfo>.NativeClassPtr);
			TMP_PageInfo.NativeFieldInfoPtr_firstCharacterIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_PageInfo>.NativeClassPtr, "firstCharacterIndex");
			TMP_PageInfo.NativeFieldInfoPtr_lastCharacterIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_PageInfo>.NativeClassPtr, "lastCharacterIndex");
			TMP_PageInfo.NativeFieldInfoPtr_ascender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_PageInfo>.NativeClassPtr, "ascender");
			TMP_PageInfo.NativeFieldInfoPtr_baseLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_PageInfo>.NativeClassPtr, "baseLine");
			TMP_PageInfo.NativeFieldInfoPtr_descender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_PageInfo>.NativeClassPtr, "descender");
		}

		// Token: 0x06000C51 RID: 3153 RVA: 0x00007ADF File Offset: 0x00005CDF
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_PageInfo>.NativeClassPtr, ref this));
		}

		// Token: 0x040009DD RID: 2525
		private static readonly IntPtr NativeFieldInfoPtr_firstCharacterIndex;

		// Token: 0x040009DE RID: 2526
		private static readonly IntPtr NativeFieldInfoPtr_lastCharacterIndex;

		// Token: 0x040009DF RID: 2527
		private static readonly IntPtr NativeFieldInfoPtr_ascender;

		// Token: 0x040009E0 RID: 2528
		private static readonly IntPtr NativeFieldInfoPtr_baseLine;

		// Token: 0x040009E1 RID: 2529
		private static readonly IntPtr NativeFieldInfoPtr_descender;

		// Token: 0x040009E2 RID: 2530
		[FieldOffset(0)]
		public int firstCharacterIndex;

		// Token: 0x040009E3 RID: 2531
		[FieldOffset(4)]
		public int lastCharacterIndex;

		// Token: 0x040009E4 RID: 2532
		[FieldOffset(8)]
		public float ascender;

		// Token: 0x040009E5 RID: 2533
		[FieldOffset(12)]
		public float baseLine;

		// Token: 0x040009E6 RID: 2534
		[FieldOffset(16)]
		public float descender;
	}
}
