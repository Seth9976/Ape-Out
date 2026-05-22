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
	// Token: 0x0200006C RID: 108
	public sealed class TrailRenderer : Renderer
	{
		// Token: 0x06000790 RID: 1936 RVA: 0x00027E64 File Offset: 0x00026064
		// Note: this type is marked as 'beforefieldinit'.
		static TrailRenderer()
		{
			Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "TrailRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr);
			TrailRenderer.NativeMethodInfoPtr_get_time_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100663836);
			TrailRenderer.NativeMethodInfoPtr_set_time_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100663837);
			TrailRenderer.NativeMethodInfoPtr_get_startWidth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100663838);
			TrailRenderer.NativeMethodInfoPtr_set_startWidth_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100663839);
			TrailRenderer.NativeMethodInfoPtr_get_endWidth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100663840);
			TrailRenderer.NativeMethodInfoPtr_set_endWidth_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100663841);
			TrailRenderer.get_widthMultiplierDelegateField = IL2CPP.ResolveICall<TrailRenderer.get_widthMultiplierDelegate>("UnityEngine.TrailRenderer::get_widthMultiplier");
			TrailRenderer.set_widthMultiplierDelegateField = IL2CPP.ResolveICall<TrailRenderer.set_widthMultiplierDelegate>("UnityEngine.TrailRenderer::set_widthMultiplier");
			TrailRenderer.get_autodestructDelegateField = IL2CPP.ResolveICall<TrailRenderer.get_autodestructDelegate>("UnityEngine.TrailRenderer::get_autodestruct");
			TrailRenderer.set_autodestructDelegateField = IL2CPP.ResolveICall<TrailRenderer.set_autodestructDelegate>("UnityEngine.TrailRenderer::set_autodestruct");
			TrailRenderer.get_emittingDelegateField = IL2CPP.ResolveICall<TrailRenderer.get_emittingDelegate>("UnityEngine.TrailRenderer::get_emitting");
			TrailRenderer.set_emittingDelegateField = IL2CPP.ResolveICall<TrailRenderer.set_emittingDelegate>("UnityEngine.TrailRenderer::set_emitting");
			TrailRenderer.get_numCornerVerticesDelegateField = IL2CPP.ResolveICall<TrailRenderer.get_numCornerVerticesDelegate>("UnityEngine.TrailRenderer::get_numCornerVertices");
			TrailRenderer.set_numCornerVerticesDelegateField = IL2CPP.ResolveICall<TrailRenderer.set_numCornerVerticesDelegate>("UnityEngine.TrailRenderer::set_numCornerVertices");
			TrailRenderer.get_numCapVerticesDelegateField = IL2CPP.ResolveICall<TrailRenderer.get_numCapVerticesDelegate>("UnityEngine.TrailRenderer::get_numCapVertices");
			TrailRenderer.set_numCapVerticesDelegateField = IL2CPP.ResolveICall<TrailRenderer.set_numCapVerticesDelegate>("UnityEngine.TrailRenderer::set_numCapVertices");
			TrailRenderer.get_minVertexDistanceDelegateField = IL2CPP.ResolveICall<TrailRenderer.get_minVertexDistanceDelegate>("UnityEngine.TrailRenderer::get_minVertexDistance");
			TrailRenderer.set_minVertexDistanceDelegateField = IL2CPP.ResolveICall<TrailRenderer.set_minVertexDistanceDelegate>("UnityEngine.TrailRenderer::set_minVertexDistance");
			TrailRenderer.get_positionCountDelegateField = IL2CPP.ResolveICall<TrailRenderer.get_positionCountDelegate>("UnityEngine.TrailRenderer::get_positionCount");
			TrailRenderer.get_shadowBiasDelegateField = IL2CPP.ResolveICall<TrailRenderer.get_shadowBiasDelegate>("UnityEngine.TrailRenderer::get_shadowBias");
			TrailRenderer.set_shadowBiasDelegateField = IL2CPP.ResolveICall<TrailRenderer.set_shadowBiasDelegate>("UnityEngine.TrailRenderer::set_shadowBias");
			TrailRenderer.get_generateLightingDataDelegateField = IL2CPP.ResolveICall<TrailRenderer.get_generateLightingDataDelegate>("UnityEngine.TrailRenderer::get_generateLightingData");
			TrailRenderer.set_generateLightingDataDelegateField = IL2CPP.ResolveICall<TrailRenderer.set_generateLightingDataDelegate>("UnityEngine.TrailRenderer::set_generateLightingData");
			TrailRenderer.get_textureModeDelegateField = IL2CPP.ResolveICall<TrailRenderer.get_textureModeDelegate>("UnityEngine.TrailRenderer::get_textureMode");
			TrailRenderer.set_textureModeDelegateField = IL2CPP.ResolveICall<TrailRenderer.set_textureModeDelegate>("UnityEngine.TrailRenderer::set_textureMode");
			TrailRenderer.get_alignmentDelegateField = IL2CPP.ResolveICall<TrailRenderer.get_alignmentDelegate>("UnityEngine.TrailRenderer::get_alignment");
			TrailRenderer.set_alignmentDelegateField = IL2CPP.ResolveICall<TrailRenderer.set_alignmentDelegate>("UnityEngine.TrailRenderer::set_alignment");
			TrailRenderer.ClearDelegateField = IL2CPP.ResolveICall<TrailRenderer.ClearDelegate>("UnityEngine.TrailRenderer::Clear");
			TrailRenderer.BakeMeshDelegateField = IL2CPP.ResolveICall<TrailRenderer.BakeMeshDelegate>("UnityEngine.TrailRenderer::BakeMesh");
			TrailRenderer.GetWidthCurveCopyDelegateField = IL2CPP.ResolveICall<TrailRenderer.GetWidthCurveCopyDelegate>("UnityEngine.TrailRenderer::GetWidthCurveCopy");
			TrailRenderer.SetWidthCurveDelegateField = IL2CPP.ResolveICall<TrailRenderer.SetWidthCurveDelegate>("UnityEngine.TrailRenderer::SetWidthCurve");
			TrailRenderer.GetColorGradientCopyDelegateField = IL2CPP.ResolveICall<TrailRenderer.GetColorGradientCopyDelegate>("UnityEngine.TrailRenderer::GetColorGradientCopy");
			TrailRenderer.SetColorGradientDelegateField = IL2CPP.ResolveICall<TrailRenderer.SetColorGradientDelegate>("UnityEngine.TrailRenderer::SetColorGradient");
			TrailRenderer.GetPositionsDelegateField = IL2CPP.ResolveICall<TrailRenderer.GetPositionsDelegate>("UnityEngine.TrailRenderer::GetPositions");
			TrailRenderer.SetPositionsDelegateField = IL2CPP.ResolveICall<TrailRenderer.SetPositionsDelegate>("UnityEngine.TrailRenderer::SetPositions");
			TrailRenderer.AddPositionsDelegateField = IL2CPP.ResolveICall<TrailRenderer.AddPositionsDelegate>("UnityEngine.TrailRenderer::AddPositions");
			TrailRenderer.SetPositionsWithNativeContainerDelegateField = IL2CPP.ResolveICall<TrailRenderer.SetPositionsWithNativeContainerDelegate>("UnityEngine.TrailRenderer::SetPositionsWithNativeContainer");
			TrailRenderer.GetPositionsWithNativeContainerDelegateField = IL2CPP.ResolveICall<TrailRenderer.GetPositionsWithNativeContainerDelegate>("UnityEngine.TrailRenderer::GetPositionsWithNativeContainer");
			TrailRenderer.AddPositionsWithNativeContainerDelegateField = IL2CPP.ResolveICall<TrailRenderer.AddPositionsWithNativeContainerDelegate>("UnityEngine.TrailRenderer::AddPositionsWithNativeContainer");
			TrailRenderer.get_startColor_InjectedDelegateField = IL2CPP.ResolveICall<TrailRenderer.get_startColor_InjectedDelegate>("UnityEngine.TrailRenderer::get_startColor_Injected");
			TrailRenderer.set_startColor_InjectedDelegateField = IL2CPP.ResolveICall<TrailRenderer.set_startColor_InjectedDelegate>("UnityEngine.TrailRenderer::set_startColor_Injected");
			TrailRenderer.get_endColor_InjectedDelegateField = IL2CPP.ResolveICall<TrailRenderer.get_endColor_InjectedDelegate>("UnityEngine.TrailRenderer::get_endColor_Injected");
			TrailRenderer.set_endColor_InjectedDelegateField = IL2CPP.ResolveICall<TrailRenderer.set_endColor_InjectedDelegate>("UnityEngine.TrailRenderer::set_endColor_Injected");
			TrailRenderer.SetPosition_InjectedDelegateField = IL2CPP.ResolveICall<TrailRenderer.SetPosition_InjectedDelegate>("UnityEngine.TrailRenderer::SetPosition_Injected");
			TrailRenderer.GetPosition_InjectedDelegateField = IL2CPP.ResolveICall<TrailRenderer.GetPosition_InjectedDelegate>("UnityEngine.TrailRenderer::GetPosition_Injected");
			TrailRenderer.AddPosition_InjectedDelegateField = IL2CPP.ResolveICall<TrailRenderer.AddPosition_InjectedDelegate>("UnityEngine.TrailRenderer::AddPosition_Injected");
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x06000791 RID: 1937 RVA: 0x00028164 File Offset: 0x00026364
		// (set) Token: 0x06000792 RID: 1938 RVA: 0x000281A0 File Offset: 0x000263A0
		public unsafe float time
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488160, XrefRangeEnd = 488164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_get_time_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488164, XrefRangeEnd = 488168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_set_time_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x06000793 RID: 1939 RVA: 0x000281E0 File Offset: 0x000263E0
		// (set) Token: 0x06000794 RID: 1940 RVA: 0x0002821C File Offset: 0x0002641C
		public unsafe float startWidth
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488168, XrefRangeEnd = 488172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_get_startWidth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488172, XrefRangeEnd = 488176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_set_startWidth_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x06000795 RID: 1941 RVA: 0x0002825C File Offset: 0x0002645C
		// (set) Token: 0x06000796 RID: 1942 RVA: 0x00028298 File Offset: 0x00026498
		public unsafe float endWidth
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488176, XrefRangeEnd = 488180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_get_endWidth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488180, XrefRangeEnd = 488184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_set_endWidth_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000797 RID: 1943 RVA: 0x00005E85 File Offset: 0x00004085
		public TrailRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x06000798 RID: 1944 RVA: 0x000282D8 File Offset: 0x000264D8
		public int numPositions
		{
			get
			{
				return this.positionCount;
			}
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x06000799 RID: 1945 RVA: 0x00005E8E File Offset: 0x0000408E
		// (set) Token: 0x0600079A RID: 1946 RVA: 0x00005EA0 File Offset: 0x000040A0
		public float widthMultiplier
		{
			get
			{
				return TrailRenderer.get_widthMultiplierDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TrailRenderer.set_widthMultiplierDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x0600079B RID: 1947 RVA: 0x00005EB3 File Offset: 0x000040B3
		// (set) Token: 0x0600079C RID: 1948 RVA: 0x00005EC5 File Offset: 0x000040C5
		public bool autodestruct
		{
			get
			{
				return TrailRenderer.get_autodestructDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TrailRenderer.set_autodestructDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x0600079D RID: 1949 RVA: 0x00005ED8 File Offset: 0x000040D8
		// (set) Token: 0x0600079E RID: 1950 RVA: 0x00005EEA File Offset: 0x000040EA
		public bool emitting
		{
			get
			{
				return TrailRenderer.get_emittingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TrailRenderer.set_emittingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x0600079F RID: 1951 RVA: 0x00005EFD File Offset: 0x000040FD
		// (set) Token: 0x060007A0 RID: 1952 RVA: 0x00005F0F File Offset: 0x0000410F
		public int numCornerVertices
		{
			get
			{
				return TrailRenderer.get_numCornerVerticesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TrailRenderer.set_numCornerVerticesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x060007A1 RID: 1953 RVA: 0x00005F22 File Offset: 0x00004122
		// (set) Token: 0x060007A2 RID: 1954 RVA: 0x00005F34 File Offset: 0x00004134
		public int numCapVertices
		{
			get
			{
				return TrailRenderer.get_numCapVerticesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TrailRenderer.set_numCapVerticesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x060007A3 RID: 1955 RVA: 0x00005F47 File Offset: 0x00004147
		// (set) Token: 0x060007A4 RID: 1956 RVA: 0x00005F59 File Offset: 0x00004159
		public float minVertexDistance
		{
			get
			{
				return TrailRenderer.get_minVertexDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TrailRenderer.set_minVertexDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x060007A5 RID: 1957 RVA: 0x000282F0 File Offset: 0x000264F0
		// (set) Token: 0x060007A6 RID: 1958 RVA: 0x00005F6C File Offset: 0x0000416C
		public Color startColor
		{
			get
			{
				Color color;
				this.get_startColor_Injected(out color);
				return color;
			}
			set
			{
				this.set_startColor_Injected(ref value);
			}
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x060007A7 RID: 1959 RVA: 0x00028308 File Offset: 0x00026508
		// (set) Token: 0x060007A8 RID: 1960 RVA: 0x00005F76 File Offset: 0x00004176
		public Color endColor
		{
			get
			{
				Color color;
				this.get_endColor_Injected(out color);
				return color;
			}
			set
			{
				this.set_endColor_Injected(ref value);
			}
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x060007A9 RID: 1961 RVA: 0x00005F80 File Offset: 0x00004180
		public int positionCount
		{
			get
			{
				return TrailRenderer.get_positionCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x060007AA RID: 1962 RVA: 0x00005F92 File Offset: 0x00004192
		public void SetPosition(int index, Vector3 position)
		{
			this.SetPosition_Injected(index, ref position);
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x00028320 File Offset: 0x00026520
		public Vector3 GetPosition(int index)
		{
			Vector3 vector;
			this.GetPosition_Injected(index, out vector);
			return vector;
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x060007AC RID: 1964 RVA: 0x00005F9D File Offset: 0x0000419D
		// (set) Token: 0x060007AD RID: 1965 RVA: 0x00005FAF File Offset: 0x000041AF
		public float shadowBias
		{
			get
			{
				return TrailRenderer.get_shadowBiasDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TrailRenderer.set_shadowBiasDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x060007AE RID: 1966 RVA: 0x00005FC2 File Offset: 0x000041C2
		// (set) Token: 0x060007AF RID: 1967 RVA: 0x00005FD4 File Offset: 0x000041D4
		public bool generateLightingData
		{
			get
			{
				return TrailRenderer.get_generateLightingDataDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TrailRenderer.set_generateLightingDataDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x060007B0 RID: 1968 RVA: 0x00005FE7 File Offset: 0x000041E7
		// (set) Token: 0x060007B1 RID: 1969 RVA: 0x00005FF9 File Offset: 0x000041F9
		public LineTextureMode textureMode
		{
			get
			{
				return TrailRenderer.get_textureModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TrailRenderer.set_textureModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x060007B2 RID: 1970 RVA: 0x0000600C File Offset: 0x0000420C
		// (set) Token: 0x060007B3 RID: 1971 RVA: 0x0000601E File Offset: 0x0000421E
		public LineAlignment alignment
		{
			get
			{
				return TrailRenderer.get_alignmentDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TrailRenderer.set_alignmentDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x060007B4 RID: 1972 RVA: 0x00006031 File Offset: 0x00004231
		public void Clear()
		{
			TrailRenderer.ClearDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060007B5 RID: 1973 RVA: 0x00006043 File Offset: 0x00004243
		public void BakeMesh(Mesh mesh, [Optional] bool useTransform)
		{
			this.BakeMesh(mesh, Camera.main, useTransform);
		}

		// Token: 0x060007B6 RID: 1974 RVA: 0x00006054 File Offset: 0x00004254
		public void BakeMesh(Mesh mesh, Camera camera, [Optional] bool useTransform)
		{
			TrailRenderer.BakeMeshDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(mesh), IL2CPP.Il2CppObjectBaseToPtr(camera), useTransform);
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x060007B7 RID: 1975 RVA: 0x00028338 File Offset: 0x00026538
		// (set) Token: 0x060007B8 RID: 1976 RVA: 0x00006073 File Offset: 0x00004273
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

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x060007B9 RID: 1977 RVA: 0x00028350 File Offset: 0x00026550
		// (set) Token: 0x060007BA RID: 1978 RVA: 0x0000607E File Offset: 0x0000427E
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

		// Token: 0x060007BB RID: 1979 RVA: 0x00028368 File Offset: 0x00026568
		public AnimationCurve GetWidthCurveCopy()
		{
			IntPtr intPtr = TrailRenderer.GetWidthCurveCopyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
		}

		// Token: 0x060007BC RID: 1980 RVA: 0x00006089 File Offset: 0x00004289
		public void SetWidthCurve(AnimationCurve curve)
		{
			TrailRenderer.SetWidthCurveDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(curve));
		}

		// Token: 0x060007BD RID: 1981 RVA: 0x00028394 File Offset: 0x00026594
		public Gradient GetColorGradientCopy()
		{
			IntPtr intPtr = TrailRenderer.GetColorGradientCopyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Gradient>(intPtr2) : null;
		}

		// Token: 0x060007BE RID: 1982 RVA: 0x000060A1 File Offset: 0x000042A1
		public void SetColorGradient(Gradient curve)
		{
			TrailRenderer.SetColorGradientDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(curve));
		}

		// Token: 0x060007BF RID: 1983 RVA: 0x000060B9 File Offset: 0x000042B9
		public int GetPositions([Out] Il2CppStructArray<Vector3> positions)
		{
			return TrailRenderer.GetPositionsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(positions));
		}

		// Token: 0x060007C0 RID: 1984 RVA: 0x000060D1 File Offset: 0x000042D1
		public void SetPositions(Il2CppStructArray<Vector3> positions)
		{
			TrailRenderer.SetPositionsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(positions));
		}

		// Token: 0x060007C1 RID: 1985 RVA: 0x000060E9 File Offset: 0x000042E9
		public void AddPosition(Vector3 position)
		{
			this.AddPosition_Injected(ref position);
		}

		// Token: 0x060007C2 RID: 1986 RVA: 0x000060F3 File Offset: 0x000042F3
		public void AddPositions(Il2CppStructArray<Vector3> positions)
		{
			TrailRenderer.AddPositionsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(positions));
		}

		// Token: 0x060007C3 RID: 1987 RVA: 0x0000610B File Offset: 0x0000430B
		public void SetPositions(Unity.Collections.NativeArray<Vector3> positions)
		{
			this.SetPositionsWithNativeContainer((IntPtr)positions.GetUnsafeReadOnlyPtr<Vector3>(), positions.Length);
		}

		// Token: 0x060007C4 RID: 1988 RVA: 0x00006129 File Offset: 0x00004329
		public void SetPositions(Unity.Collections.NativeSlice<Vector3> positions)
		{
			this.SetPositionsWithNativeContainer((IntPtr)Unity.Collections.LowLevel.Unsafe.NativeSliceUnsafeUtility.GetUnsafeReadOnlyPtr<Vector3>(positions), positions.Length);
		}

		// Token: 0x060007C5 RID: 1989 RVA: 0x000283C0 File Offset: 0x000265C0
		public int GetPositions([Out] Unity.Collections.NativeArray<Vector3> positions)
		{
			return this.GetPositionsWithNativeContainer((IntPtr)Unity.Collections.LowLevel.Unsafe.NativeArrayUnsafeUtility.GetUnsafePtr<Vector3>(positions), positions.Length);
		}

		// Token: 0x060007C6 RID: 1990 RVA: 0x000283EC File Offset: 0x000265EC
		public int GetPositions([Out] Unity.Collections.NativeSlice<Vector3> positions)
		{
			return this.GetPositionsWithNativeContainer((IntPtr)Unity.Collections.LowLevel.Unsafe.NativeSliceUnsafeUtility.GetUnsafePtr<Vector3>(positions), positions.Length);
		}

		// Token: 0x060007C7 RID: 1991 RVA: 0x00006147 File Offset: 0x00004347
		public void AddPositions([Out] Unity.Collections.NativeArray<Vector3> positions)
		{
			this.AddPositionsWithNativeContainer((IntPtr)Unity.Collections.LowLevel.Unsafe.NativeArrayUnsafeUtility.GetUnsafePtr<Vector3>(positions), positions.Length);
		}

		// Token: 0x060007C8 RID: 1992 RVA: 0x00006165 File Offset: 0x00004365
		public void AddPositions([Out] Unity.Collections.NativeSlice<Vector3> positions)
		{
			this.AddPositionsWithNativeContainer((IntPtr)Unity.Collections.LowLevel.Unsafe.NativeSliceUnsafeUtility.GetUnsafePtr<Vector3>(positions), positions.Length);
		}

		// Token: 0x060007C9 RID: 1993 RVA: 0x00006183 File Offset: 0x00004383
		public void SetPositionsWithNativeContainer(IntPtr positions, int count)
		{
			TrailRenderer.SetPositionsWithNativeContainerDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), positions, count);
		}

		// Token: 0x060007CA RID: 1994 RVA: 0x00006197 File Offset: 0x00004397
		public int GetPositionsWithNativeContainer(IntPtr positions, int length)
		{
			return TrailRenderer.GetPositionsWithNativeContainerDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), positions, length);
		}

		// Token: 0x060007CB RID: 1995 RVA: 0x000061AB File Offset: 0x000043AB
		public void AddPositionsWithNativeContainer(IntPtr positions, int length)
		{
			TrailRenderer.AddPositionsWithNativeContainerDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), positions, length);
		}

		// Token: 0x060007CC RID: 1996 RVA: 0x000061BF File Offset: 0x000043BF
		public void get_startColor_Injected(out Color ret)
		{
			TrailRenderer.get_startColor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060007CD RID: 1997 RVA: 0x000061D2 File Offset: 0x000043D2
		public void set_startColor_Injected(ref Color value)
		{
			TrailRenderer.set_startColor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060007CE RID: 1998 RVA: 0x000061E5 File Offset: 0x000043E5
		public void get_endColor_Injected(out Color ret)
		{
			TrailRenderer.get_endColor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060007CF RID: 1999 RVA: 0x000061F8 File Offset: 0x000043F8
		public void set_endColor_Injected(ref Color value)
		{
			TrailRenderer.set_endColor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060007D0 RID: 2000 RVA: 0x0000620B File Offset: 0x0000440B
		public void SetPosition_Injected(int index, ref Vector3 position)
		{
			TrailRenderer.SetPosition_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index, ref position);
		}

		// Token: 0x060007D1 RID: 2001 RVA: 0x0000621F File Offset: 0x0000441F
		public void GetPosition_Injected(int index, out Vector3 ret)
		{
			TrailRenderer.GetPosition_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index, out ret);
		}

		// Token: 0x060007D2 RID: 2002 RVA: 0x00006233 File Offset: 0x00004433
		public void AddPosition_Injected(ref Vector3 position)
		{
			TrailRenderer.AddPosition_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref position);
		}

		// Token: 0x04000542 RID: 1346
		private static readonly IntPtr NativeMethodInfoPtr_get_time_Public_get_Single_0;

		// Token: 0x04000543 RID: 1347
		private static readonly IntPtr NativeMethodInfoPtr_set_time_Public_set_Void_Single_0;

		// Token: 0x04000544 RID: 1348
		private static readonly IntPtr NativeMethodInfoPtr_get_startWidth_Public_get_Single_0;

		// Token: 0x04000545 RID: 1349
		private static readonly IntPtr NativeMethodInfoPtr_set_startWidth_Public_set_Void_Single_0;

		// Token: 0x04000546 RID: 1350
		private static readonly IntPtr NativeMethodInfoPtr_get_endWidth_Public_get_Single_0;

		// Token: 0x04000547 RID: 1351
		private static readonly IntPtr NativeMethodInfoPtr_set_endWidth_Public_set_Void_Single_0;

		// Token: 0x04000548 RID: 1352
		private static readonly TrailRenderer.get_widthMultiplierDelegate get_widthMultiplierDelegateField;

		// Token: 0x04000549 RID: 1353
		private static readonly TrailRenderer.set_widthMultiplierDelegate set_widthMultiplierDelegateField;

		// Token: 0x0400054A RID: 1354
		private static readonly TrailRenderer.get_autodestructDelegate get_autodestructDelegateField;

		// Token: 0x0400054B RID: 1355
		private static readonly TrailRenderer.set_autodestructDelegate set_autodestructDelegateField;

		// Token: 0x0400054C RID: 1356
		private static readonly TrailRenderer.get_emittingDelegate get_emittingDelegateField;

		// Token: 0x0400054D RID: 1357
		private static readonly TrailRenderer.set_emittingDelegate set_emittingDelegateField;

		// Token: 0x0400054E RID: 1358
		private static readonly TrailRenderer.get_numCornerVerticesDelegate get_numCornerVerticesDelegateField;

		// Token: 0x0400054F RID: 1359
		private static readonly TrailRenderer.set_numCornerVerticesDelegate set_numCornerVerticesDelegateField;

		// Token: 0x04000550 RID: 1360
		private static readonly TrailRenderer.get_numCapVerticesDelegate get_numCapVerticesDelegateField;

		// Token: 0x04000551 RID: 1361
		private static readonly TrailRenderer.set_numCapVerticesDelegate set_numCapVerticesDelegateField;

		// Token: 0x04000552 RID: 1362
		private static readonly TrailRenderer.get_minVertexDistanceDelegate get_minVertexDistanceDelegateField;

		// Token: 0x04000553 RID: 1363
		private static readonly TrailRenderer.set_minVertexDistanceDelegate set_minVertexDistanceDelegateField;

		// Token: 0x04000554 RID: 1364
		private static readonly TrailRenderer.get_positionCountDelegate get_positionCountDelegateField;

		// Token: 0x04000555 RID: 1365
		private static readonly TrailRenderer.get_shadowBiasDelegate get_shadowBiasDelegateField;

		// Token: 0x04000556 RID: 1366
		private static readonly TrailRenderer.set_shadowBiasDelegate set_shadowBiasDelegateField;

		// Token: 0x04000557 RID: 1367
		private static readonly TrailRenderer.get_generateLightingDataDelegate get_generateLightingDataDelegateField;

		// Token: 0x04000558 RID: 1368
		private static readonly TrailRenderer.set_generateLightingDataDelegate set_generateLightingDataDelegateField;

		// Token: 0x04000559 RID: 1369
		private static readonly TrailRenderer.get_textureModeDelegate get_textureModeDelegateField;

		// Token: 0x0400055A RID: 1370
		private static readonly TrailRenderer.set_textureModeDelegate set_textureModeDelegateField;

		// Token: 0x0400055B RID: 1371
		private static readonly TrailRenderer.get_alignmentDelegate get_alignmentDelegateField;

		// Token: 0x0400055C RID: 1372
		private static readonly TrailRenderer.set_alignmentDelegate set_alignmentDelegateField;

		// Token: 0x0400055D RID: 1373
		private static readonly TrailRenderer.ClearDelegate ClearDelegateField;

		// Token: 0x0400055E RID: 1374
		private static readonly TrailRenderer.BakeMeshDelegate BakeMeshDelegateField;

		// Token: 0x0400055F RID: 1375
		private static readonly TrailRenderer.GetWidthCurveCopyDelegate GetWidthCurveCopyDelegateField;

		// Token: 0x04000560 RID: 1376
		private static readonly TrailRenderer.SetWidthCurveDelegate SetWidthCurveDelegateField;

		// Token: 0x04000561 RID: 1377
		private static readonly TrailRenderer.GetColorGradientCopyDelegate GetColorGradientCopyDelegateField;

		// Token: 0x04000562 RID: 1378
		private static readonly TrailRenderer.SetColorGradientDelegate SetColorGradientDelegateField;

		// Token: 0x04000563 RID: 1379
		private static readonly TrailRenderer.GetPositionsDelegate GetPositionsDelegateField;

		// Token: 0x04000564 RID: 1380
		private static readonly TrailRenderer.SetPositionsDelegate SetPositionsDelegateField;

		// Token: 0x04000565 RID: 1381
		private static readonly TrailRenderer.AddPositionsDelegate AddPositionsDelegateField;

		// Token: 0x04000566 RID: 1382
		private static readonly TrailRenderer.SetPositionsWithNativeContainerDelegate SetPositionsWithNativeContainerDelegateField;

		// Token: 0x04000567 RID: 1383
		private static readonly TrailRenderer.GetPositionsWithNativeContainerDelegate GetPositionsWithNativeContainerDelegateField;

		// Token: 0x04000568 RID: 1384
		private static readonly TrailRenderer.AddPositionsWithNativeContainerDelegate AddPositionsWithNativeContainerDelegateField;

		// Token: 0x04000569 RID: 1385
		private static readonly TrailRenderer.get_startColor_InjectedDelegate get_startColor_InjectedDelegateField;

		// Token: 0x0400056A RID: 1386
		private static readonly TrailRenderer.set_startColor_InjectedDelegate set_startColor_InjectedDelegateField;

		// Token: 0x0400056B RID: 1387
		private static readonly TrailRenderer.get_endColor_InjectedDelegate get_endColor_InjectedDelegateField;

		// Token: 0x0400056C RID: 1388
		private static readonly TrailRenderer.set_endColor_InjectedDelegate set_endColor_InjectedDelegateField;

		// Token: 0x0400056D RID: 1389
		private static readonly TrailRenderer.SetPosition_InjectedDelegate SetPosition_InjectedDelegateField;

		// Token: 0x0400056E RID: 1390
		private static readonly TrailRenderer.GetPosition_InjectedDelegate GetPosition_InjectedDelegateField;

		// Token: 0x0400056F RID: 1391
		private static readonly TrailRenderer.AddPosition_InjectedDelegate AddPosition_InjectedDelegateField;

		// Token: 0x020004E7 RID: 1255
		// (Invoke) Token: 0x06002804 RID: 10244
		private delegate float get_widthMultiplierDelegate(IntPtr @this);

		// Token: 0x020004E8 RID: 1256
		// (Invoke) Token: 0x06002806 RID: 10246
		private delegate void set_widthMultiplierDelegate(IntPtr @this, float value);

		// Token: 0x020004E9 RID: 1257
		// (Invoke) Token: 0x06002808 RID: 10248
		private delegate bool get_autodestructDelegate(IntPtr @this);

		// Token: 0x020004EA RID: 1258
		// (Invoke) Token: 0x0600280A RID: 10250
		private delegate void set_autodestructDelegate(IntPtr @this, bool value);

		// Token: 0x020004EB RID: 1259
		// (Invoke) Token: 0x0600280C RID: 10252
		private delegate bool get_emittingDelegate(IntPtr @this);

		// Token: 0x020004EC RID: 1260
		// (Invoke) Token: 0x0600280E RID: 10254
		private delegate void set_emittingDelegate(IntPtr @this, bool value);

		// Token: 0x020004ED RID: 1261
		// (Invoke) Token: 0x06002810 RID: 10256
		private delegate int get_numCornerVerticesDelegate(IntPtr @this);

		// Token: 0x020004EE RID: 1262
		// (Invoke) Token: 0x06002812 RID: 10258
		private delegate void set_numCornerVerticesDelegate(IntPtr @this, int value);

		// Token: 0x020004EF RID: 1263
		// (Invoke) Token: 0x06002814 RID: 10260
		private delegate int get_numCapVerticesDelegate(IntPtr @this);

		// Token: 0x020004F0 RID: 1264
		// (Invoke) Token: 0x06002816 RID: 10262
		private delegate void set_numCapVerticesDelegate(IntPtr @this, int value);

		// Token: 0x020004F1 RID: 1265
		// (Invoke) Token: 0x06002818 RID: 10264
		private delegate float get_minVertexDistanceDelegate(IntPtr @this);

		// Token: 0x020004F2 RID: 1266
		// (Invoke) Token: 0x0600281A RID: 10266
		private delegate void set_minVertexDistanceDelegate(IntPtr @this, float value);

		// Token: 0x020004F3 RID: 1267
		// (Invoke) Token: 0x0600281C RID: 10268
		private delegate int get_positionCountDelegate(IntPtr @this);

		// Token: 0x020004F4 RID: 1268
		// (Invoke) Token: 0x0600281E RID: 10270
		private delegate float get_shadowBiasDelegate(IntPtr @this);

		// Token: 0x020004F5 RID: 1269
		// (Invoke) Token: 0x06002820 RID: 10272
		private delegate void set_shadowBiasDelegate(IntPtr @this, float value);

		// Token: 0x020004F6 RID: 1270
		// (Invoke) Token: 0x06002822 RID: 10274
		private delegate bool get_generateLightingDataDelegate(IntPtr @this);

		// Token: 0x020004F7 RID: 1271
		// (Invoke) Token: 0x06002824 RID: 10276
		private delegate void set_generateLightingDataDelegate(IntPtr @this, bool value);

		// Token: 0x020004F8 RID: 1272
		// (Invoke) Token: 0x06002826 RID: 10278
		private delegate LineTextureMode get_textureModeDelegate(IntPtr @this);

		// Token: 0x020004F9 RID: 1273
		// (Invoke) Token: 0x06002828 RID: 10280
		private delegate void set_textureModeDelegate(IntPtr @this, LineTextureMode value);

		// Token: 0x020004FA RID: 1274
		// (Invoke) Token: 0x0600282A RID: 10282
		private delegate LineAlignment get_alignmentDelegate(IntPtr @this);

		// Token: 0x020004FB RID: 1275
		// (Invoke) Token: 0x0600282C RID: 10284
		private delegate void set_alignmentDelegate(IntPtr @this, LineAlignment value);

		// Token: 0x020004FC RID: 1276
		// (Invoke) Token: 0x0600282E RID: 10286
		private delegate void ClearDelegate(IntPtr @this);

		// Token: 0x020004FD RID: 1277
		// (Invoke) Token: 0x06002830 RID: 10288
		private delegate void BakeMeshDelegate(IntPtr @this, IntPtr mesh, IntPtr camera, bool useTransform);

		// Token: 0x020004FE RID: 1278
		// (Invoke) Token: 0x06002832 RID: 10290
		private delegate IntPtr GetWidthCurveCopyDelegate(IntPtr @this);

		// Token: 0x020004FF RID: 1279
		// (Invoke) Token: 0x06002834 RID: 10292
		private delegate void SetWidthCurveDelegate(IntPtr @this, IntPtr curve);

		// Token: 0x02000500 RID: 1280
		// (Invoke) Token: 0x06002836 RID: 10294
		private delegate IntPtr GetColorGradientCopyDelegate(IntPtr @this);

		// Token: 0x02000501 RID: 1281
		// (Invoke) Token: 0x06002838 RID: 10296
		private delegate void SetColorGradientDelegate(IntPtr @this, IntPtr curve);

		// Token: 0x02000502 RID: 1282
		// (Invoke) Token: 0x0600283A RID: 10298
		private delegate int GetPositionsDelegate(IntPtr @this, [Out] IntPtr positions);

		// Token: 0x02000503 RID: 1283
		// (Invoke) Token: 0x0600283C RID: 10300
		private delegate void SetPositionsDelegate(IntPtr @this, IntPtr positions);

		// Token: 0x02000504 RID: 1284
		// (Invoke) Token: 0x0600283E RID: 10302
		private delegate void AddPositionsDelegate(IntPtr @this, IntPtr positions);

		// Token: 0x02000505 RID: 1285
		// (Invoke) Token: 0x06002840 RID: 10304
		private delegate void SetPositionsWithNativeContainerDelegate(IntPtr @this, IntPtr positions, int count);

		// Token: 0x02000506 RID: 1286
		// (Invoke) Token: 0x06002842 RID: 10306
		private delegate int GetPositionsWithNativeContainerDelegate(IntPtr @this, IntPtr positions, int length);

		// Token: 0x02000507 RID: 1287
		// (Invoke) Token: 0x06002844 RID: 10308
		private delegate void AddPositionsWithNativeContainerDelegate(IntPtr @this, IntPtr positions, int length);

		// Token: 0x02000508 RID: 1288
		// (Invoke) Token: 0x06002846 RID: 10310
		private delegate void get_startColor_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000509 RID: 1289
		// (Invoke) Token: 0x06002848 RID: 10312
		private delegate void set_startColor_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200050A RID: 1290
		// (Invoke) Token: 0x0600284A RID: 10314
		private delegate void get_endColor_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200050B RID: 1291
		// (Invoke) Token: 0x0600284C RID: 10316
		private delegate void set_endColor_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200050C RID: 1292
		// (Invoke) Token: 0x0600284E RID: 10318
		private delegate void SetPosition_InjectedDelegate(IntPtr @this, int index, IntPtr position);

		// Token: 0x0200050D RID: 1293
		// (Invoke) Token: 0x06002850 RID: 10320
		private delegate void GetPosition_InjectedDelegate(IntPtr @this, int index, [Out] IntPtr ret);

		// Token: 0x0200050E RID: 1294
		// (Invoke) Token: 0x06002852 RID: 10322
		private delegate void AddPosition_InjectedDelegate(IntPtr @this, IntPtr position);
	}
}
