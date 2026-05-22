using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.Versioning
{
	// Token: 0x02000326 RID: 806
	public static class BinaryCompatibility : Object
	{
		// Token: 0x06003533 RID: 13619 RVA: 0x00106660 File Offset: 0x00104860
		// Note: this type is marked as 'beforefieldinit'.
		static BinaryCompatibility()
		{
			Il2CppClassPointerStore<BinaryCompatibility>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Versioning", "BinaryCompatibility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BinaryCompatibility>.NativeClassPtr);
			BinaryCompatibility.NativeFieldInfoPtr_TargetsAtLeast_Desktop_V4_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryCompatibility>.NativeClassPtr, "TargetsAtLeast_Desktop_V4_5");
			BinaryCompatibility.NativeFieldInfoPtr_TargetsAtLeast_Desktop_V4_5_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryCompatibility>.NativeClassPtr, "TargetsAtLeast_Desktop_V4_5_1");
			BinaryCompatibility.NativeMethodInfoPtr_get_TargetsAtLeast_Desktop_V4_5_2_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryCompatibility>.NativeClassPtr, 100671600);
		}

		// Token: 0x17000CC4 RID: 3268
		// (get) Token: 0x06003534 RID: 13620 RVA: 0x001066CC File Offset: 0x001048CC
		public unsafe static bool TargetsAtLeast_Desktop_V4_5_2
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryCompatibility.NativeMethodInfoPtr_get_TargetsAtLeast_Desktop_V4_5_2_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003535 RID: 13621 RVA: 0x00012C80 File Offset: 0x00010E80
		public BinaryCompatibility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CC2 RID: 3266
		// (get) Token: 0x06003536 RID: 13622 RVA: 0x001066FC File Offset: 0x001048FC
		// (set) Token: 0x06003537 RID: 13623 RVA: 0x00012C89 File Offset: 0x00010E89
		public unsafe static bool TargetsAtLeast_Desktop_V4_5
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(BinaryCompatibility.NativeFieldInfoPtr_TargetsAtLeast_Desktop_V4_5, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BinaryCompatibility.NativeFieldInfoPtr_TargetsAtLeast_Desktop_V4_5, (void*)(&value));
			}
		}

		// Token: 0x17000CC3 RID: 3267
		// (get) Token: 0x06003538 RID: 13624 RVA: 0x00106718 File Offset: 0x00104918
		// (set) Token: 0x06003539 RID: 13625 RVA: 0x00012C97 File Offset: 0x00010E97
		public unsafe static bool TargetsAtLeast_Desktop_V4_5_1
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(BinaryCompatibility.NativeFieldInfoPtr_TargetsAtLeast_Desktop_V4_5_1, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BinaryCompatibility.NativeFieldInfoPtr_TargetsAtLeast_Desktop_V4_5_1, (void*)(&value));
			}
		}

		// Token: 0x04002D20 RID: 11552
		private static readonly IntPtr NativeFieldInfoPtr_TargetsAtLeast_Desktop_V4_5;

		// Token: 0x04002D21 RID: 11553
		private static readonly IntPtr NativeFieldInfoPtr_TargetsAtLeast_Desktop_V4_5_1;

		// Token: 0x04002D22 RID: 11554
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetsAtLeast_Desktop_V4_5_2_Public_Static_get_Boolean_0;
	}
}
