using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppRewired
{
	// Token: 0x0200002D RID: 45
	[StructLayout(2)]
	public struct HardwareControllerMapIdentifier
	{
		// Token: 0x06000361 RID: 865 RVA: 0x0003AB9C File Offset: 0x00038D9C
		// Note: this type is marked as 'beforefieldinit'.
		static HardwareControllerMapIdentifier()
		{
			Il2CppClassPointerStore<HardwareControllerMapIdentifier>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "HardwareControllerMapIdentifier");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HardwareControllerMapIdentifier>.NativeClassPtr);
			HardwareControllerMapIdentifier.NativeFieldInfoPtr_guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardwareControllerMapIdentifier>.NativeClassPtr, "guid");
			HardwareControllerMapIdentifier.NativeFieldInfoPtr_inputSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardwareControllerMapIdentifier>.NativeClassPtr, "inputSource");
			HardwareControllerMapIdentifier.NativeFieldInfoPtr_actualInputPlatform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardwareControllerMapIdentifier>.NativeClassPtr, "actualInputPlatform");
			HardwareControllerMapIdentifier.NativeFieldInfoPtr_variantIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardwareControllerMapIdentifier>.NativeClassPtr, "variantIndex");
			HardwareControllerMapIdentifier.NativeMethodInfoPtr__ctor_Public_Void_Guid_InputSource_InputPlatform_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareControllerMapIdentifier>.NativeClassPtr, 100663847);
		}

		// Token: 0x06000362 RID: 866 RVA: 0x0003AC30 File Offset: 0x00038E30
		[CallerCount(0)]
		public unsafe HardwareControllerMapIdentifier(Guid guid, InputSource inputSource, InputPlatform actualInputPlatform, int variantIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref guid;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputSource;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref actualInputPlatform;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref variantIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwareControllerMapIdentifier.NativeMethodInfoPtr__ctor_Public_Void_Guid_InputSource_InputPlatform_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000363 RID: 867 RVA: 0x000031C9 File Offset: 0x000013C9
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HardwareControllerMapIdentifier>.NativeClassPtr, ref this));
		}

		// Token: 0x040002E0 RID: 736
		private static readonly IntPtr NativeFieldInfoPtr_guid;

		// Token: 0x040002E1 RID: 737
		private static readonly IntPtr NativeFieldInfoPtr_inputSource;

		// Token: 0x040002E2 RID: 738
		private static readonly IntPtr NativeFieldInfoPtr_actualInputPlatform;

		// Token: 0x040002E3 RID: 739
		private static readonly IntPtr NativeFieldInfoPtr_variantIndex;

		// Token: 0x040002E4 RID: 740
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Guid_InputSource_InputPlatform_Int32_0;

		// Token: 0x040002E5 RID: 741
		[FieldOffset(0)]
		public readonly Guid guid;

		// Token: 0x040002E6 RID: 742
		[FieldOffset(16)]
		public readonly InputSource inputSource;

		// Token: 0x040002E7 RID: 743
		[FieldOffset(20)]
		public readonly InputPlatform actualInputPlatform;

		// Token: 0x040002E8 RID: 744
		[FieldOffset(24)]
		public readonly int variantIndex;
	}
}
