using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

namespace UnityEngine
{
	// Token: 0x0200006D RID: 109
	public sealed class LineRenderer : Renderer
	{
		// Token: 0x060007D3 RID: 2003 RVA: 0x00028418 File Offset: 0x00026618
		// Note: this type is marked as 'beforefieldinit'.
		static LineRenderer()
		{
			Il2CppClassPointerStore<LineRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "LineRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr);
			LineRenderer.NativeMethodInfoPtr_SetColors_Public_Void_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100663842);
			LineRenderer.NativeMethodInfoPtr_set_startColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100663843);
			LineRenderer.NativeMethodInfoPtr_set_endColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100663844);
			LineRenderer.NativeMethodInfoPtr_get_positionCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100663845);
			LineRenderer.NativeMethodInfoPtr_set_positionCount_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100663846);
			LineRenderer.NativeMethodInfoPtr_SetPosition_Public_Void_Int32_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100663847);
			LineRenderer.NativeMethodInfoPtr_set_startColor_Injected_Private_Void_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100663848);
			LineRenderer.NativeMethodInfoPtr_set_endColor_Injected_Private_Void_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100663849);
			LineRenderer.NativeMethodInfoPtr_SetPosition_Injected_Private_Void_Int32_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100663850);
			LineRenderer.get_startWidthDelegateField = IL2CPP.ResolveICall<LineRenderer.get_startWidthDelegate>("UnityEngine.LineRenderer::get_startWidth");
			LineRenderer.set_startWidthDelegateField = IL2CPP.ResolveICall<LineRenderer.set_startWidthDelegate>("UnityEngine.LineRenderer::set_startWidth");
			LineRenderer.get_endWidthDelegateField = IL2CPP.ResolveICall<LineRenderer.get_endWidthDelegate>("UnityEngine.LineRenderer::get_endWidth");
			LineRenderer.set_endWidthDelegateField = IL2CPP.ResolveICall<LineRenderer.set_endWidthDelegate>("UnityEngine.LineRenderer::set_endWidth");
			LineRenderer.get_widthMultiplierDelegateField = IL2CPP.ResolveICall<LineRenderer.get_widthMultiplierDelegate>("UnityEngine.LineRenderer::get_widthMultiplier");
			LineRenderer.set_widthMultiplierDelegateField = IL2CPP.ResolveICall<LineRenderer.set_widthMultiplierDelegate>("UnityEngine.LineRenderer::set_widthMultiplier");
			LineRenderer.get_numCornerVerticesDelegateField = IL2CPP.ResolveICall<LineRenderer.get_numCornerVerticesDelegate>("UnityEngine.LineRenderer::get_numCornerVertices");
			LineRenderer.set_numCornerVerticesDelegateField = IL2CPP.ResolveICall<LineRenderer.set_numCornerVerticesDelegate>("UnityEngine.LineRenderer::set_numCornerVertices");
			LineRenderer.get_numCapVerticesDelegateField = IL2CPP.ResolveICall<LineRenderer.get_numCapVerticesDelegate>("UnityEngine.LineRenderer::get_numCapVertices");
			LineRenderer.set_numCapVerticesDelegateField = IL2CPP.ResolveICall<LineRenderer.set_numCapVerticesDelegate>("UnityEngine.LineRenderer::set_numCapVertices");
			LineRenderer.get_useWorldSpaceDelegateField = IL2CPP.ResolveICall<LineRenderer.get_useWorldSpaceDelegate>("UnityEngine.LineRenderer::get_useWorldSpace");
			LineRenderer.set_useWorldSpaceDelegateField = IL2CPP.ResolveICall<LineRenderer.set_useWorldSpaceDelegate>("UnityEngine.LineRenderer::set_useWorldSpace");
			LineRenderer.get_loopDelegateField = IL2CPP.ResolveICall<LineRenderer.get_loopDelegate>("UnityEngine.LineRenderer::get_loop");
			LineRenderer.set_loopDelegateField = IL2CPP.ResolveICall<LineRenderer.set_loopDelegate>("UnityEngine.LineRenderer::set_loop");
			LineRenderer.get_shadowBiasDelegateField = IL2CPP.ResolveICall<LineRenderer.get_shadowBiasDelegate>("UnityEngine.LineRenderer::get_shadowBias");
			LineRenderer.set_shadowBiasDelegateField = IL2CPP.ResolveICall<LineRenderer.set_shadowBiasDelegate>("UnityEngine.LineRenderer::set_shadowBias");
			LineRenderer.get_generateLightingDataDelegateField = IL2CPP.ResolveICall<LineRenderer.get_generateLightingDataDelegate>("UnityEngine.LineRenderer::get_generateLightingData");
			LineRenderer.set_generateLightingDataDelegateField = IL2CPP.ResolveICall<LineRenderer.set_generateLightingDataDelegate>("UnityEngine.LineRenderer::set_generateLightingData");
			LineRenderer.get_textureModeDelegateField = IL2CPP.ResolveICall<LineRenderer.get_textureModeDelegate>("UnityEngine.LineRenderer::get_textureMode");
			LineRenderer.set_textureModeDelegateField = IL2CPP.ResolveICall<LineRenderer.set_textureModeDelegate>("UnityEngine.LineRenderer::set_textureMode");
			LineRenderer.get_alignmentDelegateField = IL2CPP.ResolveICall<LineRenderer.get_alignmentDelegate>("UnityEngine.LineRenderer::get_alignment");
			LineRenderer.set_alignmentDelegateField = IL2CPP.ResolveICall<LineRenderer.set_alignmentDelegate>("UnityEngine.LineRenderer::set_alignment");
			LineRenderer.SimplifyDelegateField = IL2CPP.ResolveICall<LineRenderer.SimplifyDelegate>("UnityEngine.LineRenderer::Simplify");
			LineRenderer.BakeMeshDelegateField = IL2CPP.ResolveICall<LineRenderer.BakeMeshDelegate>("UnityEngine.LineRenderer::BakeMesh");
			LineRenderer.GetWidthCurveCopyDelegateField = IL2CPP.ResolveICall<LineRenderer.GetWidthCurveCopyDelegate>("UnityEngine.LineRenderer::GetWidthCurveCopy");
			LineRenderer.SetWidthCurveDelegateField = IL2CPP.ResolveICall<LineRenderer.SetWidthCurveDelegate>("UnityEngine.LineRenderer::SetWidthCurve");
			LineRenderer.GetColorGradientCopyDelegateField = IL2CPP.ResolveICall<LineRenderer.GetColorGradientCopyDelegate>("UnityEngine.LineRenderer::GetColorGradientCopy");
			LineRenderer.SetColorGradientDelegateField = IL2CPP.ResolveICall<LineRenderer.SetColorGradientDelegate>("UnityEngine.LineRenderer::SetColorGradient");
			LineRenderer.GetPositionsDelegateField = IL2CPP.ResolveICall<LineRenderer.GetPositionsDelegate>("UnityEngine.LineRenderer::GetPositions");
			LineRenderer.SetPositionsDelegateField = IL2CPP.ResolveICall<LineRenderer.SetPositionsDelegate>("UnityEngine.LineRenderer::SetPositions");
			LineRenderer.SetPositionsWithNativeContainerDelegateField = IL2CPP.ResolveICall<LineRenderer.SetPositionsWithNativeContainerDelegate>("UnityEngine.LineRenderer::SetPositionsWithNativeContainer");
			LineRenderer.GetPositionsWithNativeContainerDelegateField = IL2CPP.ResolveICall<LineRenderer.GetPositionsWithNativeContainerDelegate>("UnityEngine.LineRenderer::GetPositionsWithNativeContainer");
			LineRenderer.get_startColor_InjectedDelegateField = IL2CPP.ResolveICall<LineRenderer.get_startColor_InjectedDelegate>("UnityEngine.LineRenderer::get_startColor_Injected");
			LineRenderer.get_endColor_InjectedDelegateField = IL2CPP.ResolveICall<LineRenderer.get_endColor_InjectedDelegate>("UnityEngine.LineRenderer::get_endColor_Injected");
			LineRenderer.GetPosition_InjectedDelegateField = IL2CPP.ResolveICall<LineRenderer.GetPosition_InjectedDelegate>("UnityEngine.LineRenderer::GetPosition_Injected");
		}

		// Token: 0x060007D4 RID: 2004 RVA: 0x0002870C File Offset: 0x0002690C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488184, XrefRangeEnd = 488188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetColors(Color start, Color end)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_SetColors_Public_Void_Color_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x060007F0 RID: 2032 RVA: 0x00028984 File Offset: 0x00026B84
		// (set) Token: 0x060007D5 RID: 2005 RVA: 0x00028758 File Offset: 0x00026958
		public unsafe Color startColor
		{
			get
			{
				Color color;
				this.get_startColor_Injected(out color);
				return color;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488188, XrefRangeEnd = 488190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_set_startColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x060007F1 RID: 2033 RVA: 0x0002899C File Offset: 0x00026B9C
		// (set) Token: 0x060007D6 RID: 2006 RVA: 0x00028798 File Offset: 0x00026998
		public unsafe Color endColor
		{
			get
			{
				Color color;
				this.get_endColor_Injected(out color);
				return color;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488190, XrefRangeEnd = 488192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_set_endColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x060007D7 RID: 2007 RVA: 0x000287D8 File Offset: 0x000269D8
		// (set) Token: 0x060007D8 RID: 2008 RVA: 0x00028814 File Offset: 0x00026A14
		public unsafe int positionCount
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 488196, RefRangeEnd = 488199, XrefRangeStart = 488192, XrefRangeEnd = 488196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_get_positionCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 488203, RefRangeEnd = 488209, XrefRangeStart = 488199, XrefRangeEnd = 488203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_set_positionCount_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060007D9 RID: 2009 RVA: 0x00028854 File Offset: 0x00026A54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488209, XrefRangeEnd = 488211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPosition(int index, Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_SetPosition_Public_Void_Int32_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007DA RID: 2010 RVA: 0x000288A0 File Offset: 0x00026AA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488211, XrefRangeEnd = 488215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_startColor_Injected(ref Color value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_set_startColor_Injected_Private_Void_byref_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007DB RID: 2011 RVA: 0x000288E0 File Offset: 0x00026AE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488215, XrefRangeEnd = 488219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_endColor_Injected(ref Color value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_set_endColor_Injected_Private_Void_byref_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007DC RID: 2012 RVA: 0x00028920 File Offset: 0x00026B20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488219, XrefRangeEnd = 488223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPosition_Injected(int index, ref Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_SetPosition_Injected_Private_Void_Int32_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007DD RID: 2013 RVA: 0x00006246 File Offset: 0x00004446
		public LineRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060007DE RID: 2014 RVA: 0x0000624F File Offset: 0x0000444F
		public void SetWidth(float start, float end)
		{
			this.startWidth = start;
			this.endWidth = end;
		}

		// Token: 0x060007DF RID: 2015 RVA: 0x00006262 File Offset: 0x00004462
		public void SetVertexCount(int count)
		{
			this.positionCount = count;
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x060007E0 RID: 2016 RVA: 0x0002896C File Offset: 0x00026B6C
		// (set) Token: 0x060007E1 RID: 2017 RVA: 0x0000626D File Offset: 0x0000446D
		public int numPositions
		{
			get
			{
				return this.positionCount;
			}
			set
			{
				this.positionCount = value;
			}
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x060007E2 RID: 2018 RVA: 0x00006278 File Offset: 0x00004478
		// (set) Token: 0x060007E3 RID: 2019 RVA: 0x0000628A File Offset: 0x0000448A
		public float startWidth
		{
			get
			{
				return LineRenderer.get_startWidthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LineRenderer.set_startWidthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x060007E4 RID: 2020 RVA: 0x0000629D File Offset: 0x0000449D
		// (set) Token: 0x060007E5 RID: 2021 RVA: 0x000062AF File Offset: 0x000044AF
		public float endWidth
		{
			get
			{
				return LineRenderer.get_endWidthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LineRenderer.set_endWidthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x060007E6 RID: 2022 RVA: 0x000062C2 File Offset: 0x000044C2
		// (set) Token: 0x060007E7 RID: 2023 RVA: 0x000062D4 File Offset: 0x000044D4
		public float widthMultiplier
		{
			get
			{
				return LineRenderer.get_widthMultiplierDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LineRenderer.set_widthMultiplierDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x060007E8 RID: 2024 RVA: 0x000062E7 File Offset: 0x000044E7
		// (set) Token: 0x060007E9 RID: 2025 RVA: 0x000062F9 File Offset: 0x000044F9
		public int numCornerVertices
		{
			get
			{
				return LineRenderer.get_numCornerVerticesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LineRenderer.set_numCornerVerticesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x060007EA RID: 2026 RVA: 0x0000630C File Offset: 0x0000450C
		// (set) Token: 0x060007EB RID: 2027 RVA: 0x0000631E File Offset: 0x0000451E
		public int numCapVertices
		{
			get
			{
				return LineRenderer.get_numCapVerticesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LineRenderer.set_numCapVerticesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x060007EC RID: 2028 RVA: 0x00006331 File Offset: 0x00004531
		// (set) Token: 0x060007ED RID: 2029 RVA: 0x00006343 File Offset: 0x00004543
		public bool useWorldSpace
		{
			get
			{
				return LineRenderer.get_useWorldSpaceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LineRenderer.set_useWorldSpaceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x060007EE RID: 2030 RVA: 0x00006356 File Offset: 0x00004556
		// (set) Token: 0x060007EF RID: 2031 RVA: 0x00006368 File Offset: 0x00004568
		public bool loop
		{
			get
			{
				return LineRenderer.get_loopDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LineRenderer.set_loopDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x060007F2 RID: 2034 RVA: 0x000289B4 File Offset: 0x00026BB4
		public Vector3 GetPosition(int index)
		{
			Vector3 vector;
			this.GetPosition_Injected(index, out vector);
			return vector;
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x060007F3 RID: 2035 RVA: 0x0000637B File Offset: 0x0000457B
		// (set) Token: 0x060007F4 RID: 2036 RVA: 0x0000638D File Offset: 0x0000458D
		public float shadowBias
		{
			get
			{
				return LineRenderer.get_shadowBiasDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LineRenderer.set_shadowBiasDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x060007F5 RID: 2037 RVA: 0x000063A0 File Offset: 0x000045A0
		// (set) Token: 0x060007F6 RID: 2038 RVA: 0x000063B2 File Offset: 0x000045B2
		public bool generateLightingData
		{
			get
			{
				return LineRenderer.get_generateLightingDataDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LineRenderer.set_generateLightingDataDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x060007F7 RID: 2039 RVA: 0x000063C5 File Offset: 0x000045C5
		// (set) Token: 0x060007F8 RID: 2040 RVA: 0x000063D7 File Offset: 0x000045D7
		public LineTextureMode textureMode
		{
			get
			{
				return LineRenderer.get_textureModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LineRenderer.set_textureModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x060007F9 RID: 2041 RVA: 0x000063EA File Offset: 0x000045EA
		// (set) Token: 0x060007FA RID: 2042 RVA: 0x000063FC File Offset: 0x000045FC
		public LineAlignment alignment
		{
			get
			{
				return LineRenderer.get_alignmentDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LineRenderer.set_alignmentDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x060007FB RID: 2043 RVA: 0x0000640F File Offset: 0x0000460F
		public void Simplify(float tolerance)
		{
			LineRenderer.SimplifyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), tolerance);
		}

		// Token: 0x060007FC RID: 2044 RVA: 0x00006422 File Offset: 0x00004622
		public void BakeMesh(Mesh mesh, [Optional] bool useTransform)
		{
			this.BakeMesh(mesh, Camera.main, useTransform);
		}

		// Token: 0x060007FD RID: 2045 RVA: 0x00006433 File Offset: 0x00004633
		public void BakeMesh(Mesh mesh, Camera camera, [Optional] bool useTransform)
		{
			LineRenderer.BakeMeshDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(mesh), IL2CPP.Il2CppObjectBaseToPtr(camera), useTransform);
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x060007FE RID: 2046 RVA: 0x000289CC File Offset: 0x00026BCC
		// (set) Token: 0x060007FF RID: 2047 RVA: 0x00006452 File Offset: 0x00004652
		public AnimationCurve widthCurve
		{
			get
			{
				return this.GetWidthCurveCopy();
			}
			set
			{
				this.SetWidthCurve(value);
			}
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x06000800 RID: 2048 RVA: 0x000289E4 File Offset: 0x00026BE4
		// (set) Token: 0x06000801 RID: 2049 RVA: 0x0000645D File Offset: 0x0000465D
		public Gradient colorGradient
		{
			get
			{
				return this.GetColorGradientCopy();
			}
			set
			{
				this.SetColorGradient(value);
			}
		}

		// Token: 0x06000802 RID: 2050 RVA: 0x000289FC File Offset: 0x00026BFC
		public AnimationCurve GetWidthCurveCopy()
		{
			IntPtr intPtr = LineRenderer.GetWidthCurveCopyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
		}

		// Token: 0x06000803 RID: 2051 RVA: 0x00006468 File Offset: 0x00004668
		public void SetWidthCurve(AnimationCurve curve)
		{
			LineRenderer.SetWidthCurveDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(curve));
		}

		// Token: 0x06000804 RID: 2052 RVA: 0x00028A28 File Offset: 0x00026C28
		public Gradient GetColorGradientCopy()
		{
			IntPtr intPtr = LineRenderer.GetColorGradientCopyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Gradient>(intPtr2) : null;
		}

		// Token: 0x06000805 RID: 2053 RVA: 0x00006480 File Offset: 0x00004680
		public void SetColorGradient(Gradient curve)
		{
			LineRenderer.SetColorGradientDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(curve));
		}

		// Token: 0x06000806 RID: 2054 RVA: 0x00006498 File Offset: 0x00004698
		public int GetPositions([Out] Il2CppStructArray<Vector3> positions)
		{
			return LineRenderer.GetPositionsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(positions));
		}

		// Token: 0x06000807 RID: 2055 RVA: 0x000064B0 File Offset: 0x000046B0
		public void SetPositions(Il2CppStructArray<Vector3> positions)
		{
			LineRenderer.SetPositionsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(positions));
		}

		// Token: 0x06000808 RID: 2056 RVA: 0x000064C8 File Offset: 0x000046C8
		public void SetPositions(Unity.Collections.NativeArray<Vector3> positions)
		{
			this.SetPositionsWithNativeContainer((IntPtr)positions.GetUnsafeReadOnlyPtr<Vector3>(), positions.Length);
		}

		// Token: 0x06000809 RID: 2057 RVA: 0x000064E6 File Offset: 0x000046E6
		public void SetPositions(Unity.Collections.NativeSlice<Vector3> positions)
		{
			this.SetPositionsWithNativeContainer((IntPtr)Unity.Collections.LowLevel.Unsafe.NativeSliceUnsafeUtility.GetUnsafeReadOnlyPtr<Vector3>(positions), positions.Length);
		}

		// Token: 0x0600080A RID: 2058 RVA: 0x00028A54 File Offset: 0x00026C54
		public int GetPositions([Out] Unity.Collections.NativeArray<Vector3> positions)
		{
			return this.GetPositionsWithNativeContainer((IntPtr)Unity.Collections.LowLevel.Unsafe.NativeArrayUnsafeUtility.GetUnsafePtr<Vector3>(positions), positions.Length);
		}

		// Token: 0x0600080B RID: 2059 RVA: 0x00028A80 File Offset: 0x00026C80
		public int GetPositions([Out] Unity.Collections.NativeSlice<Vector3> positions)
		{
			return this.GetPositionsWithNativeContainer((IntPtr)Unity.Collections.LowLevel.Unsafe.NativeSliceUnsafeUtility.GetUnsafePtr<Vector3>(positions), positions.Length);
		}

		// Token: 0x0600080C RID: 2060 RVA: 0x00006504 File Offset: 0x00004704
		public void SetPositionsWithNativeContainer(IntPtr positions, int count)
		{
			LineRenderer.SetPositionsWithNativeContainerDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), positions, count);
		}

		// Token: 0x0600080D RID: 2061 RVA: 0x00006518 File Offset: 0x00004718
		public int GetPositionsWithNativeContainer(IntPtr positions, int length)
		{
			return LineRenderer.GetPositionsWithNativeContainerDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), positions, length);
		}

		// Token: 0x0600080E RID: 2062 RVA: 0x0000652C File Offset: 0x0000472C
		public void get_startColor_Injected(out Color ret)
		{
			LineRenderer.get_startColor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0600080F RID: 2063 RVA: 0x0000653F File Offset: 0x0000473F
		public void get_endColor_Injected(out Color ret)
		{
			LineRenderer.get_endColor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000810 RID: 2064 RVA: 0x00006552 File Offset: 0x00004752
		public void GetPosition_Injected(int index, out Vector3 ret)
		{
			LineRenderer.GetPosition_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index, out ret);
		}

		// Token: 0x04000570 RID: 1392
		private static readonly IntPtr NativeMethodInfoPtr_SetColors_Public_Void_Color_Color_0;

		// Token: 0x04000571 RID: 1393
		private static readonly IntPtr NativeMethodInfoPtr_set_startColor_Public_set_Void_Color_0;

		// Token: 0x04000572 RID: 1394
		private static readonly IntPtr NativeMethodInfoPtr_set_endColor_Public_set_Void_Color_0;

		// Token: 0x04000573 RID: 1395
		private static readonly IntPtr NativeMethodInfoPtr_get_positionCount_Public_get_Int32_0;

		// Token: 0x04000574 RID: 1396
		private static readonly IntPtr NativeMethodInfoPtr_set_positionCount_Public_set_Void_Int32_0;

		// Token: 0x04000575 RID: 1397
		private static readonly IntPtr NativeMethodInfoPtr_SetPosition_Public_Void_Int32_Vector3_0;

		// Token: 0x04000576 RID: 1398
		private static readonly IntPtr NativeMethodInfoPtr_set_startColor_Injected_Private_Void_byref_Color_0;

		// Token: 0x04000577 RID: 1399
		private static readonly IntPtr NativeMethodInfoPtr_set_endColor_Injected_Private_Void_byref_Color_0;

		// Token: 0x04000578 RID: 1400
		private static readonly IntPtr NativeMethodInfoPtr_SetPosition_Injected_Private_Void_Int32_byref_Vector3_0;

		// Token: 0x04000579 RID: 1401
		private static readonly LineRenderer.get_startWidthDelegate get_startWidthDelegateField;

		// Token: 0x0400057A RID: 1402
		private static readonly LineRenderer.set_startWidthDelegate set_startWidthDelegateField;

		// Token: 0x0400057B RID: 1403
		private static readonly LineRenderer.get_endWidthDelegate get_endWidthDelegateField;

		// Token: 0x0400057C RID: 1404
		private static readonly LineRenderer.set_endWidthDelegate set_endWidthDelegateField;

		// Token: 0x0400057D RID: 1405
		private static readonly LineRenderer.get_widthMultiplierDelegate get_widthMultiplierDelegateField;

		// Token: 0x0400057E RID: 1406
		private static readonly LineRenderer.set_widthMultiplierDelegate set_widthMultiplierDelegateField;

		// Token: 0x0400057F RID: 1407
		private static readonly LineRenderer.get_numCornerVerticesDelegate get_numCornerVerticesDelegateField;

		// Token: 0x04000580 RID: 1408
		private static readonly LineRenderer.set_numCornerVerticesDelegate set_numCornerVerticesDelegateField;

		// Token: 0x04000581 RID: 1409
		private static readonly LineRenderer.get_numCapVerticesDelegate get_numCapVerticesDelegateField;

		// Token: 0x04000582 RID: 1410
		private static readonly LineRenderer.set_numCapVerticesDelegate set_numCapVerticesDelegateField;

		// Token: 0x04000583 RID: 1411
		private static readonly LineRenderer.get_useWorldSpaceDelegate get_useWorldSpaceDelegateField;

		// Token: 0x04000584 RID: 1412
		private static readonly LineRenderer.set_useWorldSpaceDelegate set_useWorldSpaceDelegateField;

		// Token: 0x04000585 RID: 1413
		private static readonly LineRenderer.get_loopDelegate get_loopDelegateField;

		// Token: 0x04000586 RID: 1414
		private static readonly LineRenderer.set_loopDelegate set_loopDelegateField;

		// Token: 0x04000587 RID: 1415
		private static readonly LineRenderer.get_shadowBiasDelegate get_shadowBiasDelegateField;

		// Token: 0x04000588 RID: 1416
		private static readonly LineRenderer.set_shadowBiasDelegate set_shadowBiasDelegateField;

		// Token: 0x04000589 RID: 1417
		private static readonly LineRenderer.get_generateLightingDataDelegate get_generateLightingDataDelegateField;

		// Token: 0x0400058A RID: 1418
		private static readonly LineRenderer.set_generateLightingDataDelegate set_generateLightingDataDelegateField;

		// Token: 0x0400058B RID: 1419
		private static readonly LineRenderer.get_textureModeDelegate get_textureModeDelegateField;

		// Token: 0x0400058C RID: 1420
		private static readonly LineRenderer.set_textureModeDelegate set_textureModeDelegateField;

		// Token: 0x0400058D RID: 1421
		private static readonly LineRenderer.get_alignmentDelegate get_alignmentDelegateField;

		// Token: 0x0400058E RID: 1422
		private static readonly LineRenderer.set_alignmentDelegate set_alignmentDelegateField;

		// Token: 0x0400058F RID: 1423
		private static readonly LineRenderer.SimplifyDelegate SimplifyDelegateField;

		// Token: 0x04000590 RID: 1424
		private static readonly LineRenderer.BakeMeshDelegate BakeMeshDelegateField;

		// Token: 0x04000591 RID: 1425
		private static readonly LineRenderer.GetWidthCurveCopyDelegate GetWidthCurveCopyDelegateField;

		// Token: 0x04000592 RID: 1426
		private static readonly LineRenderer.SetWidthCurveDelegate SetWidthCurveDelegateField;

		// Token: 0x04000593 RID: 1427
		private static readonly LineRenderer.GetColorGradientCopyDelegate GetColorGradientCopyDelegateField;

		// Token: 0x04000594 RID: 1428
		private static readonly LineRenderer.SetColorGradientDelegate SetColorGradientDelegateField;

		// Token: 0x04000595 RID: 1429
		private static readonly LineRenderer.GetPositionsDelegate GetPositionsDelegateField;

		// Token: 0x04000596 RID: 1430
		private static readonly LineRenderer.SetPositionsDelegate SetPositionsDelegateField;

		// Token: 0x04000597 RID: 1431
		private static readonly LineRenderer.SetPositionsWithNativeContainerDelegate SetPositionsWithNativeContainerDelegateField;

		// Token: 0x04000598 RID: 1432
		private static readonly LineRenderer.GetPositionsWithNativeContainerDelegate GetPositionsWithNativeContainerDelegateField;

		// Token: 0x04000599 RID: 1433
		private static readonly LineRenderer.get_startColor_InjectedDelegate get_startColor_InjectedDelegateField;

		// Token: 0x0400059A RID: 1434
		private static readonly LineRenderer.get_endColor_InjectedDelegate get_endColor_InjectedDelegateField;

		// Token: 0x0400059B RID: 1435
		private static readonly LineRenderer.GetPosition_InjectedDelegate GetPosition_InjectedDelegateField;

		// Token: 0x0200050F RID: 1295
		// (Invoke) Token: 0x06002854 RID: 10324
		private delegate float get_startWidthDelegate(IntPtr @this);

		// Token: 0x02000510 RID: 1296
		// (Invoke) Token: 0x06002856 RID: 10326
		private delegate void set_startWidthDelegate(IntPtr @this, float value);

		// Token: 0x02000511 RID: 1297
		// (Invoke) Token: 0x06002858 RID: 10328
		private delegate float get_endWidthDelegate(IntPtr @this);

		// Token: 0x02000512 RID: 1298
		// (Invoke) Token: 0x0600285A RID: 10330
		private delegate void set_endWidthDelegate(IntPtr @this, float value);

		// Token: 0x02000513 RID: 1299
		// (Invoke) Token: 0x0600285C RID: 10332
		private delegate float get_widthMultiplierDelegate(IntPtr @this);

		// Token: 0x02000514 RID: 1300
		// (Invoke) Token: 0x0600285E RID: 10334
		private delegate void set_widthMultiplierDelegate(IntPtr @this, float value);

		// Token: 0x02000515 RID: 1301
		// (Invoke) Token: 0x06002860 RID: 10336
		private delegate int get_numCornerVerticesDelegate(IntPtr @this);

		// Token: 0x02000516 RID: 1302
		// (Invoke) Token: 0x06002862 RID: 10338
		private delegate void set_numCornerVerticesDelegate(IntPtr @this, int value);

		// Token: 0x02000517 RID: 1303
		// (Invoke) Token: 0x06002864 RID: 10340
		private delegate int get_numCapVerticesDelegate(IntPtr @this);

		// Token: 0x02000518 RID: 1304
		// (Invoke) Token: 0x06002866 RID: 10342
		private delegate void set_numCapVerticesDelegate(IntPtr @this, int value);

		// Token: 0x02000519 RID: 1305
		// (Invoke) Token: 0x06002868 RID: 10344
		private delegate bool get_useWorldSpaceDelegate(IntPtr @this);

		// Token: 0x0200051A RID: 1306
		// (Invoke) Token: 0x0600286A RID: 10346
		private delegate void set_useWorldSpaceDelegate(IntPtr @this, bool value);

		// Token: 0x0200051B RID: 1307
		// (Invoke) Token: 0x0600286C RID: 10348
		private delegate bool get_loopDelegate(IntPtr @this);

		// Token: 0x0200051C RID: 1308
		// (Invoke) Token: 0x0600286E RID: 10350
		private delegate void set_loopDelegate(IntPtr @this, bool value);

		// Token: 0x0200051D RID: 1309
		// (Invoke) Token: 0x06002870 RID: 10352
		private delegate float get_shadowBiasDelegate(IntPtr @this);

		// Token: 0x0200051E RID: 1310
		// (Invoke) Token: 0x06002872 RID: 10354
		private delegate void set_shadowBiasDelegate(IntPtr @this, float value);

		// Token: 0x0200051F RID: 1311
		// (Invoke) Token: 0x06002874 RID: 10356
		private delegate bool get_generateLightingDataDelegate(IntPtr @this);

		// Token: 0x02000520 RID: 1312
		// (Invoke) Token: 0x06002876 RID: 10358
		private delegate void set_generateLightingDataDelegate(IntPtr @this, bool value);

		// Token: 0x02000521 RID: 1313
		// (Invoke) Token: 0x06002878 RID: 10360
		private delegate LineTextureMode get_textureModeDelegate(IntPtr @this);

		// Token: 0x02000522 RID: 1314
		// (Invoke) Token: 0x0600287A RID: 10362
		private delegate void set_textureModeDelegate(IntPtr @this, LineTextureMode value);

		// Token: 0x02000523 RID: 1315
		// (Invoke) Token: 0x0600287C RID: 10364
		private delegate LineAlignment get_alignmentDelegate(IntPtr @this);

		// Token: 0x02000524 RID: 1316
		// (Invoke) Token: 0x0600287E RID: 10366
		private delegate void set_alignmentDelegate(IntPtr @this, LineAlignment value);

		// Token: 0x02000525 RID: 1317
		// (Invoke) Token: 0x06002880 RID: 10368
		private delegate void SimplifyDelegate(IntPtr @this, float tolerance);

		// Token: 0x02000526 RID: 1318
		// (Invoke) Token: 0x06002882 RID: 10370
		private delegate void BakeMeshDelegate(IntPtr @this, IntPtr mesh, IntPtr camera, bool useTransform);

		// Token: 0x02000527 RID: 1319
		// (Invoke) Token: 0x06002884 RID: 10372
		private delegate IntPtr GetWidthCurveCopyDelegate(IntPtr @this);

		// Token: 0x02000528 RID: 1320
		// (Invoke) Token: 0x06002886 RID: 10374
		private delegate void SetWidthCurveDelegate(IntPtr @this, IntPtr curve);

		// Token: 0x02000529 RID: 1321
		// (Invoke) Token: 0x06002888 RID: 10376
		private delegate IntPtr GetColorGradientCopyDelegate(IntPtr @this);

		// Token: 0x0200052A RID: 1322
		// (Invoke) Token: 0x0600288A RID: 10378
		private delegate void SetColorGradientDelegate(IntPtr @this, IntPtr curve);

		// Token: 0x0200052B RID: 1323
		// (Invoke) Token: 0x0600288C RID: 10380
		private delegate int GetPositionsDelegate(IntPtr @this, [Out] IntPtr positions);

		// Token: 0x0200052C RID: 1324
		// (Invoke) Token: 0x0600288E RID: 10382
		private delegate void SetPositionsDelegate(IntPtr @this, IntPtr positions);

		// Token: 0x0200052D RID: 1325
		// (Invoke) Token: 0x06002890 RID: 10384
		private delegate void SetPositionsWithNativeContainerDelegate(IntPtr @this, IntPtr positions, int count);

		// Token: 0x0200052E RID: 1326
		// (Invoke) Token: 0x06002892 RID: 10386
		private delegate int GetPositionsWithNativeContainerDelegate(IntPtr @this, IntPtr positions, int length);

		// Token: 0x0200052F RID: 1327
		// (Invoke) Token: 0x06002894 RID: 10388
		private delegate void get_startColor_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000530 RID: 1328
		// (Invoke) Token: 0x06002896 RID: 10390
		private delegate void get_endColor_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000531 RID: 1329
		// (Invoke) Token: 0x06002898 RID: 10392
		private delegate void GetPosition_InjectedDelegate(IntPtr @this, int index, [Out] IntPtr ret);
	}
}
