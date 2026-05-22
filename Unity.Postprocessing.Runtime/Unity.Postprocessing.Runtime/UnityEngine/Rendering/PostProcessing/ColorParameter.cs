using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000043 RID: 67
	[Serializable]
	public sealed class ColorParameter : ParameterOverride<Color>
	{
		// Token: 0x060002D0 RID: 720 RVA: 0x0000E5A4 File Offset: 0x0000C7A4
		// Note: this type is marked as 'beforefieldinit'.
		static ColorParameter()
		{
			Il2CppClassPointerStore<ColorParameter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Postprocessing.Runtime.dll", "UnityEngine.Rendering.PostProcessing", "ColorParameter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorParameter>.NativeClassPtr);
			ColorParameter.NativeMethodInfoPtr_Interp_Public_Virtual_Void_Color_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorParameter>.NativeClassPtr, 100663503);
			ColorParameter.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector4_ColorParameter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorParameter>.NativeClassPtr, 100663504);
			ColorParameter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorParameter>.NativeClassPtr, 100663505);
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x0000E610 File Offset: 0x0000C810
		[CallerCount(0)]
		public unsafe override void Interp(Color from, Color to, float t)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorParameter.NativeMethodInfoPtr_Interp_Public_Virtual_Void_Color_Color_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x0000E66C File Offset: 0x0000C86C
		[CallerCount(0)]
		public unsafe static implicit operator Vector4(ColorParameter prop)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(prop);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorParameter.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector4_ColorParameter_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x0000E6B0 File Offset: 0x0000C8B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 445734, XrefRangeEnd = 445736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ColorParameter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorParameter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorParameter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x00003AF4 File Offset: 0x00001CF4
		public ColorParameter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040001C7 RID: 455
		private static readonly IntPtr NativeMethodInfoPtr_Interp_Public_Virtual_Void_Color_Color_Single_0;

		// Token: 0x040001C8 RID: 456
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Vector4_ColorParameter_0;

		// Token: 0x040001C9 RID: 457
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
