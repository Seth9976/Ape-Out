using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000049 RID: 73
	[Serializable]
	public sealed class TextureParameter : ParameterOverride<Texture>
	{
		// Token: 0x060002ED RID: 749 RVA: 0x0000ED64 File Offset: 0x0000CF64
		// Note: this type is marked as 'beforefieldinit'.
		static TextureParameter()
		{
			Il2CppClassPointerStore<TextureParameter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Postprocessing.Runtime.dll", "UnityEngine.Rendering.PostProcessing", "TextureParameter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextureParameter>.NativeClassPtr);
			TextureParameter.NativeFieldInfoPtr_defaultState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureParameter>.NativeClassPtr, "defaultState");
			TextureParameter.NativeMethodInfoPtr_Interp_Public_Virtual_Void_Texture_Texture_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureParameter>.NativeClassPtr, 100663522);
			TextureParameter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureParameter>.NativeClassPtr, 100663523);
		}

		// Token: 0x060002EE RID: 750 RVA: 0x0000EDD0 File Offset: 0x0000CFD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 445757, XrefRangeEnd = 445908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Interp(Texture from, Texture to, float t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(from);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(to);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureParameter.NativeMethodInfoPtr_Interp_Public_Virtual_Void_Texture_Texture_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002EF RID: 751 RVA: 0x0000EE34 File Offset: 0x0000D034
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 445908, XrefRangeEnd = 445910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextureParameter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextureParameter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureParameter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x00003B21 File Offset: 0x00001D21
		public TextureParameter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x060002F1 RID: 753 RVA: 0x0000EE70 File Offset: 0x0000D070
		// (set) Token: 0x060002F2 RID: 754 RVA: 0x00003B2A File Offset: 0x00001D2A
		public unsafe TextureParameterDefault defaultState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureParameter.NativeFieldInfoPtr_defaultState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureParameter.NativeFieldInfoPtr_defaultState)) = value;
			}
		}

		// Token: 0x040001E0 RID: 480
		private static readonly IntPtr NativeFieldInfoPtr_defaultState;

		// Token: 0x040001E1 RID: 481
		private static readonly IntPtr NativeMethodInfoPtr_Interp_Public_Virtual_Void_Texture_Texture_Single_0;

		// Token: 0x040001E2 RID: 482
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
