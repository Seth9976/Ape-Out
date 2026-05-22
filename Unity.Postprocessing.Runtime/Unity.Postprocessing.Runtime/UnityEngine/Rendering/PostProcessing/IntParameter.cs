using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000041 RID: 65
	[Serializable]
	public sealed class IntParameter : ParameterOverride<int>
	{
		// Token: 0x060002C9 RID: 713 RVA: 0x0000E478 File Offset: 0x0000C678
		// Note: this type is marked as 'beforefieldinit'.
		static IntParameter()
		{
			Il2CppClassPointerStore<IntParameter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Postprocessing.Runtime.dll", "UnityEngine.Rendering.PostProcessing", "IntParameter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntParameter>.NativeClassPtr);
			IntParameter.NativeMethodInfoPtr_Interp_Public_Virtual_Void_Int32_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntParameter>.NativeClassPtr, 100663500);
			IntParameter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntParameter>.NativeClassPtr, 100663501);
		}

		// Token: 0x060002CA RID: 714 RVA: 0x0000E4D0 File Offset: 0x0000C6D0
		[CallerCount(0)]
		public unsafe override void Interp(int from, int to, float t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref from;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntParameter.NativeMethodInfoPtr_Interp_Public_Virtual_Void_Int32_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002CB RID: 715 RVA: 0x0000E52C File Offset: 0x0000C72C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 445728, XrefRangeEnd = 445731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntParameter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntParameter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntParameter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002CC RID: 716 RVA: 0x00003AA9 File Offset: 0x00001CA9
		public IntParameter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040001C4 RID: 452
		private static readonly IntPtr NativeMethodInfoPtr_Interp_Public_Virtual_Void_Int32_Int32_Single_0;

		// Token: 0x040001C5 RID: 453
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
