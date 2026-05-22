using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine
{
	// Token: 0x02000005 RID: 5
	public sealed class ParticleSystemRenderer : Renderer
	{
		// Token: 0x06000073 RID: 115 RVA: 0x00003D6C File Offset: 0x00001F6C
		// Note: this type is marked as 'beforefieldinit'.
		static ParticleSystemRenderer()
		{
			Il2CppClassPointerStore<ParticleSystemRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.ParticleSystemModule.dll", "UnityEngine", "ParticleSystemRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleSystemRenderer>.NativeClassPtr);
			ParticleSystemRenderer.NativeMethodInfoPtr_GetMeshes_Public_Int32_Il2CppReferenceArray_1_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemRenderer>.NativeClassPtr, 100663365);
			ParticleSystemRenderer.get_alignmentDelegateField = IL2CPP.ResolveICall<ParticleSystemRenderer.get_alignmentDelegate>("UnityEngine.ParticleSystemRenderer::get_alignment");
			ParticleSystemRenderer.set_alignmentDelegateField = IL2CPP.ResolveICall<ParticleSystemRenderer.set_alignmentDelegate>("UnityEngine.ParticleSystemRenderer::set_alignment");
			ParticleSystemRenderer.get_renderModeDelegateField = IL2CPP.ResolveICall<ParticleSystemRenderer.get_renderModeDelegate>("UnityEngine.ParticleSystemRenderer::get_renderMode");
			ParticleSystemRenderer.set_renderModeDelegateField = IL2CPP.ResolveICall<ParticleSystemRenderer.set_renderModeDelegate>("UnityEngine.ParticleSystemRenderer::set_renderMode");
			ParticleSystemRenderer.get_sortModeDelegateField = IL2CPP.ResolveICall<ParticleSystemRenderer.get_sortModeDelegate>("UnityEngine.ParticleSystemRenderer::get_sortMode");
			ParticleSystemRenderer.set_sortModeDelegateField = IL2CPP.ResolveICall<ParticleSystemRenderer.set_sortModeDelegate>("UnityEngine.ParticleSystemRenderer::set_sortMode");
			ParticleSystemRenderer.get_lengthScaleDelegateField = IL2CPP.ResolveICall<ParticleSystemRenderer.get_lengthScaleDelegate>("UnityEngine.ParticleSystemRenderer::get_lengthScale");
			ParticleSystemRenderer.set_lengthScaleDelegateField = IL2CPP.ResolveICall<ParticleSystemRenderer.set_lengthScaleDelegate>("UnityEngine.ParticleSystemRenderer::set_lengthScale");
			ParticleSystemRenderer.get_velocityScaleDelegateField = IL2CPP.ResolveICall<ParticleSystemRenderer.get_velocityScaleDelegate>("UnityEngine.ParticleSystemRenderer::get_velocityScale");
			ParticleSystemRenderer.set_velocityScaleDelegateField = IL2CPP.ResolveICall<ParticleSystemRenderer.set_velocityScaleDelegate>("UnityEngine.ParticleSystemRenderer::set_velocityScale");
			ParticleSystemRenderer.get_cameraVelocityScaleDelegateField = IL2CPP.ResolveICall<ParticleSystemRenderer.get_cameraVelocityScaleDelegate>("UnityEngine.ParticleSystemRenderer::get_cameraVelocityScale");
			ParticleSystemRenderer.set_cameraVelocityScaleDelegateField = IL2CPP.ResolveICall<ParticleSystemRenderer.set_cameraVelocityScaleDelegate>("UnityEngine.ParticleSystemRenderer::set_cameraVelocityScale");
			ParticleSystemRenderer.get_normalDirectionDelegateField = IL2CPP.ResolveICall<ParticleSystemRenderer.get_normalDirectionDelegate>("UnityEngine.ParticleSystemRenderer::get_normalDirection");
			ParticleSystemRenderer.set_normalDirectionDelegateField = IL2CPP.ResolveICall<ParticleSystemRenderer.set_normalDirectionDelegate>("UnityEngine.ParticleSystemRenderer::set_normalDirection");
			ParticleSystemRenderer.get_shadowBiasDelegateField = IL2CPP.ResolveICall<ParticleSystemRenderer.get_shadowBiasDelegate>("UnityEngine.ParticleSystemRenderer::get_shadowBias");
			ParticleSystemRenderer.set_shadowBiasDelegateField = IL2CPP.ResolveICall<ParticleSystemRenderer.set_shadowBiasDelegate>("UnityEngine.ParticleSystemRenderer::set_shadowBias");
			ParticleSystemRenderer.get_sortingFudgeDelegateField = IL2CPP.ResolveICall<ParticleSystemRenderer.get_sortingFudgeDelegate>("UnityEngine.ParticleSystemRenderer::get_sortingFudge");
			ParticleSystemRenderer.set_sortingFudgeDelegateField = IL2CPP.ResolveICall<ParticleSystemRenderer.set_sortingFudgeDelegate>("UnityEngine.ParticleSystemRenderer::set_sortingFudge");
			ParticleSystemRenderer.get_minParticleSizeDelegateField = IL2CPP.ResolveICall<ParticleSystemRenderer.get_minParticleSizeDelegate>("UnityEngine.ParticleSystemRenderer::get_minParticleSize");
			ParticleSystemRenderer.set_minParticleSizeDelegateField = IL2CPP.ResolveICall<ParticleSystemRenderer.set_minParticleSizeDelegate>("UnityEngine.ParticleSystemRenderer::set_minParticleSize");
			ParticleSystemRenderer.get_maxParticleSizeDelegateField = IL2CPP.ResolveICall<ParticleSystemRenderer.get_maxParticleSizeDelegate>("UnityEngine.ParticleSystemRenderer::get_maxParticleSize");
			ParticleSystemRenderer.set_maxParticleSizeDelegateField = IL2CPP.ResolveICall<ParticleSystemRenderer.set_maxParticleSizeDelegate>("UnityEngine.ParticleSystemRenderer::set_maxParticleSize");
			ParticleSystemRenderer.get_maskInteractionDelegateField = IL2CPP.ResolveICall<ParticleSystemRenderer.get_maskInteractionDelegate>("UnityEngine.ParticleSystemRenderer::get_maskInteraction");
			ParticleSystemRenderer.set_maskInteractionDelegateField = IL2CPP.ResolveICall<ParticleSystemRenderer.set_maskInteractionDelegate>("UnityEngine.ParticleSystemRenderer::set_maskInteraction");
			ParticleSystemRenderer.get_trailMaterialDelegateField = IL2CPP.ResolveICall<ParticleSystemRenderer.get_trailMaterialDelegate>("UnityEngine.ParticleSystemRenderer::get_trailMaterial");
			ParticleSystemRenderer.set_trailMaterialDelegateField = IL2CPP.ResolveICall<ParticleSystemRenderer.set_trailMaterialDelegate>("UnityEngine.ParticleSystemRenderer::set_trailMaterial");
			ParticleSystemRenderer.set_oldTrailMaterialDelegateField = IL2CPP.ResolveICall<ParticleSystemRenderer.set_oldTrailMaterialDelegate>("UnityEngine.ParticleSystemRenderer::set_oldTrailMaterial");
			ParticleSystemRenderer.get_enableGPUInstancingDelegateField = IL2CPP.ResolveICall<ParticleSystemRenderer.get_enableGPUInstancingDelegate>("UnityEngine.ParticleSystemRenderer::get_enableGPUInstancing");
			ParticleSystemRenderer.set_enableGPUInstancingDelegateField = IL2CPP.ResolveICall<ParticleSystemRenderer.set_enableGPUInstancingDelegate>("UnityEngine.ParticleSystemRenderer::set_enableGPUInstancing");
			ParticleSystemRenderer.get_allowRollDelegateField = IL2CPP.ResolveICall<ParticleSystemRenderer.get_allowRollDelegate>("UnityEngine.ParticleSystemRenderer::get_allowRoll");
			ParticleSystemRenderer.set_allowRollDelegateField = IL2CPP.ResolveICall<ParticleSystemRenderer.set_allowRollDelegate>("UnityEngine.ParticleSystemRenderer::set_allowRoll");
			ParticleSystemRenderer.get_freeformStretchingDelegateField = IL2CPP.ResolveICall<ParticleSystemRenderer.get_freeformStretchingDelegate>("UnityEngine.ParticleSystemRenderer::get_freeformStretching");
			ParticleSystemRenderer.set_freeformStretchingDelegateField = IL2CPP.ResolveICall<ParticleSystemRenderer.set_freeformStretchingDelegate>("UnityEngine.ParticleSystemRenderer::set_freeformStretching");
			ParticleSystemRenderer.get_rotateWithStretchDirectionDelegateField = IL2CPP.ResolveICall<ParticleSystemRenderer.get_rotateWithStretchDirectionDelegate>("UnityEngine.ParticleSystemRenderer::get_rotateWithStretchDirection");
			ParticleSystemRenderer.set_rotateWithStretchDirectionDelegateField = IL2CPP.ResolveICall<ParticleSystemRenderer.set_rotateWithStretchDirectionDelegate>("UnityEngine.ParticleSystemRenderer::set_rotateWithStretchDirection");
			ParticleSystemRenderer.get_meshDelegateField = IL2CPP.ResolveICall<ParticleSystemRenderer.get_meshDelegate>("UnityEngine.ParticleSystemRenderer::get_mesh");
			ParticleSystemRenderer.set_meshDelegateField = IL2CPP.ResolveICall<ParticleSystemRenderer.set_meshDelegate>("UnityEngine.ParticleSystemRenderer::set_mesh");
			ParticleSystemRenderer.SetMeshesDelegateField = IL2CPP.ResolveICall<ParticleSystemRenderer.SetMeshesDelegate>("UnityEngine.ParticleSystemRenderer::SetMeshes");
			ParticleSystemRenderer.get_meshCountDelegateField = IL2CPP.ResolveICall<ParticleSystemRenderer.get_meshCountDelegate>("UnityEngine.ParticleSystemRenderer::get_meshCount");
			ParticleSystemRenderer.BakeMeshDelegateField = IL2CPP.ResolveICall<ParticleSystemRenderer.BakeMeshDelegate>("UnityEngine.ParticleSystemRenderer::BakeMesh");
			ParticleSystemRenderer.BakeTrailsMeshDelegateField = IL2CPP.ResolveICall<ParticleSystemRenderer.BakeTrailsMeshDelegate>("UnityEngine.ParticleSystemRenderer::BakeTrailsMesh");
			ParticleSystemRenderer.get_activeVertexStreamsCountDelegateField = IL2CPP.ResolveICall<ParticleSystemRenderer.get_activeVertexStreamsCountDelegate>("UnityEngine.ParticleSystemRenderer::get_activeVertexStreamsCount");
			ParticleSystemRenderer.SetActiveVertexStreamsDelegateField = IL2CPP.ResolveICall<ParticleSystemRenderer.SetActiveVertexStreamsDelegate>("UnityEngine.ParticleSystemRenderer::SetActiveVertexStreams");
			ParticleSystemRenderer.GetActiveVertexStreamsDelegateField = IL2CPP.ResolveICall<ParticleSystemRenderer.GetActiveVertexStreamsDelegate>("UnityEngine.ParticleSystemRenderer::GetActiveVertexStreams");
			ParticleSystemRenderer.get_pivot_InjectedDelegateField = IL2CPP.ResolveICall<ParticleSystemRenderer.get_pivot_InjectedDelegate>("UnityEngine.ParticleSystemRenderer::get_pivot_Injected");
			ParticleSystemRenderer.set_pivot_InjectedDelegateField = IL2CPP.ResolveICall<ParticleSystemRenderer.set_pivot_InjectedDelegate>("UnityEngine.ParticleSystemRenderer::set_pivot_Injected");
			ParticleSystemRenderer.get_flip_InjectedDelegateField = IL2CPP.ResolveICall<ParticleSystemRenderer.get_flip_InjectedDelegate>("UnityEngine.ParticleSystemRenderer::get_flip_Injected");
			ParticleSystemRenderer.set_flip_InjectedDelegateField = IL2CPP.ResolveICall<ParticleSystemRenderer.set_flip_InjectedDelegate>("UnityEngine.ParticleSystemRenderer::set_flip_Injected");
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00004080 File Offset: 0x00002280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512520, XrefRangeEnd = 512524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetMeshes([Out] Il2CppReferenceArray<Mesh> meshes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ParticleSystemRenderer.NativeMethodInfoPtr_GetMeshes_Public_Int32_Il2CppReferenceArray_1_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				*meshes = ((intPtr4 == 0) ? null : new Il2CppReferenceArray<Mesh>(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00002356 File Offset: 0x00000556
		public ParticleSystemRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000076 RID: 118 RVA: 0x0000235F File Offset: 0x0000055F
		public void EnableVertexStreams(ParticleSystemVertexStreams streams)
		{
			this.Internal_SetVertexStreams(streams, true);
		}

		// Token: 0x06000077 RID: 119 RVA: 0x0000236B File Offset: 0x0000056B
		public void DisableVertexStreams(ParticleSystemVertexStreams streams)
		{
			this.Internal_SetVertexStreams(streams, false);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x000040E0 File Offset: 0x000022E0
		public bool AreVertexStreamsEnabled(ParticleSystemVertexStreams streams)
		{
			return this.Internal_GetEnabledVertexStreams(streams) == streams;
		}

		// Token: 0x06000079 RID: 121 RVA: 0x000040FC File Offset: 0x000022FC
		public ParticleSystemVertexStreams GetEnabledVertexStreams(ParticleSystemVertexStreams streams)
		{
			return this.Internal_GetEnabledVertexStreams(streams);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00004118 File Offset: 0x00002318
		public void Internal_SetVertexStreams(ParticleSystemVertexStreams streams, bool enabled)
		{
			List<ParticleSystemVertexStream> list = new List<ParticleSystemVertexStream>(this.activeVertexStreamsCount);
			this.GetActiveVertexStreams(list);
			if (enabled)
			{
				bool flag = (streams & ParticleSystemVertexStreams.Position) > ParticleSystemVertexStreams.None;
				if (flag)
				{
					bool flag2 = !list.Contains(ParticleSystemVertexStream.Position);
					if (flag2)
					{
						list.Add(ParticleSystemVertexStream.Position);
					}
				}
				bool flag3 = (streams & ParticleSystemVertexStreams.Normal) > ParticleSystemVertexStreams.None;
				if (flag3)
				{
					bool flag4 = !list.Contains(ParticleSystemVertexStream.Normal);
					if (flag4)
					{
						list.Add(ParticleSystemVertexStream.Normal);
					}
				}
				bool flag5 = (streams & ParticleSystemVertexStreams.Tangent) > ParticleSystemVertexStreams.None;
				if (flag5)
				{
					bool flag6 = !list.Contains(ParticleSystemVertexStream.Tangent);
					if (flag6)
					{
						list.Add(ParticleSystemVertexStream.Tangent);
					}
				}
				bool flag7 = (streams & ParticleSystemVertexStreams.Color) > ParticleSystemVertexStreams.None;
				if (flag7)
				{
					bool flag8 = !list.Contains(ParticleSystemVertexStream.Color);
					if (flag8)
					{
						list.Add(ParticleSystemVertexStream.Color);
					}
				}
				bool flag9 = (streams & ParticleSystemVertexStreams.UV) > ParticleSystemVertexStreams.None;
				if (flag9)
				{
					bool flag10 = !list.Contains(ParticleSystemVertexStream.UV);
					if (flag10)
					{
						list.Add(ParticleSystemVertexStream.UV);
					}
				}
				bool flag11 = (streams & ParticleSystemVertexStreams.UV2BlendAndFrame) > ParticleSystemVertexStreams.None;
				if (flag11)
				{
					bool flag12 = !list.Contains(ParticleSystemVertexStream.UV2);
					if (flag12)
					{
						list.Add(ParticleSystemVertexStream.UV2);
						list.Add(ParticleSystemVertexStream.AnimBlend);
						list.Add(ParticleSystemVertexStream.AnimFrame);
					}
				}
				bool flag13 = (streams & ParticleSystemVertexStreams.CenterAndVertexID) > ParticleSystemVertexStreams.None;
				if (flag13)
				{
					bool flag14 = !list.Contains(ParticleSystemVertexStream.Center);
					if (flag14)
					{
						list.Add(ParticleSystemVertexStream.Center);
						list.Add(ParticleSystemVertexStream.VertexID);
					}
				}
				bool flag15 = (streams & ParticleSystemVertexStreams.Size) > ParticleSystemVertexStreams.None;
				if (flag15)
				{
					bool flag16 = !list.Contains(ParticleSystemVertexStream.SizeXYZ);
					if (flag16)
					{
						list.Add(ParticleSystemVertexStream.SizeXYZ);
					}
				}
				bool flag17 = (streams & ParticleSystemVertexStreams.Rotation) > ParticleSystemVertexStreams.None;
				if (flag17)
				{
					bool flag18 = !list.Contains(ParticleSystemVertexStream.Rotation3D);
					if (flag18)
					{
						list.Add(ParticleSystemVertexStream.Rotation3D);
					}
				}
				bool flag19 = (streams & ParticleSystemVertexStreams.Velocity) > ParticleSystemVertexStreams.None;
				if (flag19)
				{
					bool flag20 = !list.Contains(ParticleSystemVertexStream.Velocity);
					if (flag20)
					{
						list.Add(ParticleSystemVertexStream.Velocity);
					}
				}
				bool flag21 = (streams & ParticleSystemVertexStreams.Lifetime) > ParticleSystemVertexStreams.None;
				if (flag21)
				{
					bool flag22 = !list.Contains(ParticleSystemVertexStream.AgePercent);
					if (flag22)
					{
						list.Add(ParticleSystemVertexStream.AgePercent);
						list.Add(ParticleSystemVertexStream.InvStartLifetime);
					}
				}
				bool flag23 = (streams & ParticleSystemVertexStreams.Custom1) > ParticleSystemVertexStreams.None;
				if (flag23)
				{
					bool flag24 = !list.Contains(ParticleSystemVertexStream.Custom1XYZW);
					if (flag24)
					{
						list.Add(ParticleSystemVertexStream.Custom1XYZW);
					}
				}
				bool flag25 = (streams & ParticleSystemVertexStreams.Custom2) > ParticleSystemVertexStreams.None;
				if (flag25)
				{
					bool flag26 = !list.Contains(ParticleSystemVertexStream.Custom2XYZW);
					if (flag26)
					{
						list.Add(ParticleSystemVertexStream.Custom2XYZW);
					}
				}
				bool flag27 = (streams & ParticleSystemVertexStreams.Random) > ParticleSystemVertexStreams.None;
				if (flag27)
				{
					bool flag28 = !list.Contains(ParticleSystemVertexStream.StableRandomXYZ);
					if (flag28)
					{
						list.Add(ParticleSystemVertexStream.StableRandomXYZ);
						list.Add(ParticleSystemVertexStream.VaryingRandomX);
					}
				}
			}
			else
			{
				bool flag29 = (streams & ParticleSystemVertexStreams.Position) > ParticleSystemVertexStreams.None;
				if (flag29)
				{
					list.Remove(ParticleSystemVertexStream.Position);
				}
				bool flag30 = (streams & ParticleSystemVertexStreams.Normal) > ParticleSystemVertexStreams.None;
				if (flag30)
				{
					list.Remove(ParticleSystemVertexStream.Normal);
				}
				bool flag31 = (streams & ParticleSystemVertexStreams.Tangent) > ParticleSystemVertexStreams.None;
				if (flag31)
				{
					list.Remove(ParticleSystemVertexStream.Tangent);
				}
				bool flag32 = (streams & ParticleSystemVertexStreams.Color) > ParticleSystemVertexStreams.None;
				if (flag32)
				{
					list.Remove(ParticleSystemVertexStream.Color);
				}
				bool flag33 = (streams & ParticleSystemVertexStreams.UV) > ParticleSystemVertexStreams.None;
				if (flag33)
				{
					list.Remove(ParticleSystemVertexStream.UV);
				}
				bool flag34 = (streams & ParticleSystemVertexStreams.UV2BlendAndFrame) > ParticleSystemVertexStreams.None;
				if (flag34)
				{
					list.Remove(ParticleSystemVertexStream.UV2);
					list.Remove(ParticleSystemVertexStream.AnimBlend);
					list.Remove(ParticleSystemVertexStream.AnimFrame);
				}
				bool flag35 = (streams & ParticleSystemVertexStreams.CenterAndVertexID) > ParticleSystemVertexStreams.None;
				if (flag35)
				{
					list.Remove(ParticleSystemVertexStream.Center);
					list.Remove(ParticleSystemVertexStream.VertexID);
				}
				bool flag36 = (streams & ParticleSystemVertexStreams.Size) > ParticleSystemVertexStreams.None;
				if (flag36)
				{
					list.Remove(ParticleSystemVertexStream.SizeXYZ);
				}
				bool flag37 = (streams & ParticleSystemVertexStreams.Rotation) > ParticleSystemVertexStreams.None;
				if (flag37)
				{
					list.Remove(ParticleSystemVertexStream.Rotation3D);
				}
				bool flag38 = (streams & ParticleSystemVertexStreams.Velocity) > ParticleSystemVertexStreams.None;
				if (flag38)
				{
					list.Remove(ParticleSystemVertexStream.Velocity);
				}
				bool flag39 = (streams & ParticleSystemVertexStreams.Lifetime) > ParticleSystemVertexStreams.None;
				if (flag39)
				{
					list.Remove(ParticleSystemVertexStream.AgePercent);
					list.Remove(ParticleSystemVertexStream.InvStartLifetime);
				}
				bool flag40 = (streams & ParticleSystemVertexStreams.Custom1) > ParticleSystemVertexStreams.None;
				if (flag40)
				{
					list.Remove(ParticleSystemVertexStream.Custom1XYZW);
				}
				bool flag41 = (streams & ParticleSystemVertexStreams.Custom2) > ParticleSystemVertexStreams.None;
				if (flag41)
				{
					list.Remove(ParticleSystemVertexStream.Custom2XYZW);
				}
				bool flag42 = (streams & ParticleSystemVertexStreams.Random) > ParticleSystemVertexStreams.None;
				if (flag42)
				{
					list.Remove(ParticleSystemVertexStream.StableRandomXYZW);
					list.Remove(ParticleSystemVertexStream.VaryingRandomX);
				}
			}
			this.SetActiveVertexStreams(list);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00004564 File Offset: 0x00002764
		public ParticleSystemVertexStreams Internal_GetEnabledVertexStreams(ParticleSystemVertexStreams streams)
		{
			List<ParticleSystemVertexStream> list = new List<ParticleSystemVertexStream>(this.activeVertexStreamsCount);
			this.GetActiveVertexStreams(list);
			ParticleSystemVertexStreams particleSystemVertexStreams = ParticleSystemVertexStreams.None;
			bool flag = list.Contains(ParticleSystemVertexStream.Position);
			if (flag)
			{
				particleSystemVertexStreams |= ParticleSystemVertexStreams.Position;
			}
			bool flag2 = list.Contains(ParticleSystemVertexStream.Normal);
			if (flag2)
			{
				particleSystemVertexStreams |= ParticleSystemVertexStreams.Normal;
			}
			bool flag3 = list.Contains(ParticleSystemVertexStream.Tangent);
			if (flag3)
			{
				particleSystemVertexStreams |= ParticleSystemVertexStreams.Tangent;
			}
			bool flag4 = list.Contains(ParticleSystemVertexStream.Color);
			if (flag4)
			{
				particleSystemVertexStreams |= ParticleSystemVertexStreams.Color;
			}
			bool flag5 = list.Contains(ParticleSystemVertexStream.UV);
			if (flag5)
			{
				particleSystemVertexStreams |= ParticleSystemVertexStreams.UV;
			}
			bool flag6 = list.Contains(ParticleSystemVertexStream.UV2);
			if (flag6)
			{
				particleSystemVertexStreams |= ParticleSystemVertexStreams.UV2BlendAndFrame;
			}
			bool flag7 = list.Contains(ParticleSystemVertexStream.Center);
			if (flag7)
			{
				particleSystemVertexStreams |= ParticleSystemVertexStreams.CenterAndVertexID;
			}
			bool flag8 = list.Contains(ParticleSystemVertexStream.SizeXYZ);
			if (flag8)
			{
				particleSystemVertexStreams |= ParticleSystemVertexStreams.Size;
			}
			bool flag9 = list.Contains(ParticleSystemVertexStream.Rotation3D);
			if (flag9)
			{
				particleSystemVertexStreams |= ParticleSystemVertexStreams.Rotation;
			}
			bool flag10 = list.Contains(ParticleSystemVertexStream.Velocity);
			if (flag10)
			{
				particleSystemVertexStreams |= ParticleSystemVertexStreams.Velocity;
			}
			bool flag11 = list.Contains(ParticleSystemVertexStream.AgePercent);
			if (flag11)
			{
				particleSystemVertexStreams |= ParticleSystemVertexStreams.Lifetime;
			}
			bool flag12 = list.Contains(ParticleSystemVertexStream.Custom1XYZW);
			if (flag12)
			{
				particleSystemVertexStreams |= ParticleSystemVertexStreams.Custom1;
			}
			bool flag13 = list.Contains(ParticleSystemVertexStream.Custom2XYZW);
			if (flag13)
			{
				particleSystemVertexStreams |= ParticleSystemVertexStreams.Custom2;
			}
			bool flag14 = list.Contains(ParticleSystemVertexStream.StableRandomXYZ);
			if (flag14)
			{
				particleSystemVertexStreams |= ParticleSystemVertexStreams.Random;
			}
			return particleSystemVertexStreams & streams;
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600007C RID: 124 RVA: 0x00002377 File Offset: 0x00000577
		// (set) Token: 0x0600007D RID: 125 RVA: 0x00002389 File Offset: 0x00000589
		public ParticleSystemRenderSpace alignment
		{
			get
			{
				return ParticleSystemRenderer.get_alignmentDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ParticleSystemRenderer.set_alignmentDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600007E RID: 126 RVA: 0x0000239C File Offset: 0x0000059C
		// (set) Token: 0x0600007F RID: 127 RVA: 0x000023AE File Offset: 0x000005AE
		public ParticleSystemRenderMode renderMode
		{
			get
			{
				return ParticleSystemRenderer.get_renderModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ParticleSystemRenderer.set_renderModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000080 RID: 128 RVA: 0x000023C1 File Offset: 0x000005C1
		// (set) Token: 0x06000081 RID: 129 RVA: 0x000023D3 File Offset: 0x000005D3
		public ParticleSystemSortMode sortMode
		{
			get
			{
				return ParticleSystemRenderer.get_sortModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ParticleSystemRenderer.set_sortModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000082 RID: 130 RVA: 0x000023E6 File Offset: 0x000005E6
		// (set) Token: 0x06000083 RID: 131 RVA: 0x000023F8 File Offset: 0x000005F8
		public float lengthScale
		{
			get
			{
				return ParticleSystemRenderer.get_lengthScaleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ParticleSystemRenderer.set_lengthScaleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000084 RID: 132 RVA: 0x0000240B File Offset: 0x0000060B
		// (set) Token: 0x06000085 RID: 133 RVA: 0x0000241D File Offset: 0x0000061D
		public float velocityScale
		{
			get
			{
				return ParticleSystemRenderer.get_velocityScaleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ParticleSystemRenderer.set_velocityScaleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000086 RID: 134 RVA: 0x00002430 File Offset: 0x00000630
		// (set) Token: 0x06000087 RID: 135 RVA: 0x00002442 File Offset: 0x00000642
		public float cameraVelocityScale
		{
			get
			{
				return ParticleSystemRenderer.get_cameraVelocityScaleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ParticleSystemRenderer.set_cameraVelocityScaleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000088 RID: 136 RVA: 0x00002455 File Offset: 0x00000655
		// (set) Token: 0x06000089 RID: 137 RVA: 0x00002467 File Offset: 0x00000667
		public float normalDirection
		{
			get
			{
				return ParticleSystemRenderer.get_normalDirectionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ParticleSystemRenderer.set_normalDirectionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600008A RID: 138 RVA: 0x0000247A File Offset: 0x0000067A
		// (set) Token: 0x0600008B RID: 139 RVA: 0x0000248C File Offset: 0x0000068C
		public float shadowBias
		{
			get
			{
				return ParticleSystemRenderer.get_shadowBiasDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ParticleSystemRenderer.set_shadowBiasDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600008C RID: 140 RVA: 0x0000249F File Offset: 0x0000069F
		// (set) Token: 0x0600008D RID: 141 RVA: 0x000024B1 File Offset: 0x000006B1
		public float sortingFudge
		{
			get
			{
				return ParticleSystemRenderer.get_sortingFudgeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ParticleSystemRenderer.set_sortingFudgeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600008E RID: 142 RVA: 0x000024C4 File Offset: 0x000006C4
		// (set) Token: 0x0600008F RID: 143 RVA: 0x000024D6 File Offset: 0x000006D6
		public float minParticleSize
		{
			get
			{
				return ParticleSystemRenderer.get_minParticleSizeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ParticleSystemRenderer.set_minParticleSizeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000090 RID: 144 RVA: 0x000024E9 File Offset: 0x000006E9
		// (set) Token: 0x06000091 RID: 145 RVA: 0x000024FB File Offset: 0x000006FB
		public float maxParticleSize
		{
			get
			{
				return ParticleSystemRenderer.get_maxParticleSizeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ParticleSystemRenderer.set_maxParticleSizeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000092 RID: 146 RVA: 0x000046A4 File Offset: 0x000028A4
		// (set) Token: 0x06000093 RID: 147 RVA: 0x0000250E File Offset: 0x0000070E
		public Vector3 pivot
		{
			get
			{
				Vector3 vector;
				this.get_pivot_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_pivot_Injected(ref value);
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000094 RID: 148 RVA: 0x000046BC File Offset: 0x000028BC
		// (set) Token: 0x06000095 RID: 149 RVA: 0x00002518 File Offset: 0x00000718
		public Vector3 flip
		{
			get
			{
				Vector3 vector;
				this.get_flip_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_flip_Injected(ref value);
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000096 RID: 150 RVA: 0x00002522 File Offset: 0x00000722
		// (set) Token: 0x06000097 RID: 151 RVA: 0x00002534 File Offset: 0x00000734
		public SpriteMaskInteraction maskInteraction
		{
			get
			{
				return ParticleSystemRenderer.get_maskInteractionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ParticleSystemRenderer.set_maskInteractionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000098 RID: 152 RVA: 0x000046D4 File Offset: 0x000028D4
		// (set) Token: 0x06000099 RID: 153 RVA: 0x00002547 File Offset: 0x00000747
		public Material trailMaterial
		{
			get
			{
				IntPtr intPtr = ParticleSystemRenderer.get_trailMaterialDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				ParticleSystemRenderer.set_trailMaterialDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002F RID: 47
		// (set) Token: 0x0600009A RID: 154 RVA: 0x0000255F File Offset: 0x0000075F
		public Material oldTrailMaterial
		{
			set
			{
				ParticleSystemRenderer.set_oldTrailMaterialDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600009B RID: 155 RVA: 0x00002577 File Offset: 0x00000777
		// (set) Token: 0x0600009C RID: 156 RVA: 0x00002589 File Offset: 0x00000789
		public bool enableGPUInstancing
		{
			get
			{
				return ParticleSystemRenderer.get_enableGPUInstancingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ParticleSystemRenderer.set_enableGPUInstancingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600009D RID: 157 RVA: 0x0000259C File Offset: 0x0000079C
		// (set) Token: 0x0600009E RID: 158 RVA: 0x000025AE File Offset: 0x000007AE
		public bool allowRoll
		{
			get
			{
				return ParticleSystemRenderer.get_allowRollDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ParticleSystemRenderer.set_allowRollDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600009F RID: 159 RVA: 0x000025C1 File Offset: 0x000007C1
		// (set) Token: 0x060000A0 RID: 160 RVA: 0x000025D3 File Offset: 0x000007D3
		public bool freeformStretching
		{
			get
			{
				return ParticleSystemRenderer.get_freeformStretchingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ParticleSystemRenderer.set_freeformStretchingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x000025E6 File Offset: 0x000007E6
		// (set) Token: 0x060000A2 RID: 162 RVA: 0x000025F8 File Offset: 0x000007F8
		public bool rotateWithStretchDirection
		{
			get
			{
				return ParticleSystemRenderer.get_rotateWithStretchDirectionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ParticleSystemRenderer.set_rotateWithStretchDirectionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x00004700 File Offset: 0x00002900
		// (set) Token: 0x060000A4 RID: 164 RVA: 0x0000260B File Offset: 0x0000080B
		public Mesh mesh
		{
			get
			{
				IntPtr intPtr = ParticleSystemRenderer.get_meshDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				ParticleSystemRenderer.set_meshDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00002623 File Offset: 0x00000823
		public void SetMeshes(Il2CppReferenceArray<Mesh> meshes, int size)
		{
			ParticleSystemRenderer.SetMeshesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(meshes), size);
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x0000263C File Offset: 0x0000083C
		public void SetMeshes(Il2CppReferenceArray<Mesh> meshes)
		{
			this.SetMeshes(meshes, meshes.Length);
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x0000264E File Offset: 0x0000084E
		public int meshCount
		{
			get
			{
				return ParticleSystemRenderer.get_meshCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00002660 File Offset: 0x00000860
		public void BakeMesh(Mesh mesh, [Optional] bool useTransform)
		{
			this.BakeMesh(mesh, Camera.main, useTransform);
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00002671 File Offset: 0x00000871
		public void BakeMesh(Mesh mesh, Camera camera, [Optional] bool useTransform)
		{
			ParticleSystemRenderer.BakeMeshDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(mesh), IL2CPP.Il2CppObjectBaseToPtr(camera), useTransform);
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00002690 File Offset: 0x00000890
		public void BakeTrailsMesh(Mesh mesh, [Optional] bool useTransform)
		{
			this.BakeTrailsMesh(mesh, Camera.main, useTransform);
		}

		// Token: 0x060000AB RID: 171 RVA: 0x000026A1 File Offset: 0x000008A1
		public void BakeTrailsMesh(Mesh mesh, Camera camera, [Optional] bool useTransform)
		{
			ParticleSystemRenderer.BakeTrailsMeshDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(mesh), IL2CPP.Il2CppObjectBaseToPtr(camera), useTransform);
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000AC RID: 172 RVA: 0x000026C0 File Offset: 0x000008C0
		public int activeVertexStreamsCount
		{
			get
			{
				return ParticleSystemRenderer.get_activeVertexStreamsCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x060000AD RID: 173 RVA: 0x000026D2 File Offset: 0x000008D2
		public void SetActiveVertexStreams(List<ParticleSystemVertexStream> streams)
		{
			ParticleSystemRenderer.SetActiveVertexStreamsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(streams));
		}

		// Token: 0x060000AE RID: 174 RVA: 0x000026EA File Offset: 0x000008EA
		public void GetActiveVertexStreams(List<ParticleSystemVertexStream> streams)
		{
			ParticleSystemRenderer.GetActiveVertexStreamsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(streams));
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00002702 File Offset: 0x00000902
		public void get_pivot_Injected(out Vector3 ret)
		{
			ParticleSystemRenderer.get_pivot_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00002715 File Offset: 0x00000915
		public void set_pivot_Injected(ref Vector3 value)
		{
			ParticleSystemRenderer.set_pivot_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00002728 File Offset: 0x00000928
		public void get_flip_Injected(out Vector3 ret)
		{
			ParticleSystemRenderer.get_flip_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x0000273B File Offset: 0x0000093B
		public void set_flip_Injected(ref Vector3 value)
		{
			ParticleSystemRenderer.set_flip_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeMethodInfoPtr_GetMeshes_Public_Int32_Il2CppReferenceArray_1_Mesh_0;

		// Token: 0x04000043 RID: 67
		private static readonly ParticleSystemRenderer.get_alignmentDelegate get_alignmentDelegateField;

		// Token: 0x04000044 RID: 68
		private static readonly ParticleSystemRenderer.set_alignmentDelegate set_alignmentDelegateField;

		// Token: 0x04000045 RID: 69
		private static readonly ParticleSystemRenderer.get_renderModeDelegate get_renderModeDelegateField;

		// Token: 0x04000046 RID: 70
		private static readonly ParticleSystemRenderer.set_renderModeDelegate set_renderModeDelegateField;

		// Token: 0x04000047 RID: 71
		private static readonly ParticleSystemRenderer.get_sortModeDelegate get_sortModeDelegateField;

		// Token: 0x04000048 RID: 72
		private static readonly ParticleSystemRenderer.set_sortModeDelegate set_sortModeDelegateField;

		// Token: 0x04000049 RID: 73
		private static readonly ParticleSystemRenderer.get_lengthScaleDelegate get_lengthScaleDelegateField;

		// Token: 0x0400004A RID: 74
		private static readonly ParticleSystemRenderer.set_lengthScaleDelegate set_lengthScaleDelegateField;

		// Token: 0x0400004B RID: 75
		private static readonly ParticleSystemRenderer.get_velocityScaleDelegate get_velocityScaleDelegateField;

		// Token: 0x0400004C RID: 76
		private static readonly ParticleSystemRenderer.set_velocityScaleDelegate set_velocityScaleDelegateField;

		// Token: 0x0400004D RID: 77
		private static readonly ParticleSystemRenderer.get_cameraVelocityScaleDelegate get_cameraVelocityScaleDelegateField;

		// Token: 0x0400004E RID: 78
		private static readonly ParticleSystemRenderer.set_cameraVelocityScaleDelegate set_cameraVelocityScaleDelegateField;

		// Token: 0x0400004F RID: 79
		private static readonly ParticleSystemRenderer.get_normalDirectionDelegate get_normalDirectionDelegateField;

		// Token: 0x04000050 RID: 80
		private static readonly ParticleSystemRenderer.set_normalDirectionDelegate set_normalDirectionDelegateField;

		// Token: 0x04000051 RID: 81
		private static readonly ParticleSystemRenderer.get_shadowBiasDelegate get_shadowBiasDelegateField;

		// Token: 0x04000052 RID: 82
		private static readonly ParticleSystemRenderer.set_shadowBiasDelegate set_shadowBiasDelegateField;

		// Token: 0x04000053 RID: 83
		private static readonly ParticleSystemRenderer.get_sortingFudgeDelegate get_sortingFudgeDelegateField;

		// Token: 0x04000054 RID: 84
		private static readonly ParticleSystemRenderer.set_sortingFudgeDelegate set_sortingFudgeDelegateField;

		// Token: 0x04000055 RID: 85
		private static readonly ParticleSystemRenderer.get_minParticleSizeDelegate get_minParticleSizeDelegateField;

		// Token: 0x04000056 RID: 86
		private static readonly ParticleSystemRenderer.set_minParticleSizeDelegate set_minParticleSizeDelegateField;

		// Token: 0x04000057 RID: 87
		private static readonly ParticleSystemRenderer.get_maxParticleSizeDelegate get_maxParticleSizeDelegateField;

		// Token: 0x04000058 RID: 88
		private static readonly ParticleSystemRenderer.set_maxParticleSizeDelegate set_maxParticleSizeDelegateField;

		// Token: 0x04000059 RID: 89
		private static readonly ParticleSystemRenderer.get_maskInteractionDelegate get_maskInteractionDelegateField;

		// Token: 0x0400005A RID: 90
		private static readonly ParticleSystemRenderer.set_maskInteractionDelegate set_maskInteractionDelegateField;

		// Token: 0x0400005B RID: 91
		private static readonly ParticleSystemRenderer.get_trailMaterialDelegate get_trailMaterialDelegateField;

		// Token: 0x0400005C RID: 92
		private static readonly ParticleSystemRenderer.set_trailMaterialDelegate set_trailMaterialDelegateField;

		// Token: 0x0400005D RID: 93
		private static readonly ParticleSystemRenderer.set_oldTrailMaterialDelegate set_oldTrailMaterialDelegateField;

		// Token: 0x0400005E RID: 94
		private static readonly ParticleSystemRenderer.get_enableGPUInstancingDelegate get_enableGPUInstancingDelegateField;

		// Token: 0x0400005F RID: 95
		private static readonly ParticleSystemRenderer.set_enableGPUInstancingDelegate set_enableGPUInstancingDelegateField;

		// Token: 0x04000060 RID: 96
		private static readonly ParticleSystemRenderer.get_allowRollDelegate get_allowRollDelegateField;

		// Token: 0x04000061 RID: 97
		private static readonly ParticleSystemRenderer.set_allowRollDelegate set_allowRollDelegateField;

		// Token: 0x04000062 RID: 98
		private static readonly ParticleSystemRenderer.get_freeformStretchingDelegate get_freeformStretchingDelegateField;

		// Token: 0x04000063 RID: 99
		private static readonly ParticleSystemRenderer.set_freeformStretchingDelegate set_freeformStretchingDelegateField;

		// Token: 0x04000064 RID: 100
		private static readonly ParticleSystemRenderer.get_rotateWithStretchDirectionDelegate get_rotateWithStretchDirectionDelegateField;

		// Token: 0x04000065 RID: 101
		private static readonly ParticleSystemRenderer.set_rotateWithStretchDirectionDelegate set_rotateWithStretchDirectionDelegateField;

		// Token: 0x04000066 RID: 102
		private static readonly ParticleSystemRenderer.get_meshDelegate get_meshDelegateField;

		// Token: 0x04000067 RID: 103
		private static readonly ParticleSystemRenderer.set_meshDelegate set_meshDelegateField;

		// Token: 0x04000068 RID: 104
		private static readonly ParticleSystemRenderer.SetMeshesDelegate SetMeshesDelegateField;

		// Token: 0x04000069 RID: 105
		private static readonly ParticleSystemRenderer.get_meshCountDelegate get_meshCountDelegateField;

		// Token: 0x0400006A RID: 106
		private static readonly ParticleSystemRenderer.BakeMeshDelegate BakeMeshDelegateField;

		// Token: 0x0400006B RID: 107
		private static readonly ParticleSystemRenderer.BakeTrailsMeshDelegate BakeTrailsMeshDelegateField;

		// Token: 0x0400006C RID: 108
		private static readonly ParticleSystemRenderer.get_activeVertexStreamsCountDelegate get_activeVertexStreamsCountDelegateField;

		// Token: 0x0400006D RID: 109
		private static readonly ParticleSystemRenderer.SetActiveVertexStreamsDelegate SetActiveVertexStreamsDelegateField;

		// Token: 0x0400006E RID: 110
		private static readonly ParticleSystemRenderer.GetActiveVertexStreamsDelegate GetActiveVertexStreamsDelegateField;

		// Token: 0x0400006F RID: 111
		private static readonly ParticleSystemRenderer.get_pivot_InjectedDelegate get_pivot_InjectedDelegateField;

		// Token: 0x04000070 RID: 112
		private static readonly ParticleSystemRenderer.set_pivot_InjectedDelegate set_pivot_InjectedDelegateField;

		// Token: 0x04000071 RID: 113
		private static readonly ParticleSystemRenderer.get_flip_InjectedDelegate get_flip_InjectedDelegateField;

		// Token: 0x04000072 RID: 114
		private static readonly ParticleSystemRenderer.set_flip_InjectedDelegate set_flip_InjectedDelegateField;

		// Token: 0x0200005D RID: 93
		// (Invoke) Token: 0x06000182 RID: 386
		private delegate ParticleSystemRenderSpace get_alignmentDelegate(IntPtr @this);

		// Token: 0x0200005E RID: 94
		// (Invoke) Token: 0x06000184 RID: 388
		private delegate void set_alignmentDelegate(IntPtr @this, ParticleSystemRenderSpace value);

		// Token: 0x0200005F RID: 95
		// (Invoke) Token: 0x06000186 RID: 390
		private delegate ParticleSystemRenderMode get_renderModeDelegate(IntPtr @this);

		// Token: 0x02000060 RID: 96
		// (Invoke) Token: 0x06000188 RID: 392
		private delegate void set_renderModeDelegate(IntPtr @this, ParticleSystemRenderMode value);

		// Token: 0x02000061 RID: 97
		// (Invoke) Token: 0x0600018A RID: 394
		private delegate ParticleSystemSortMode get_sortModeDelegate(IntPtr @this);

		// Token: 0x02000062 RID: 98
		// (Invoke) Token: 0x0600018C RID: 396
		private delegate void set_sortModeDelegate(IntPtr @this, ParticleSystemSortMode value);

		// Token: 0x02000063 RID: 99
		// (Invoke) Token: 0x0600018E RID: 398
		private delegate float get_lengthScaleDelegate(IntPtr @this);

		// Token: 0x02000064 RID: 100
		// (Invoke) Token: 0x06000190 RID: 400
		private delegate void set_lengthScaleDelegate(IntPtr @this, float value);

		// Token: 0x02000065 RID: 101
		// (Invoke) Token: 0x06000192 RID: 402
		private delegate float get_velocityScaleDelegate(IntPtr @this);

		// Token: 0x02000066 RID: 102
		// (Invoke) Token: 0x06000194 RID: 404
		private delegate void set_velocityScaleDelegate(IntPtr @this, float value);

		// Token: 0x02000067 RID: 103
		// (Invoke) Token: 0x06000196 RID: 406
		private delegate float get_cameraVelocityScaleDelegate(IntPtr @this);

		// Token: 0x02000068 RID: 104
		// (Invoke) Token: 0x06000198 RID: 408
		private delegate void set_cameraVelocityScaleDelegate(IntPtr @this, float value);

		// Token: 0x02000069 RID: 105
		// (Invoke) Token: 0x0600019A RID: 410
		private delegate float get_normalDirectionDelegate(IntPtr @this);

		// Token: 0x0200006A RID: 106
		// (Invoke) Token: 0x0600019C RID: 412
		private delegate void set_normalDirectionDelegate(IntPtr @this, float value);

		// Token: 0x0200006B RID: 107
		// (Invoke) Token: 0x0600019E RID: 414
		private delegate float get_shadowBiasDelegate(IntPtr @this);

		// Token: 0x0200006C RID: 108
		// (Invoke) Token: 0x060001A0 RID: 416
		private delegate void set_shadowBiasDelegate(IntPtr @this, float value);

		// Token: 0x0200006D RID: 109
		// (Invoke) Token: 0x060001A2 RID: 418
		private delegate float get_sortingFudgeDelegate(IntPtr @this);

		// Token: 0x0200006E RID: 110
		// (Invoke) Token: 0x060001A4 RID: 420
		private delegate void set_sortingFudgeDelegate(IntPtr @this, float value);

		// Token: 0x0200006F RID: 111
		// (Invoke) Token: 0x060001A6 RID: 422
		private delegate float get_minParticleSizeDelegate(IntPtr @this);

		// Token: 0x02000070 RID: 112
		// (Invoke) Token: 0x060001A8 RID: 424
		private delegate void set_minParticleSizeDelegate(IntPtr @this, float value);

		// Token: 0x02000071 RID: 113
		// (Invoke) Token: 0x060001AA RID: 426
		private delegate float get_maxParticleSizeDelegate(IntPtr @this);

		// Token: 0x02000072 RID: 114
		// (Invoke) Token: 0x060001AC RID: 428
		private delegate void set_maxParticleSizeDelegate(IntPtr @this, float value);

		// Token: 0x02000073 RID: 115
		// (Invoke) Token: 0x060001AE RID: 430
		private delegate SpriteMaskInteraction get_maskInteractionDelegate(IntPtr @this);

		// Token: 0x02000074 RID: 116
		// (Invoke) Token: 0x060001B0 RID: 432
		private delegate void set_maskInteractionDelegate(IntPtr @this, SpriteMaskInteraction value);

		// Token: 0x02000075 RID: 117
		// (Invoke) Token: 0x060001B2 RID: 434
		private delegate IntPtr get_trailMaterialDelegate(IntPtr @this);

		// Token: 0x02000076 RID: 118
		// (Invoke) Token: 0x060001B4 RID: 436
		private delegate void set_trailMaterialDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000077 RID: 119
		// (Invoke) Token: 0x060001B6 RID: 438
		private delegate void set_oldTrailMaterialDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000078 RID: 120
		// (Invoke) Token: 0x060001B8 RID: 440
		private delegate bool get_enableGPUInstancingDelegate(IntPtr @this);

		// Token: 0x02000079 RID: 121
		// (Invoke) Token: 0x060001BA RID: 442
		private delegate void set_enableGPUInstancingDelegate(IntPtr @this, bool value);

		// Token: 0x0200007A RID: 122
		// (Invoke) Token: 0x060001BC RID: 444
		private delegate bool get_allowRollDelegate(IntPtr @this);

		// Token: 0x0200007B RID: 123
		// (Invoke) Token: 0x060001BE RID: 446
		private delegate void set_allowRollDelegate(IntPtr @this, bool value);

		// Token: 0x0200007C RID: 124
		// (Invoke) Token: 0x060001C0 RID: 448
		private delegate bool get_freeformStretchingDelegate(IntPtr @this);

		// Token: 0x0200007D RID: 125
		// (Invoke) Token: 0x060001C2 RID: 450
		private delegate void set_freeformStretchingDelegate(IntPtr @this, bool value);

		// Token: 0x0200007E RID: 126
		// (Invoke) Token: 0x060001C4 RID: 452
		private delegate bool get_rotateWithStretchDirectionDelegate(IntPtr @this);

		// Token: 0x0200007F RID: 127
		// (Invoke) Token: 0x060001C6 RID: 454
		private delegate void set_rotateWithStretchDirectionDelegate(IntPtr @this, bool value);

		// Token: 0x02000080 RID: 128
		// (Invoke) Token: 0x060001C8 RID: 456
		private delegate IntPtr get_meshDelegate(IntPtr @this);

		// Token: 0x02000081 RID: 129
		// (Invoke) Token: 0x060001CA RID: 458
		private delegate void set_meshDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000082 RID: 130
		// (Invoke) Token: 0x060001CC RID: 460
		private delegate void SetMeshesDelegate(IntPtr @this, IntPtr meshes, int size);

		// Token: 0x02000083 RID: 131
		// (Invoke) Token: 0x060001CE RID: 462
		private delegate int get_meshCountDelegate(IntPtr @this);

		// Token: 0x02000084 RID: 132
		// (Invoke) Token: 0x060001D0 RID: 464
		private delegate void BakeMeshDelegate(IntPtr @this, IntPtr mesh, IntPtr camera, bool useTransform);

		// Token: 0x02000085 RID: 133
		// (Invoke) Token: 0x060001D2 RID: 466
		private delegate void BakeTrailsMeshDelegate(IntPtr @this, IntPtr mesh, IntPtr camera, bool useTransform);

		// Token: 0x02000086 RID: 134
		// (Invoke) Token: 0x060001D4 RID: 468
		private delegate int get_activeVertexStreamsCountDelegate(IntPtr @this);

		// Token: 0x02000087 RID: 135
		// (Invoke) Token: 0x060001D6 RID: 470
		private delegate void SetActiveVertexStreamsDelegate(IntPtr @this, IntPtr streams);

		// Token: 0x02000088 RID: 136
		// (Invoke) Token: 0x060001D8 RID: 472
		private delegate void GetActiveVertexStreamsDelegate(IntPtr @this, IntPtr streams);

		// Token: 0x02000089 RID: 137
		// (Invoke) Token: 0x060001DA RID: 474
		private delegate void get_pivot_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200008A RID: 138
		// (Invoke) Token: 0x060001DC RID: 476
		private delegate void set_pivot_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200008B RID: 139
		// (Invoke) Token: 0x060001DE RID: 478
		private delegate void get_flip_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200008C RID: 140
		// (Invoke) Token: 0x060001E0 RID: 480
		private delegate void set_flip_InjectedDelegate(IntPtr @this, IntPtr value);
	}
}
