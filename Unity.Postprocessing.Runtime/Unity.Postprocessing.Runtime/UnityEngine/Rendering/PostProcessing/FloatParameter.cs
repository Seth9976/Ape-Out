using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000040 RID: 64
	[Serializable]
	public sealed class FloatParameter : ParameterOverride<float>
	{
		// Token: 0x060002C5 RID: 709 RVA: 0x0000E388 File Offset: 0x0000C588
		// Note: this type is marked as 'beforefieldinit'.
		static FloatParameter()
		{
			Il2CppClassPointerStore<FloatParameter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Postprocessing.Runtime.dll", "UnityEngine.Rendering.PostProcessing", "FloatParameter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FloatParameter>.NativeClassPtr);
			FloatParameter.NativeMethodInfoPtr_Interp_Public_Virtual_Void_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatParameter>.NativeClassPtr, 100663498);
			FloatParameter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatParameter>.NativeClassPtr, 100663499);
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x0000E3E0 File Offset: 0x0000C5E0
		[CallerCount(0)]
		public unsafe override void Interp(float from, float to, float t)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatParameter.NativeMethodInfoPtr_Interp_Public_Virtual_Void_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x0000E43C File Offset: 0x0000C63C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 445725, XrefRangeEnd = 445728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FloatParameter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FloatParameter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatParameter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x00003AA0 File Offset: 0x00001CA0
		public FloatParameter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040001C2 RID: 450
		private static readonly IntPtr NativeMethodInfoPtr_Interp_Public_Virtual_Void_Single_Single_Single_0;

		// Token: 0x040001C3 RID: 451
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
