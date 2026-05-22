using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x0200005C RID: 92
	public static class HaltonSeq : Object
	{
		// Token: 0x060004EF RID: 1263 RVA: 0x00004A42 File Offset: 0x00002C42
		// Note: this type is marked as 'beforefieldinit'.
		static HaltonSeq()
		{
			Il2CppClassPointerStore<HaltonSeq>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Postprocessing.Runtime.dll", "UnityEngine.Rendering.PostProcessing", "HaltonSeq");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HaltonSeq>.NativeClassPtr);
			HaltonSeq.NativeMethodInfoPtr_Get_Public_Static_Single_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HaltonSeq>.NativeClassPtr, 100663778);
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x00015E40 File Offset: 0x00014040
		[CallerCount(0)]
		public unsafe static float Get(int index, int radix)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radix;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HaltonSeq.NativeMethodInfoPtr_Get_Public_Static_Single_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x00004A7B File Offset: 0x00002C7B
		public HaltonSeq(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000351 RID: 849
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Static_Single_Int32_Int32_0;
	}
}
