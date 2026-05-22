using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Unity.Collections
{
	// Token: 0x0200002A RID: 42
	public static class xxHashDefaultKey : Object
	{
		// Token: 0x060001A9 RID: 425 RVA: 0x0000289C File Offset: 0x00000A9C
		// Note: this type is marked as 'beforefieldinit'.
		static xxHashDefaultKey()
		{
			Il2CppClassPointerStore<xxHashDefaultKey>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Collections.dll", "Unity.Collections", "xxHashDefaultKey");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<xxHashDefaultKey>.NativeClassPtr);
			xxHashDefaultKey.NativeFieldInfoPtr_kSecret = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<xxHashDefaultKey>.NativeClassPtr, "kSecret");
		}

		// Token: 0x060001AA RID: 426 RVA: 0x000028D5 File Offset: 0x00000AD5
		public xxHashDefaultKey(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060001AB RID: 427 RVA: 0x0000C6F4 File Offset: 0x0000A8F4
		// (set) Token: 0x060001AC RID: 428 RVA: 0x000028DE File Offset: 0x00000ADE
		public unsafe static Il2CppStructArray<byte> kSecret
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(xxHashDefaultKey.NativeFieldInfoPtr_kSecret, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(xxHashDefaultKey.NativeFieldInfoPtr_kSecret, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400044B RID: 1099
		private static readonly IntPtr NativeFieldInfoPtr_kSecret;
	}
}
