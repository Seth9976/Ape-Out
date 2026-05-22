using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppTMPro
{
	// Token: 0x0200005B RID: 91
	[StructLayout(2)]
	public struct CaretInfo
	{
		// Token: 0x06000B8D RID: 2957 RVA: 0x00031444 File Offset: 0x0002F644
		// Note: this type is marked as 'beforefieldinit'.
		static CaretInfo()
		{
			Il2CppClassPointerStore<CaretInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "CaretInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CaretInfo>.NativeClassPtr);
			CaretInfo.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CaretInfo>.NativeClassPtr, "index");
			CaretInfo.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CaretInfo>.NativeClassPtr, "position");
			CaretInfo.NativeMethodInfoPtr__ctor_Public_Void_Int32_CaretPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaretInfo>.NativeClassPtr, 100664614);
		}

		// Token: 0x06000B8E RID: 2958 RVA: 0x000314B0 File Offset: 0x0002F6B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 76853, RefRangeEnd = 76855, XrefRangeStart = 76853, XrefRangeEnd = 76855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CaretInfo(int index, CaretPosition position)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CaretInfo.NativeMethodInfoPtr__ctor_Public_Void_Int32_CaretPosition_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B8F RID: 2959 RVA: 0x000076CB File Offset: 0x000058CB
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CaretInfo>.NativeClassPtr, ref this));
		}

		// Token: 0x04000942 RID: 2370
		private static readonly IntPtr NativeFieldInfoPtr_index;

		// Token: 0x04000943 RID: 2371
		private static readonly IntPtr NativeFieldInfoPtr_position;

		// Token: 0x04000944 RID: 2372
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_CaretPosition_0;

		// Token: 0x04000945 RID: 2373
		[FieldOffset(0)]
		public int index;

		// Token: 0x04000946 RID: 2374
		[FieldOffset(4)]
		public CaretPosition position;
	}
}
