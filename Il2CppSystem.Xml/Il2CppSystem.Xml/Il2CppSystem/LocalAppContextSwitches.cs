using System;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000016 RID: 22
	public static class LocalAppContextSwitches : Object
	{
		// Token: 0x0600014D RID: 333 RVA: 0x00018BB8 File Offset: 0x00016DB8
		// Note: this type is marked as 'beforefieldinit'.
		static LocalAppContextSwitches()
		{
			Il2CppClassPointerStore<LocalAppContextSwitches>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System", "LocalAppContextSwitches");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalAppContextSwitches>.NativeClassPtr);
			LocalAppContextSwitches.NativeFieldInfoPtr_IgnoreEmptyKeySequences = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalAppContextSwitches>.NativeClassPtr, "IgnoreEmptyKeySequences");
			LocalAppContextSwitches.NativeFieldInfoPtr_DontThrowOnInvalidSurrogatePairs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalAppContextSwitches>.NativeClassPtr, "DontThrowOnInvalidSurrogatePairs");
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00002956 File Offset: 0x00000B56
		public LocalAppContextSwitches(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x0600014F RID: 335 RVA: 0x00018C10 File Offset: 0x00016E10
		// (set) Token: 0x06000150 RID: 336 RVA: 0x0000295F File Offset: 0x00000B5F
		public unsafe static bool IgnoreEmptyKeySequences
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(LocalAppContextSwitches.NativeFieldInfoPtr_IgnoreEmptyKeySequences, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LocalAppContextSwitches.NativeFieldInfoPtr_IgnoreEmptyKeySequences, (void*)(&value));
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000151 RID: 337 RVA: 0x00018C2C File Offset: 0x00016E2C
		// (set) Token: 0x06000152 RID: 338 RVA: 0x0000296D File Offset: 0x00000B6D
		public unsafe static bool DontThrowOnInvalidSurrogatePairs
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(LocalAppContextSwitches.NativeFieldInfoPtr_DontThrowOnInvalidSurrogatePairs, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LocalAppContextSwitches.NativeFieldInfoPtr_DontThrowOnInvalidSurrogatePairs, (void*)(&value));
			}
		}

		// Token: 0x040000DA RID: 218
		private static readonly IntPtr NativeFieldInfoPtr_IgnoreEmptyKeySequences;

		// Token: 0x040000DB RID: 219
		private static readonly IntPtr NativeFieldInfoPtr_DontThrowOnInvalidSurrogatePairs;
	}
}
