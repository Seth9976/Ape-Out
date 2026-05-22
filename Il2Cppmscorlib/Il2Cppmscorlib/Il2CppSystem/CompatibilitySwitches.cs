using System;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000107 RID: 263
	public static class CompatibilitySwitches : Object
	{
		// Token: 0x06001397 RID: 5015 RVA: 0x0007EF64 File Offset: 0x0007D164
		// Note: this type is marked as 'beforefieldinit'.
		static CompatibilitySwitches()
		{
			Il2CppClassPointerStore<CompatibilitySwitches>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "CompatibilitySwitches");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CompatibilitySwitches>.NativeClassPtr);
			CompatibilitySwitches.NativeFieldInfoPtr_IsAppEarlierThanSilverlight4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompatibilitySwitches>.NativeClassPtr, "IsAppEarlierThanSilverlight4");
			CompatibilitySwitches.NativeFieldInfoPtr_IsAppEarlierThanWindowsPhone8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompatibilitySwitches>.NativeClassPtr, "IsAppEarlierThanWindowsPhone8");
		}

		// Token: 0x06001398 RID: 5016 RVA: 0x00006AB6 File Offset: 0x00004CB6
		public CompatibilitySwitches(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x06001399 RID: 5017 RVA: 0x0007EFBC File Offset: 0x0007D1BC
		// (set) Token: 0x0600139A RID: 5018 RVA: 0x00006ABF File Offset: 0x00004CBF
		public unsafe static bool IsAppEarlierThanSilverlight4
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(CompatibilitySwitches.NativeFieldInfoPtr_IsAppEarlierThanSilverlight4, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CompatibilitySwitches.NativeFieldInfoPtr_IsAppEarlierThanSilverlight4, (void*)(&value));
			}
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x0600139B RID: 5019 RVA: 0x0007EFD8 File Offset: 0x0007D1D8
		// (set) Token: 0x0600139C RID: 5020 RVA: 0x00006ACD File Offset: 0x00004CCD
		public unsafe static bool IsAppEarlierThanWindowsPhone8
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(CompatibilitySwitches.NativeFieldInfoPtr_IsAppEarlierThanWindowsPhone8, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CompatibilitySwitches.NativeFieldInfoPtr_IsAppEarlierThanWindowsPhone8, (void*)(&value));
			}
		}

		// Token: 0x040010F5 RID: 4341
		private static readonly IntPtr NativeFieldInfoPtr_IsAppEarlierThanSilverlight4;

		// Token: 0x040010F6 RID: 4342
		private static readonly IntPtr NativeFieldInfoPtr_IsAppEarlierThanWindowsPhone8;
	}
}
