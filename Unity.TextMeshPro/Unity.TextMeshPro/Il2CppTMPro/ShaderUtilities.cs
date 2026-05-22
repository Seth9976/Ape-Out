using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppTMPro
{
	// Token: 0x0200003C RID: 60
	public static class ShaderUtilities : global::Il2CppSystem.Object
	{
		// Token: 0x06000643 RID: 1603 RVA: 0x0001F5C4 File Offset: 0x0001D7C4
		// Note: this type is marked as 'beforefieldinit'.
		static ShaderUtilities()
		{
			Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "ShaderUtilities");
			ShaderUtilities.NativeFieldInfoPtr_ID_MainTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_MainTex");
			ShaderUtilities.NativeFieldInfoPtr_ID_FaceTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_FaceTex");
			ShaderUtilities.NativeFieldInfoPtr_ID_FaceColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_FaceColor");
			ShaderUtilities.NativeFieldInfoPtr_ID_FaceDilate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_FaceDilate");
			ShaderUtilities.NativeFieldInfoPtr_ID_Shininess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_Shininess");
			ShaderUtilities.NativeFieldInfoPtr_ID_UnderlayColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_UnderlayColor");
			ShaderUtilities.NativeFieldInfoPtr_ID_UnderlayOffsetX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_UnderlayOffsetX");
			ShaderUtilities.NativeFieldInfoPtr_ID_UnderlayOffsetY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_UnderlayOffsetY");
			ShaderUtilities.NativeFieldInfoPtr_ID_UnderlayDilate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_UnderlayDilate");
			ShaderUtilities.NativeFieldInfoPtr_ID_UnderlaySoftness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_UnderlaySoftness");
			ShaderUtilities.NativeFieldInfoPtr_ID_UnderlayOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_UnderlayOffset");
			ShaderUtilities.NativeFieldInfoPtr_ID_UnderlayIsoPerimeter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_UnderlayIsoPerimeter");
			ShaderUtilities.NativeFieldInfoPtr_ID_WeightNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_WeightNormal");
			ShaderUtilities.NativeFieldInfoPtr_ID_WeightBold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_WeightBold");
			ShaderUtilities.NativeFieldInfoPtr_ID_OutlineTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_OutlineTex");
			ShaderUtilities.NativeFieldInfoPtr_ID_OutlineWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_OutlineWidth");
			ShaderUtilities.NativeFieldInfoPtr_ID_OutlineSoftness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_OutlineSoftness");
			ShaderUtilities.NativeFieldInfoPtr_ID_OutlineColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_OutlineColor");
			ShaderUtilities.NativeFieldInfoPtr_ID_Outline2Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_Outline2Color");
			ShaderUtilities.NativeFieldInfoPtr_ID_Outline2Width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_Outline2Width");
			ShaderUtilities.NativeFieldInfoPtr_ID_Padding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_Padding");
			ShaderUtilities.NativeFieldInfoPtr_ID_GradientScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_GradientScale");
			ShaderUtilities.NativeFieldInfoPtr_ID_ScaleX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_ScaleX");
			ShaderUtilities.NativeFieldInfoPtr_ID_ScaleY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_ScaleY");
			ShaderUtilities.NativeFieldInfoPtr_ID_PerspectiveFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_PerspectiveFilter");
			ShaderUtilities.NativeFieldInfoPtr_ID_Sharpness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_Sharpness");
			ShaderUtilities.NativeFieldInfoPtr_ID_TextureWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_TextureWidth");
			ShaderUtilities.NativeFieldInfoPtr_ID_TextureHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_TextureHeight");
			ShaderUtilities.NativeFieldInfoPtr_ID_BevelAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_BevelAmount");
			ShaderUtilities.NativeFieldInfoPtr_ID_GlowColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_GlowColor");
			ShaderUtilities.NativeFieldInfoPtr_ID_GlowOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_GlowOffset");
			ShaderUtilities.NativeFieldInfoPtr_ID_GlowPower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_GlowPower");
			ShaderUtilities.NativeFieldInfoPtr_ID_GlowOuter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_GlowOuter");
			ShaderUtilities.NativeFieldInfoPtr_ID_GlowInner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_GlowInner");
			ShaderUtilities.NativeFieldInfoPtr_ID_LightAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_LightAngle");
			ShaderUtilities.NativeFieldInfoPtr_ID_EnvMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_EnvMap");
			ShaderUtilities.NativeFieldInfoPtr_ID_EnvMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_EnvMatrix");
			ShaderUtilities.NativeFieldInfoPtr_ID_EnvMatrixRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_EnvMatrixRotation");
			ShaderUtilities.NativeFieldInfoPtr_ID_MaskCoord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_MaskCoord");
			ShaderUtilities.NativeFieldInfoPtr_ID_ClipRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_ClipRect");
			ShaderUtilities.NativeFieldInfoPtr_ID_MaskSoftnessX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_MaskSoftnessX");
			ShaderUtilities.NativeFieldInfoPtr_ID_MaskSoftnessY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_MaskSoftnessY");
			ShaderUtilities.NativeFieldInfoPtr_ID_VertexOffsetX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_VertexOffsetX");
			ShaderUtilities.NativeFieldInfoPtr_ID_VertexOffsetY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_VertexOffsetY");
			ShaderUtilities.NativeFieldInfoPtr_ID_UseClipRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_UseClipRect");
			ShaderUtilities.NativeFieldInfoPtr_ID_StencilID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_StencilID");
			ShaderUtilities.NativeFieldInfoPtr_ID_StencilOp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_StencilOp");
			ShaderUtilities.NativeFieldInfoPtr_ID_StencilComp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_StencilComp");
			ShaderUtilities.NativeFieldInfoPtr_ID_StencilReadMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_StencilReadMask");
			ShaderUtilities.NativeFieldInfoPtr_ID_StencilWriteMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_StencilWriteMask");
			ShaderUtilities.NativeFieldInfoPtr_ID_ShaderFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_ShaderFlags");
			ShaderUtilities.NativeFieldInfoPtr_ID_ScaleRatio_A = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_ScaleRatio_A");
			ShaderUtilities.NativeFieldInfoPtr_ID_ScaleRatio_B = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_ScaleRatio_B");
			ShaderUtilities.NativeFieldInfoPtr_ID_ScaleRatio_C = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_ScaleRatio_C");
			ShaderUtilities.NativeFieldInfoPtr_Keyword_Bevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "Keyword_Bevel");
			ShaderUtilities.NativeFieldInfoPtr_Keyword_Glow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "Keyword_Glow");
			ShaderUtilities.NativeFieldInfoPtr_Keyword_Underlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "Keyword_Underlay");
			ShaderUtilities.NativeFieldInfoPtr_Keyword_Ratios = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "Keyword_Ratios");
			ShaderUtilities.NativeFieldInfoPtr_Keyword_MASK_SOFT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "Keyword_MASK_SOFT");
			ShaderUtilities.NativeFieldInfoPtr_Keyword_MASK_HARD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "Keyword_MASK_HARD");
			ShaderUtilities.NativeFieldInfoPtr_Keyword_MASK_TEX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "Keyword_MASK_TEX");
			ShaderUtilities.NativeFieldInfoPtr_Keyword_Outline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "Keyword_Outline");
			ShaderUtilities.NativeFieldInfoPtr_ShaderTag_ZTestMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ShaderTag_ZTestMode");
			ShaderUtilities.NativeFieldInfoPtr_ShaderTag_CullMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ShaderTag_CullMode");
			ShaderUtilities.NativeFieldInfoPtr_m_clamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "m_clamp");
			ShaderUtilities.NativeFieldInfoPtr_isInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "isInitialized");
			ShaderUtilities.NativeFieldInfoPtr_k_ShaderRef_MobileSDF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "k_ShaderRef_MobileSDF");
			ShaderUtilities.NativeFieldInfoPtr_k_ShaderRef_MobileBitmap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "k_ShaderRef_MobileBitmap");
			ShaderUtilities.NativeMethodInfoPtr_get_ShaderRef_MobileSDF_Internal_Static_get_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, 100664073);
			ShaderUtilities.NativeMethodInfoPtr_get_ShaderRef_MobileBitmap_Internal_Static_get_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, 100664074);
			ShaderUtilities.NativeMethodInfoPtr_GetShaderPropertyIDs_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, 100664076);
			ShaderUtilities.NativeMethodInfoPtr_UpdateShaderRatios_Public_Static_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, 100664077);
			ShaderUtilities.NativeMethodInfoPtr_GetFontExtent_Public_Static_Vector4_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, 100664078);
			ShaderUtilities.NativeMethodInfoPtr_IsMaskingEnabled_Public_Static_Boolean_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, 100664079);
			ShaderUtilities.NativeMethodInfoPtr_GetPadding_Public_Static_Single_Material_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, 100664080);
			ShaderUtilities.NativeMethodInfoPtr_GetPadding_Public_Static_Single_Il2CppReferenceArray_1_Material_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, 100664081);
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x06000644 RID: 1604 RVA: 0x0001FBDC File Offset: 0x0001DDDC
		public unsafe static Shader ShaderRef_MobileSDF
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 458410, RefRangeEnd = 458411, XrefRangeStart = 458385, XrefRangeEnd = 458410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderUtilities.NativeMethodInfoPtr_get_ShaderRef_MobileSDF_Internal_Static_get_Shader_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr3) : null;
			}
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x06000645 RID: 1605 RVA: 0x0001FC10 File Offset: 0x0001DE10
		public unsafe static Shader ShaderRef_MobileBitmap
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 458436, RefRangeEnd = 458437, XrefRangeStart = 458411, XrefRangeEnd = 458436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderUtilities.NativeMethodInfoPtr_get_ShaderRef_MobileBitmap_Internal_Static_get_Shader_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr3) : null;
			}
		}

		// Token: 0x06000646 RID: 1606 RVA: 0x0001FC44 File Offset: 0x0001DE44
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 458757, RefRangeEnd = 458765, XrefRangeStart = 458437, XrefRangeEnd = 458757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetShaderPropertyIDs()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderUtilities.NativeMethodInfoPtr_GetShaderPropertyIDs_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000647 RID: 1607 RVA: 0x0001FC6C File Offset: 0x0001DE6C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 458838, RefRangeEnd = 458840, XrefRangeStart = 458765, XrefRangeEnd = 458838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UpdateShaderRatios(Material mat)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mat);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderUtilities.NativeMethodInfoPtr_UpdateShaderRatios_Public_Static_Void_Material_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000648 RID: 1608 RVA: 0x0001FCA4 File Offset: 0x0001DEA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector4 GetFontExtent(Material material)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(material);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderUtilities.NativeMethodInfoPtr_GetFontExtent_Public_Static_Vector4_Material_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000649 RID: 1609 RVA: 0x0001FCE8 File Offset: 0x0001DEE8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 458875, RefRangeEnd = 458880, XrefRangeStart = 458840, XrefRangeEnd = 458875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsMaskingEnabled(Material material)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(material);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderUtilities.NativeMethodInfoPtr_IsMaskingEnabled_Public_Static_Boolean_Material_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600064A RID: 1610 RVA: 0x0001FD2C File Offset: 0x0001DF2C
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 459002, RefRangeEnd = 459013, XrefRangeStart = 458880, XrefRangeEnd = 459002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetPadding(Material material, bool enableExtraPadding, bool isBold)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(material);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enableExtraPadding;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isBold;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderUtilities.NativeMethodInfoPtr_GetPadding_Public_Static_Single_Material_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600064B RID: 1611 RVA: 0x0001FD8C File Offset: 0x0001DF8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 459013, XrefRangeEnd = 459117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetPadding(Il2CppReferenceArray<Material> materials, bool enableExtraPadding, bool isBold)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(materials);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enableExtraPadding;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isBold;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderUtilities.NativeMethodInfoPtr_GetPadding_Public_Static_Single_Il2CppReferenceArray_1_Material_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600064C RID: 1612 RVA: 0x00004DBE File Offset: 0x00002FBE
		public ShaderUtilities(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x0600064D RID: 1613 RVA: 0x0001FDEC File Offset: 0x0001DFEC
		// (set) Token: 0x0600064E RID: 1614 RVA: 0x00004DC7 File Offset: 0x00002FC7
		public unsafe static int ID_MainTex
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_MainTex, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_MainTex, (void*)(&value));
			}
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x0600064F RID: 1615 RVA: 0x0001FE08 File Offset: 0x0001E008
		// (set) Token: 0x06000650 RID: 1616 RVA: 0x00004DD5 File Offset: 0x00002FD5
		public unsafe static int ID_FaceTex
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_FaceTex, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_FaceTex, (void*)(&value));
			}
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x06000651 RID: 1617 RVA: 0x0001FE24 File Offset: 0x0001E024
		// (set) Token: 0x06000652 RID: 1618 RVA: 0x00004DE3 File Offset: 0x00002FE3
		public unsafe static int ID_FaceColor
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_FaceColor, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_FaceColor, (void*)(&value));
			}
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x06000653 RID: 1619 RVA: 0x0001FE40 File Offset: 0x0001E040
		// (set) Token: 0x06000654 RID: 1620 RVA: 0x00004DF1 File Offset: 0x00002FF1
		public unsafe static int ID_FaceDilate
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_FaceDilate, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_FaceDilate, (void*)(&value));
			}
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x06000655 RID: 1621 RVA: 0x0001FE5C File Offset: 0x0001E05C
		// (set) Token: 0x06000656 RID: 1622 RVA: 0x00004DFF File Offset: 0x00002FFF
		public unsafe static int ID_Shininess
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_Shininess, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_Shininess, (void*)(&value));
			}
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x06000657 RID: 1623 RVA: 0x0001FE78 File Offset: 0x0001E078
		// (set) Token: 0x06000658 RID: 1624 RVA: 0x00004E0D File Offset: 0x0000300D
		public unsafe static int ID_UnderlayColor
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_UnderlayColor, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_UnderlayColor, (void*)(&value));
			}
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06000659 RID: 1625 RVA: 0x0001FE94 File Offset: 0x0001E094
		// (set) Token: 0x0600065A RID: 1626 RVA: 0x00004E1B File Offset: 0x0000301B
		public unsafe static int ID_UnderlayOffsetX
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_UnderlayOffsetX, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_UnderlayOffsetX, (void*)(&value));
			}
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x0600065B RID: 1627 RVA: 0x0001FEB0 File Offset: 0x0001E0B0
		// (set) Token: 0x0600065C RID: 1628 RVA: 0x00004E29 File Offset: 0x00003029
		public unsafe static int ID_UnderlayOffsetY
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_UnderlayOffsetY, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_UnderlayOffsetY, (void*)(&value));
			}
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x0600065D RID: 1629 RVA: 0x0001FECC File Offset: 0x0001E0CC
		// (set) Token: 0x0600065E RID: 1630 RVA: 0x00004E37 File Offset: 0x00003037
		public unsafe static int ID_UnderlayDilate
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_UnderlayDilate, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_UnderlayDilate, (void*)(&value));
			}
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x0600065F RID: 1631 RVA: 0x0001FEE8 File Offset: 0x0001E0E8
		// (set) Token: 0x06000660 RID: 1632 RVA: 0x00004E45 File Offset: 0x00003045
		public unsafe static int ID_UnderlaySoftness
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_UnderlaySoftness, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_UnderlaySoftness, (void*)(&value));
			}
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x06000661 RID: 1633 RVA: 0x0001FF04 File Offset: 0x0001E104
		// (set) Token: 0x06000662 RID: 1634 RVA: 0x00004E53 File Offset: 0x00003053
		public unsafe static int ID_UnderlayOffset
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_UnderlayOffset, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_UnderlayOffset, (void*)(&value));
			}
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x06000663 RID: 1635 RVA: 0x0001FF20 File Offset: 0x0001E120
		// (set) Token: 0x06000664 RID: 1636 RVA: 0x00004E61 File Offset: 0x00003061
		public unsafe static int ID_UnderlayIsoPerimeter
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_UnderlayIsoPerimeter, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_UnderlayIsoPerimeter, (void*)(&value));
			}
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x06000665 RID: 1637 RVA: 0x0001FF3C File Offset: 0x0001E13C
		// (set) Token: 0x06000666 RID: 1638 RVA: 0x00004E6F File Offset: 0x0000306F
		public unsafe static int ID_WeightNormal
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_WeightNormal, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_WeightNormal, (void*)(&value));
			}
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x06000667 RID: 1639 RVA: 0x0001FF58 File Offset: 0x0001E158
		// (set) Token: 0x06000668 RID: 1640 RVA: 0x00004E7D File Offset: 0x0000307D
		public unsafe static int ID_WeightBold
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_WeightBold, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_WeightBold, (void*)(&value));
			}
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x06000669 RID: 1641 RVA: 0x0001FF74 File Offset: 0x0001E174
		// (set) Token: 0x0600066A RID: 1642 RVA: 0x00004E8B File Offset: 0x0000308B
		public unsafe static int ID_OutlineTex
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_OutlineTex, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_OutlineTex, (void*)(&value));
			}
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x0600066B RID: 1643 RVA: 0x0001FF90 File Offset: 0x0001E190
		// (set) Token: 0x0600066C RID: 1644 RVA: 0x00004E99 File Offset: 0x00003099
		public unsafe static int ID_OutlineWidth
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_OutlineWidth, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_OutlineWidth, (void*)(&value));
			}
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x0600066D RID: 1645 RVA: 0x0001FFAC File Offset: 0x0001E1AC
		// (set) Token: 0x0600066E RID: 1646 RVA: 0x00004EA7 File Offset: 0x000030A7
		public unsafe static int ID_OutlineSoftness
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_OutlineSoftness, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_OutlineSoftness, (void*)(&value));
			}
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x0600066F RID: 1647 RVA: 0x0001FFC8 File Offset: 0x0001E1C8
		// (set) Token: 0x06000670 RID: 1648 RVA: 0x00004EB5 File Offset: 0x000030B5
		public unsafe static int ID_OutlineColor
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_OutlineColor, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_OutlineColor, (void*)(&value));
			}
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x06000671 RID: 1649 RVA: 0x0001FFE4 File Offset: 0x0001E1E4
		// (set) Token: 0x06000672 RID: 1650 RVA: 0x00004EC3 File Offset: 0x000030C3
		public unsafe static int ID_Outline2Color
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_Outline2Color, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_Outline2Color, (void*)(&value));
			}
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x06000673 RID: 1651 RVA: 0x00020000 File Offset: 0x0001E200
		// (set) Token: 0x06000674 RID: 1652 RVA: 0x00004ED1 File Offset: 0x000030D1
		public unsafe static int ID_Outline2Width
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_Outline2Width, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_Outline2Width, (void*)(&value));
			}
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x06000675 RID: 1653 RVA: 0x0002001C File Offset: 0x0001E21C
		// (set) Token: 0x06000676 RID: 1654 RVA: 0x00004EDF File Offset: 0x000030DF
		public unsafe static int ID_Padding
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_Padding, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_Padding, (void*)(&value));
			}
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x06000677 RID: 1655 RVA: 0x00020038 File Offset: 0x0001E238
		// (set) Token: 0x06000678 RID: 1656 RVA: 0x00004EED File Offset: 0x000030ED
		public unsafe static int ID_GradientScale
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_GradientScale, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_GradientScale, (void*)(&value));
			}
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x06000679 RID: 1657 RVA: 0x00020054 File Offset: 0x0001E254
		// (set) Token: 0x0600067A RID: 1658 RVA: 0x00004EFB File Offset: 0x000030FB
		public unsafe static int ID_ScaleX
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_ScaleX, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_ScaleX, (void*)(&value));
			}
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x0600067B RID: 1659 RVA: 0x00020070 File Offset: 0x0001E270
		// (set) Token: 0x0600067C RID: 1660 RVA: 0x00004F09 File Offset: 0x00003109
		public unsafe static int ID_ScaleY
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_ScaleY, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_ScaleY, (void*)(&value));
			}
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x0600067D RID: 1661 RVA: 0x0002008C File Offset: 0x0001E28C
		// (set) Token: 0x0600067E RID: 1662 RVA: 0x00004F17 File Offset: 0x00003117
		public unsafe static int ID_PerspectiveFilter
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_PerspectiveFilter, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_PerspectiveFilter, (void*)(&value));
			}
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x0600067F RID: 1663 RVA: 0x000200A8 File Offset: 0x0001E2A8
		// (set) Token: 0x06000680 RID: 1664 RVA: 0x00004F25 File Offset: 0x00003125
		public unsafe static int ID_Sharpness
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_Sharpness, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_Sharpness, (void*)(&value));
			}
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x06000681 RID: 1665 RVA: 0x000200C4 File Offset: 0x0001E2C4
		// (set) Token: 0x06000682 RID: 1666 RVA: 0x00004F33 File Offset: 0x00003133
		public unsafe static int ID_TextureWidth
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_TextureWidth, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_TextureWidth, (void*)(&value));
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x06000683 RID: 1667 RVA: 0x000200E0 File Offset: 0x0001E2E0
		// (set) Token: 0x06000684 RID: 1668 RVA: 0x00004F41 File Offset: 0x00003141
		public unsafe static int ID_TextureHeight
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_TextureHeight, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_TextureHeight, (void*)(&value));
			}
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x06000685 RID: 1669 RVA: 0x000200FC File Offset: 0x0001E2FC
		// (set) Token: 0x06000686 RID: 1670 RVA: 0x00004F4F File Offset: 0x0000314F
		public unsafe static int ID_BevelAmount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_BevelAmount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_BevelAmount, (void*)(&value));
			}
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x06000687 RID: 1671 RVA: 0x00020118 File Offset: 0x0001E318
		// (set) Token: 0x06000688 RID: 1672 RVA: 0x00004F5D File Offset: 0x0000315D
		public unsafe static int ID_GlowColor
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_GlowColor, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_GlowColor, (void*)(&value));
			}
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x06000689 RID: 1673 RVA: 0x00020134 File Offset: 0x0001E334
		// (set) Token: 0x0600068A RID: 1674 RVA: 0x00004F6B File Offset: 0x0000316B
		public unsafe static int ID_GlowOffset
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_GlowOffset, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_GlowOffset, (void*)(&value));
			}
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x0600068B RID: 1675 RVA: 0x00020150 File Offset: 0x0001E350
		// (set) Token: 0x0600068C RID: 1676 RVA: 0x00004F79 File Offset: 0x00003179
		public unsafe static int ID_GlowPower
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_GlowPower, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_GlowPower, (void*)(&value));
			}
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x0600068D RID: 1677 RVA: 0x0002016C File Offset: 0x0001E36C
		// (set) Token: 0x0600068E RID: 1678 RVA: 0x00004F87 File Offset: 0x00003187
		public unsafe static int ID_GlowOuter
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_GlowOuter, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_GlowOuter, (void*)(&value));
			}
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x0600068F RID: 1679 RVA: 0x00020188 File Offset: 0x0001E388
		// (set) Token: 0x06000690 RID: 1680 RVA: 0x00004F95 File Offset: 0x00003195
		public unsafe static int ID_GlowInner
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_GlowInner, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_GlowInner, (void*)(&value));
			}
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x06000691 RID: 1681 RVA: 0x000201A4 File Offset: 0x0001E3A4
		// (set) Token: 0x06000692 RID: 1682 RVA: 0x00004FA3 File Offset: 0x000031A3
		public unsafe static int ID_LightAngle
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_LightAngle, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_LightAngle, (void*)(&value));
			}
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x06000693 RID: 1683 RVA: 0x000201C0 File Offset: 0x0001E3C0
		// (set) Token: 0x06000694 RID: 1684 RVA: 0x00004FB1 File Offset: 0x000031B1
		public unsafe static int ID_EnvMap
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_EnvMap, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_EnvMap, (void*)(&value));
			}
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x06000695 RID: 1685 RVA: 0x000201DC File Offset: 0x0001E3DC
		// (set) Token: 0x06000696 RID: 1686 RVA: 0x00004FBF File Offset: 0x000031BF
		public unsafe static int ID_EnvMatrix
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_EnvMatrix, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_EnvMatrix, (void*)(&value));
			}
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x06000697 RID: 1687 RVA: 0x000201F8 File Offset: 0x0001E3F8
		// (set) Token: 0x06000698 RID: 1688 RVA: 0x00004FCD File Offset: 0x000031CD
		public unsafe static int ID_EnvMatrixRotation
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_EnvMatrixRotation, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_EnvMatrixRotation, (void*)(&value));
			}
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x06000699 RID: 1689 RVA: 0x00020214 File Offset: 0x0001E414
		// (set) Token: 0x0600069A RID: 1690 RVA: 0x00004FDB File Offset: 0x000031DB
		public unsafe static int ID_MaskCoord
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_MaskCoord, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_MaskCoord, (void*)(&value));
			}
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x0600069B RID: 1691 RVA: 0x00020230 File Offset: 0x0001E430
		// (set) Token: 0x0600069C RID: 1692 RVA: 0x00004FE9 File Offset: 0x000031E9
		public unsafe static int ID_ClipRect
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_ClipRect, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_ClipRect, (void*)(&value));
			}
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x0600069D RID: 1693 RVA: 0x0002024C File Offset: 0x0001E44C
		// (set) Token: 0x0600069E RID: 1694 RVA: 0x00004FF7 File Offset: 0x000031F7
		public unsafe static int ID_MaskSoftnessX
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_MaskSoftnessX, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_MaskSoftnessX, (void*)(&value));
			}
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x0600069F RID: 1695 RVA: 0x00020268 File Offset: 0x0001E468
		// (set) Token: 0x060006A0 RID: 1696 RVA: 0x00005005 File Offset: 0x00003205
		public unsafe static int ID_MaskSoftnessY
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_MaskSoftnessY, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_MaskSoftnessY, (void*)(&value));
			}
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x060006A1 RID: 1697 RVA: 0x00020284 File Offset: 0x0001E484
		// (set) Token: 0x060006A2 RID: 1698 RVA: 0x00005013 File Offset: 0x00003213
		public unsafe static int ID_VertexOffsetX
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_VertexOffsetX, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_VertexOffsetX, (void*)(&value));
			}
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x060006A3 RID: 1699 RVA: 0x000202A0 File Offset: 0x0001E4A0
		// (set) Token: 0x060006A4 RID: 1700 RVA: 0x00005021 File Offset: 0x00003221
		public unsafe static int ID_VertexOffsetY
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_VertexOffsetY, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_VertexOffsetY, (void*)(&value));
			}
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x060006A5 RID: 1701 RVA: 0x000202BC File Offset: 0x0001E4BC
		// (set) Token: 0x060006A6 RID: 1702 RVA: 0x0000502F File Offset: 0x0000322F
		public unsafe static int ID_UseClipRect
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_UseClipRect, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_UseClipRect, (void*)(&value));
			}
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x060006A7 RID: 1703 RVA: 0x000202D8 File Offset: 0x0001E4D8
		// (set) Token: 0x060006A8 RID: 1704 RVA: 0x0000503D File Offset: 0x0000323D
		public unsafe static int ID_StencilID
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_StencilID, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_StencilID, (void*)(&value));
			}
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x060006A9 RID: 1705 RVA: 0x000202F4 File Offset: 0x0001E4F4
		// (set) Token: 0x060006AA RID: 1706 RVA: 0x0000504B File Offset: 0x0000324B
		public unsafe static int ID_StencilOp
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_StencilOp, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_StencilOp, (void*)(&value));
			}
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x060006AB RID: 1707 RVA: 0x00020310 File Offset: 0x0001E510
		// (set) Token: 0x060006AC RID: 1708 RVA: 0x00005059 File Offset: 0x00003259
		public unsafe static int ID_StencilComp
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_StencilComp, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_StencilComp, (void*)(&value));
			}
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x060006AD RID: 1709 RVA: 0x0002032C File Offset: 0x0001E52C
		// (set) Token: 0x060006AE RID: 1710 RVA: 0x00005067 File Offset: 0x00003267
		public unsafe static int ID_StencilReadMask
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_StencilReadMask, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_StencilReadMask, (void*)(&value));
			}
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x060006AF RID: 1711 RVA: 0x00020348 File Offset: 0x0001E548
		// (set) Token: 0x060006B0 RID: 1712 RVA: 0x00005075 File Offset: 0x00003275
		public unsafe static int ID_StencilWriteMask
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_StencilWriteMask, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_StencilWriteMask, (void*)(&value));
			}
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x060006B1 RID: 1713 RVA: 0x00020364 File Offset: 0x0001E564
		// (set) Token: 0x060006B2 RID: 1714 RVA: 0x00005083 File Offset: 0x00003283
		public unsafe static int ID_ShaderFlags
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_ShaderFlags, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_ShaderFlags, (void*)(&value));
			}
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x060006B3 RID: 1715 RVA: 0x00020380 File Offset: 0x0001E580
		// (set) Token: 0x060006B4 RID: 1716 RVA: 0x00005091 File Offset: 0x00003291
		public unsafe static int ID_ScaleRatio_A
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_ScaleRatio_A, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_ScaleRatio_A, (void*)(&value));
			}
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x060006B5 RID: 1717 RVA: 0x0002039C File Offset: 0x0001E59C
		// (set) Token: 0x060006B6 RID: 1718 RVA: 0x0000509F File Offset: 0x0000329F
		public unsafe static int ID_ScaleRatio_B
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_ScaleRatio_B, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_ScaleRatio_B, (void*)(&value));
			}
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x060006B7 RID: 1719 RVA: 0x000203B8 File Offset: 0x0001E5B8
		// (set) Token: 0x060006B8 RID: 1720 RVA: 0x000050AD File Offset: 0x000032AD
		public unsafe static int ID_ScaleRatio_C
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ID_ScaleRatio_C, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ID_ScaleRatio_C, (void*)(&value));
			}
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x060006B9 RID: 1721 RVA: 0x000203D4 File Offset: 0x0001E5D4
		// (set) Token: 0x060006BA RID: 1722 RVA: 0x000050BB File Offset: 0x000032BB
		public unsafe static string Keyword_Bevel
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_Keyword_Bevel, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_Keyword_Bevel, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x060006BB RID: 1723 RVA: 0x000203F4 File Offset: 0x0001E5F4
		// (set) Token: 0x060006BC RID: 1724 RVA: 0x000050CD File Offset: 0x000032CD
		public unsafe static string Keyword_Glow
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_Keyword_Glow, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_Keyword_Glow, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x060006BD RID: 1725 RVA: 0x00020414 File Offset: 0x0001E614
		// (set) Token: 0x060006BE RID: 1726 RVA: 0x000050DF File Offset: 0x000032DF
		public unsafe static string Keyword_Underlay
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_Keyword_Underlay, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_Keyword_Underlay, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x060006BF RID: 1727 RVA: 0x00020434 File Offset: 0x0001E634
		// (set) Token: 0x060006C0 RID: 1728 RVA: 0x000050F1 File Offset: 0x000032F1
		public unsafe static string Keyword_Ratios
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_Keyword_Ratios, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_Keyword_Ratios, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x060006C1 RID: 1729 RVA: 0x00020454 File Offset: 0x0001E654
		// (set) Token: 0x060006C2 RID: 1730 RVA: 0x00005103 File Offset: 0x00003303
		public unsafe static string Keyword_MASK_SOFT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_Keyword_MASK_SOFT, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_Keyword_MASK_SOFT, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x060006C3 RID: 1731 RVA: 0x00020474 File Offset: 0x0001E674
		// (set) Token: 0x060006C4 RID: 1732 RVA: 0x00005115 File Offset: 0x00003315
		public unsafe static string Keyword_MASK_HARD
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_Keyword_MASK_HARD, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_Keyword_MASK_HARD, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x060006C5 RID: 1733 RVA: 0x00020494 File Offset: 0x0001E694
		// (set) Token: 0x060006C6 RID: 1734 RVA: 0x00005127 File Offset: 0x00003327
		public unsafe static string Keyword_MASK_TEX
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_Keyword_MASK_TEX, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_Keyword_MASK_TEX, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x060006C7 RID: 1735 RVA: 0x000204B4 File Offset: 0x0001E6B4
		// (set) Token: 0x060006C8 RID: 1736 RVA: 0x00005139 File Offset: 0x00003339
		public unsafe static string Keyword_Outline
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_Keyword_Outline, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_Keyword_Outline, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x060006C9 RID: 1737 RVA: 0x000204D4 File Offset: 0x0001E6D4
		// (set) Token: 0x060006CA RID: 1738 RVA: 0x0000514B File Offset: 0x0000334B
		public unsafe static string ShaderTag_ZTestMode
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ShaderTag_ZTestMode, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ShaderTag_ZTestMode, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x060006CB RID: 1739 RVA: 0x000204F4 File Offset: 0x0001E6F4
		// (set) Token: 0x060006CC RID: 1740 RVA: 0x0000515D File Offset: 0x0000335D
		public unsafe static string ShaderTag_CullMode
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_ShaderTag_CullMode, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_ShaderTag_CullMode, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x060006CD RID: 1741 RVA: 0x00020514 File Offset: 0x0001E714
		// (set) Token: 0x060006CE RID: 1742 RVA: 0x0000516F File Offset: 0x0000336F
		public unsafe static float m_clamp
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_m_clamp, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_m_clamp, (void*)(&value));
			}
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x060006CF RID: 1743 RVA: 0x00020530 File Offset: 0x0001E730
		// (set) Token: 0x060006D0 RID: 1744 RVA: 0x0000517D File Offset: 0x0000337D
		public unsafe static bool isInitialized
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_isInitialized, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_isInitialized, (void*)(&value));
			}
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x060006D1 RID: 1745 RVA: 0x0002054C File Offset: 0x0001E74C
		// (set) Token: 0x060006D2 RID: 1746 RVA: 0x0000518B File Offset: 0x0000338B
		public unsafe static Shader k_ShaderRef_MobileSDF
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_k_ShaderRef_MobileSDF, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_k_ShaderRef_MobileSDF, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x060006D3 RID: 1747 RVA: 0x00020574 File Offset: 0x0001E774
		// (set) Token: 0x060006D4 RID: 1748 RVA: 0x0000519D File Offset: 0x0000339D
		public unsafe static Shader k_ShaderRef_MobileBitmap
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtilities.NativeFieldInfoPtr_k_ShaderRef_MobileBitmap, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtilities.NativeFieldInfoPtr_k_ShaderRef_MobileBitmap, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400052F RID: 1327
		private static readonly IntPtr NativeFieldInfoPtr_ID_MainTex;

		// Token: 0x04000530 RID: 1328
		private static readonly IntPtr NativeFieldInfoPtr_ID_FaceTex;

		// Token: 0x04000531 RID: 1329
		private static readonly IntPtr NativeFieldInfoPtr_ID_FaceColor;

		// Token: 0x04000532 RID: 1330
		private static readonly IntPtr NativeFieldInfoPtr_ID_FaceDilate;

		// Token: 0x04000533 RID: 1331
		private static readonly IntPtr NativeFieldInfoPtr_ID_Shininess;

		// Token: 0x04000534 RID: 1332
		private static readonly IntPtr NativeFieldInfoPtr_ID_UnderlayColor;

		// Token: 0x04000535 RID: 1333
		private static readonly IntPtr NativeFieldInfoPtr_ID_UnderlayOffsetX;

		// Token: 0x04000536 RID: 1334
		private static readonly IntPtr NativeFieldInfoPtr_ID_UnderlayOffsetY;

		// Token: 0x04000537 RID: 1335
		private static readonly IntPtr NativeFieldInfoPtr_ID_UnderlayDilate;

		// Token: 0x04000538 RID: 1336
		private static readonly IntPtr NativeFieldInfoPtr_ID_UnderlaySoftness;

		// Token: 0x04000539 RID: 1337
		private static readonly IntPtr NativeFieldInfoPtr_ID_UnderlayOffset;

		// Token: 0x0400053A RID: 1338
		private static readonly IntPtr NativeFieldInfoPtr_ID_UnderlayIsoPerimeter;

		// Token: 0x0400053B RID: 1339
		private static readonly IntPtr NativeFieldInfoPtr_ID_WeightNormal;

		// Token: 0x0400053C RID: 1340
		private static readonly IntPtr NativeFieldInfoPtr_ID_WeightBold;

		// Token: 0x0400053D RID: 1341
		private static readonly IntPtr NativeFieldInfoPtr_ID_OutlineTex;

		// Token: 0x0400053E RID: 1342
		private static readonly IntPtr NativeFieldInfoPtr_ID_OutlineWidth;

		// Token: 0x0400053F RID: 1343
		private static readonly IntPtr NativeFieldInfoPtr_ID_OutlineSoftness;

		// Token: 0x04000540 RID: 1344
		private static readonly IntPtr NativeFieldInfoPtr_ID_OutlineColor;

		// Token: 0x04000541 RID: 1345
		private static readonly IntPtr NativeFieldInfoPtr_ID_Outline2Color;

		// Token: 0x04000542 RID: 1346
		private static readonly IntPtr NativeFieldInfoPtr_ID_Outline2Width;

		// Token: 0x04000543 RID: 1347
		private static readonly IntPtr NativeFieldInfoPtr_ID_Padding;

		// Token: 0x04000544 RID: 1348
		private static readonly IntPtr NativeFieldInfoPtr_ID_GradientScale;

		// Token: 0x04000545 RID: 1349
		private static readonly IntPtr NativeFieldInfoPtr_ID_ScaleX;

		// Token: 0x04000546 RID: 1350
		private static readonly IntPtr NativeFieldInfoPtr_ID_ScaleY;

		// Token: 0x04000547 RID: 1351
		private static readonly IntPtr NativeFieldInfoPtr_ID_PerspectiveFilter;

		// Token: 0x04000548 RID: 1352
		private static readonly IntPtr NativeFieldInfoPtr_ID_Sharpness;

		// Token: 0x04000549 RID: 1353
		private static readonly IntPtr NativeFieldInfoPtr_ID_TextureWidth;

		// Token: 0x0400054A RID: 1354
		private static readonly IntPtr NativeFieldInfoPtr_ID_TextureHeight;

		// Token: 0x0400054B RID: 1355
		private static readonly IntPtr NativeFieldInfoPtr_ID_BevelAmount;

		// Token: 0x0400054C RID: 1356
		private static readonly IntPtr NativeFieldInfoPtr_ID_GlowColor;

		// Token: 0x0400054D RID: 1357
		private static readonly IntPtr NativeFieldInfoPtr_ID_GlowOffset;

		// Token: 0x0400054E RID: 1358
		private static readonly IntPtr NativeFieldInfoPtr_ID_GlowPower;

		// Token: 0x0400054F RID: 1359
		private static readonly IntPtr NativeFieldInfoPtr_ID_GlowOuter;

		// Token: 0x04000550 RID: 1360
		private static readonly IntPtr NativeFieldInfoPtr_ID_GlowInner;

		// Token: 0x04000551 RID: 1361
		private static readonly IntPtr NativeFieldInfoPtr_ID_LightAngle;

		// Token: 0x04000552 RID: 1362
		private static readonly IntPtr NativeFieldInfoPtr_ID_EnvMap;

		// Token: 0x04000553 RID: 1363
		private static readonly IntPtr NativeFieldInfoPtr_ID_EnvMatrix;

		// Token: 0x04000554 RID: 1364
		private static readonly IntPtr NativeFieldInfoPtr_ID_EnvMatrixRotation;

		// Token: 0x04000555 RID: 1365
		private static readonly IntPtr NativeFieldInfoPtr_ID_MaskCoord;

		// Token: 0x04000556 RID: 1366
		private static readonly IntPtr NativeFieldInfoPtr_ID_ClipRect;

		// Token: 0x04000557 RID: 1367
		private static readonly IntPtr NativeFieldInfoPtr_ID_MaskSoftnessX;

		// Token: 0x04000558 RID: 1368
		private static readonly IntPtr NativeFieldInfoPtr_ID_MaskSoftnessY;

		// Token: 0x04000559 RID: 1369
		private static readonly IntPtr NativeFieldInfoPtr_ID_VertexOffsetX;

		// Token: 0x0400055A RID: 1370
		private static readonly IntPtr NativeFieldInfoPtr_ID_VertexOffsetY;

		// Token: 0x0400055B RID: 1371
		private static readonly IntPtr NativeFieldInfoPtr_ID_UseClipRect;

		// Token: 0x0400055C RID: 1372
		private static readonly IntPtr NativeFieldInfoPtr_ID_StencilID;

		// Token: 0x0400055D RID: 1373
		private static readonly IntPtr NativeFieldInfoPtr_ID_StencilOp;

		// Token: 0x0400055E RID: 1374
		private static readonly IntPtr NativeFieldInfoPtr_ID_StencilComp;

		// Token: 0x0400055F RID: 1375
		private static readonly IntPtr NativeFieldInfoPtr_ID_StencilReadMask;

		// Token: 0x04000560 RID: 1376
		private static readonly IntPtr NativeFieldInfoPtr_ID_StencilWriteMask;

		// Token: 0x04000561 RID: 1377
		private static readonly IntPtr NativeFieldInfoPtr_ID_ShaderFlags;

		// Token: 0x04000562 RID: 1378
		private static readonly IntPtr NativeFieldInfoPtr_ID_ScaleRatio_A;

		// Token: 0x04000563 RID: 1379
		private static readonly IntPtr NativeFieldInfoPtr_ID_ScaleRatio_B;

		// Token: 0x04000564 RID: 1380
		private static readonly IntPtr NativeFieldInfoPtr_ID_ScaleRatio_C;

		// Token: 0x04000565 RID: 1381
		private static readonly IntPtr NativeFieldInfoPtr_Keyword_Bevel;

		// Token: 0x04000566 RID: 1382
		private static readonly IntPtr NativeFieldInfoPtr_Keyword_Glow;

		// Token: 0x04000567 RID: 1383
		private static readonly IntPtr NativeFieldInfoPtr_Keyword_Underlay;

		// Token: 0x04000568 RID: 1384
		private static readonly IntPtr NativeFieldInfoPtr_Keyword_Ratios;

		// Token: 0x04000569 RID: 1385
		private static readonly IntPtr NativeFieldInfoPtr_Keyword_MASK_SOFT;

		// Token: 0x0400056A RID: 1386
		private static readonly IntPtr NativeFieldInfoPtr_Keyword_MASK_HARD;

		// Token: 0x0400056B RID: 1387
		private static readonly IntPtr NativeFieldInfoPtr_Keyword_MASK_TEX;

		// Token: 0x0400056C RID: 1388
		private static readonly IntPtr NativeFieldInfoPtr_Keyword_Outline;

		// Token: 0x0400056D RID: 1389
		private static readonly IntPtr NativeFieldInfoPtr_ShaderTag_ZTestMode;

		// Token: 0x0400056E RID: 1390
		private static readonly IntPtr NativeFieldInfoPtr_ShaderTag_CullMode;

		// Token: 0x0400056F RID: 1391
		private static readonly IntPtr NativeFieldInfoPtr_m_clamp;

		// Token: 0x04000570 RID: 1392
		private static readonly IntPtr NativeFieldInfoPtr_isInitialized;

		// Token: 0x04000571 RID: 1393
		private static readonly IntPtr NativeFieldInfoPtr_k_ShaderRef_MobileSDF;

		// Token: 0x04000572 RID: 1394
		private static readonly IntPtr NativeFieldInfoPtr_k_ShaderRef_MobileBitmap;

		// Token: 0x04000573 RID: 1395
		private static readonly IntPtr NativeMethodInfoPtr_get_ShaderRef_MobileSDF_Internal_Static_get_Shader_0;

		// Token: 0x04000574 RID: 1396
		private static readonly IntPtr NativeMethodInfoPtr_get_ShaderRef_MobileBitmap_Internal_Static_get_Shader_0;

		// Token: 0x04000575 RID: 1397
		private static readonly IntPtr NativeMethodInfoPtr_GetShaderPropertyIDs_Public_Static_Void_0;

		// Token: 0x04000576 RID: 1398
		private static readonly IntPtr NativeMethodInfoPtr_UpdateShaderRatios_Public_Static_Void_Material_0;

		// Token: 0x04000577 RID: 1399
		private static readonly IntPtr NativeMethodInfoPtr_GetFontExtent_Public_Static_Vector4_Material_0;

		// Token: 0x04000578 RID: 1400
		private static readonly IntPtr NativeMethodInfoPtr_IsMaskingEnabled_Public_Static_Boolean_Material_0;

		// Token: 0x04000579 RID: 1401
		private static readonly IntPtr NativeMethodInfoPtr_GetPadding_Public_Static_Single_Material_Boolean_Boolean_0;

		// Token: 0x0400057A RID: 1402
		private static readonly IntPtr NativeMethodInfoPtr_GetPadding_Public_Static_Single_Il2CppReferenceArray_1_Material_Boolean_Boolean_0;
	}
}
