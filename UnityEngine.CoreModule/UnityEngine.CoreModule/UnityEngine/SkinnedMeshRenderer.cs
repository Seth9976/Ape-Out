using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x02000233 RID: 563
	public class SkinnedMeshRenderer : Renderer
	{
		// Token: 0x170006B5 RID: 1717
		// (get) Token: 0x06002136 RID: 8502 RVA: 0x0001183C File Offset: 0x0000FA3C
		// (set) Token: 0x06002137 RID: 8503 RVA: 0x0001184E File Offset: 0x0000FA4E
		public SkinQuality quality
		{
			get
			{
				return SkinnedMeshRenderer.get_qualityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SkinnedMeshRenderer.set_qualityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170006B6 RID: 1718
		// (get) Token: 0x06002138 RID: 8504 RVA: 0x00011861 File Offset: 0x0000FA61
		// (set) Token: 0x06002139 RID: 8505 RVA: 0x00011873 File Offset: 0x0000FA73
		public bool updateWhenOffscreen
		{
			get
			{
				return SkinnedMeshRenderer.get_updateWhenOffscreenDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SkinnedMeshRenderer.set_updateWhenOffscreenDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170006B7 RID: 1719
		// (get) Token: 0x0600213A RID: 8506 RVA: 0x00011886 File Offset: 0x0000FA86
		// (set) Token: 0x0600213B RID: 8507 RVA: 0x00011898 File Offset: 0x0000FA98
		public bool forceMatrixRecalculationPerRender
		{
			get
			{
				return SkinnedMeshRenderer.get_forceMatrixRecalculationPerRenderDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SkinnedMeshRenderer.set_forceMatrixRecalculationPerRenderDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170006B8 RID: 1720
		// (get) Token: 0x0600213C RID: 8508 RVA: 0x00075CC8 File Offset: 0x00073EC8
		// (set) Token: 0x0600213D RID: 8509 RVA: 0x000118AB File Offset: 0x0000FAAB
		public Transform rootBone
		{
			get
			{
				IntPtr intPtr = SkinnedMeshRenderer.get_rootBoneDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				SkinnedMeshRenderer.set_rootBoneDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006B9 RID: 1721
		// (get) Token: 0x0600213E RID: 8510 RVA: 0x00075CF4 File Offset: 0x00073EF4
		// (set) Token: 0x0600213F RID: 8511 RVA: 0x000118C3 File Offset: 0x0000FAC3
		public Il2CppReferenceArray<Transform> bones
		{
			get
			{
				IntPtr intPtr = SkinnedMeshRenderer.get_bonesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				SkinnedMeshRenderer.set_bonesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006BA RID: 1722
		// (get) Token: 0x06002140 RID: 8512 RVA: 0x00075D20 File Offset: 0x00073F20
		// (set) Token: 0x06002141 RID: 8513 RVA: 0x000118DB File Offset: 0x0000FADB
		public Mesh sharedMesh
		{
			get
			{
				IntPtr intPtr = SkinnedMeshRenderer.get_sharedMeshDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				SkinnedMeshRenderer.set_sharedMeshDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006BB RID: 1723
		// (get) Token: 0x06002142 RID: 8514 RVA: 0x000118F3 File Offset: 0x0000FAF3
		// (set) Token: 0x06002143 RID: 8515 RVA: 0x00011905 File Offset: 0x0000FB05
		public bool skinnedMotionVectors
		{
			get
			{
				return SkinnedMeshRenderer.get_skinnedMotionVectorsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SkinnedMeshRenderer.set_skinnedMotionVectorsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x06002144 RID: 8516 RVA: 0x00011918 File Offset: 0x0000FB18
		public float GetBlendShapeWeight(int index)
		{
			return SkinnedMeshRenderer.GetBlendShapeWeightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index);
		}

		// Token: 0x06002145 RID: 8517 RVA: 0x0001192B File Offset: 0x0000FB2B
		public void SetBlendShapeWeight(int index, float value)
		{
			SkinnedMeshRenderer.SetBlendShapeWeightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index, value);
		}

		// Token: 0x06002146 RID: 8518 RVA: 0x0001193F File Offset: 0x0000FB3F
		public void BakeMesh(Mesh mesh)
		{
			this.BakeMesh(mesh, false);
		}

		// Token: 0x06002147 RID: 8519 RVA: 0x0001194B File Offset: 0x0000FB4B
		public void BakeMesh(Mesh mesh, bool useScale)
		{
			SkinnedMeshRenderer.BakeMeshDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(mesh), useScale);
		}

		// Token: 0x06002148 RID: 8520 RVA: 0x00075D4C File Offset: 0x00073F4C
		public Bounds GetLocalAABB()
		{
			Bounds bounds;
			this.GetLocalAABB_Injected(out bounds);
			return bounds;
		}

		// Token: 0x06002149 RID: 8521 RVA: 0x00011964 File Offset: 0x0000FB64
		public void SetLocalAABB(Bounds b)
		{
			this.SetLocalAABB_Injected(ref b);
		}

		// Token: 0x170006BC RID: 1724
		// (get) Token: 0x0600214A RID: 8522 RVA: 0x00075D64 File Offset: 0x00073F64
		// (set) Token: 0x0600214B RID: 8523 RVA: 0x0001196E File Offset: 0x0000FB6E
		public Bounds localBounds
		{
			get
			{
				return this.GetLocalAABB();
			}
			set
			{
				this.SetLocalAABB(value);
			}
		}

		// Token: 0x0600214C RID: 8524 RVA: 0x00011979 File Offset: 0x0000FB79
		public void GetLocalAABB_Injected(out Bounds ret)
		{
			SkinnedMeshRenderer.GetLocalAABB_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0600214D RID: 8525 RVA: 0x0001198C File Offset: 0x0000FB8C
		public void SetLocalAABB_Injected(ref Bounds b)
		{
			SkinnedMeshRenderer.SetLocalAABB_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref b);
		}

		// Token: 0x04001B68 RID: 7016
		private static readonly SkinnedMeshRenderer.get_qualityDelegate get_qualityDelegateField = IL2CPP.ResolveICall<SkinnedMeshRenderer.get_qualityDelegate>("UnityEngine.SkinnedMeshRenderer::get_quality");

		// Token: 0x04001B69 RID: 7017
		private static readonly SkinnedMeshRenderer.set_qualityDelegate set_qualityDelegateField = IL2CPP.ResolveICall<SkinnedMeshRenderer.set_qualityDelegate>("UnityEngine.SkinnedMeshRenderer::set_quality");

		// Token: 0x04001B6A RID: 7018
		private static readonly SkinnedMeshRenderer.get_updateWhenOffscreenDelegate get_updateWhenOffscreenDelegateField = IL2CPP.ResolveICall<SkinnedMeshRenderer.get_updateWhenOffscreenDelegate>("UnityEngine.SkinnedMeshRenderer::get_updateWhenOffscreen");

		// Token: 0x04001B6B RID: 7019
		private static readonly SkinnedMeshRenderer.set_updateWhenOffscreenDelegate set_updateWhenOffscreenDelegateField = IL2CPP.ResolveICall<SkinnedMeshRenderer.set_updateWhenOffscreenDelegate>("UnityEngine.SkinnedMeshRenderer::set_updateWhenOffscreen");

		// Token: 0x04001B6C RID: 7020
		private static readonly SkinnedMeshRenderer.get_forceMatrixRecalculationPerRenderDelegate get_forceMatrixRecalculationPerRenderDelegateField = IL2CPP.ResolveICall<SkinnedMeshRenderer.get_forceMatrixRecalculationPerRenderDelegate>("UnityEngine.SkinnedMeshRenderer::get_forceMatrixRecalculationPerRender");

		// Token: 0x04001B6D RID: 7021
		private static readonly SkinnedMeshRenderer.set_forceMatrixRecalculationPerRenderDelegate set_forceMatrixRecalculationPerRenderDelegateField = IL2CPP.ResolveICall<SkinnedMeshRenderer.set_forceMatrixRecalculationPerRenderDelegate>("UnityEngine.SkinnedMeshRenderer::set_forceMatrixRecalculationPerRender");

		// Token: 0x04001B6E RID: 7022
		private static readonly SkinnedMeshRenderer.get_rootBoneDelegate get_rootBoneDelegateField = IL2CPP.ResolveICall<SkinnedMeshRenderer.get_rootBoneDelegate>("UnityEngine.SkinnedMeshRenderer::get_rootBone");

		// Token: 0x04001B6F RID: 7023
		private static readonly SkinnedMeshRenderer.set_rootBoneDelegate set_rootBoneDelegateField = IL2CPP.ResolveICall<SkinnedMeshRenderer.set_rootBoneDelegate>("UnityEngine.SkinnedMeshRenderer::set_rootBone");

		// Token: 0x04001B70 RID: 7024
		private static readonly SkinnedMeshRenderer.get_bonesDelegate get_bonesDelegateField = IL2CPP.ResolveICall<SkinnedMeshRenderer.get_bonesDelegate>("UnityEngine.SkinnedMeshRenderer::get_bones");

		// Token: 0x04001B71 RID: 7025
		private static readonly SkinnedMeshRenderer.set_bonesDelegate set_bonesDelegateField = IL2CPP.ResolveICall<SkinnedMeshRenderer.set_bonesDelegate>("UnityEngine.SkinnedMeshRenderer::set_bones");

		// Token: 0x04001B72 RID: 7026
		private static readonly SkinnedMeshRenderer.get_sharedMeshDelegate get_sharedMeshDelegateField = IL2CPP.ResolveICall<SkinnedMeshRenderer.get_sharedMeshDelegate>("UnityEngine.SkinnedMeshRenderer::get_sharedMesh");

		// Token: 0x04001B73 RID: 7027
		private static readonly SkinnedMeshRenderer.set_sharedMeshDelegate set_sharedMeshDelegateField = IL2CPP.ResolveICall<SkinnedMeshRenderer.set_sharedMeshDelegate>("UnityEngine.SkinnedMeshRenderer::set_sharedMesh");

		// Token: 0x04001B74 RID: 7028
		private static readonly SkinnedMeshRenderer.get_skinnedMotionVectorsDelegate get_skinnedMotionVectorsDelegateField = IL2CPP.ResolveICall<SkinnedMeshRenderer.get_skinnedMotionVectorsDelegate>("UnityEngine.SkinnedMeshRenderer::get_skinnedMotionVectors");

		// Token: 0x04001B75 RID: 7029
		private static readonly SkinnedMeshRenderer.set_skinnedMotionVectorsDelegate set_skinnedMotionVectorsDelegateField = IL2CPP.ResolveICall<SkinnedMeshRenderer.set_skinnedMotionVectorsDelegate>("UnityEngine.SkinnedMeshRenderer::set_skinnedMotionVectors");

		// Token: 0x04001B76 RID: 7030
		private static readonly SkinnedMeshRenderer.GetBlendShapeWeightDelegate GetBlendShapeWeightDelegateField = IL2CPP.ResolveICall<SkinnedMeshRenderer.GetBlendShapeWeightDelegate>("UnityEngine.SkinnedMeshRenderer::GetBlendShapeWeight");

		// Token: 0x04001B77 RID: 7031
		private static readonly SkinnedMeshRenderer.SetBlendShapeWeightDelegate SetBlendShapeWeightDelegateField = IL2CPP.ResolveICall<SkinnedMeshRenderer.SetBlendShapeWeightDelegate>("UnityEngine.SkinnedMeshRenderer::SetBlendShapeWeight");

		// Token: 0x04001B78 RID: 7032
		private static readonly SkinnedMeshRenderer.BakeMeshDelegate BakeMeshDelegateField = IL2CPP.ResolveICall<SkinnedMeshRenderer.BakeMeshDelegate>("UnityEngine.SkinnedMeshRenderer::BakeMesh");

		// Token: 0x04001B79 RID: 7033
		private static readonly SkinnedMeshRenderer.GetLocalAABB_InjectedDelegate GetLocalAABB_InjectedDelegateField = IL2CPP.ResolveICall<SkinnedMeshRenderer.GetLocalAABB_InjectedDelegate>("UnityEngine.SkinnedMeshRenderer::GetLocalAABB_Injected");

		// Token: 0x04001B7A RID: 7034
		private static readonly SkinnedMeshRenderer.SetLocalAABB_InjectedDelegate SetLocalAABB_InjectedDelegateField = IL2CPP.ResolveICall<SkinnedMeshRenderer.SetLocalAABB_InjectedDelegate>("UnityEngine.SkinnedMeshRenderer::SetLocalAABB_Injected");

		// Token: 0x02000B44 RID: 2884
		// (Invoke) Token: 0x060034E8 RID: 13544
		private delegate SkinQuality get_qualityDelegate(IntPtr @this);

		// Token: 0x02000B45 RID: 2885
		// (Invoke) Token: 0x060034EA RID: 13546
		private delegate void set_qualityDelegate(IntPtr @this, SkinQuality value);

		// Token: 0x02000B46 RID: 2886
		// (Invoke) Token: 0x060034EC RID: 13548
		private delegate bool get_updateWhenOffscreenDelegate(IntPtr @this);

		// Token: 0x02000B47 RID: 2887
		// (Invoke) Token: 0x060034EE RID: 13550
		private delegate void set_updateWhenOffscreenDelegate(IntPtr @this, bool value);

		// Token: 0x02000B48 RID: 2888
		// (Invoke) Token: 0x060034F0 RID: 13552
		private delegate bool get_forceMatrixRecalculationPerRenderDelegate(IntPtr @this);

		// Token: 0x02000B49 RID: 2889
		// (Invoke) Token: 0x060034F2 RID: 13554
		private delegate void set_forceMatrixRecalculationPerRenderDelegate(IntPtr @this, bool value);

		// Token: 0x02000B4A RID: 2890
		// (Invoke) Token: 0x060034F4 RID: 13556
		private delegate IntPtr get_rootBoneDelegate(IntPtr @this);

		// Token: 0x02000B4B RID: 2891
		// (Invoke) Token: 0x060034F6 RID: 13558
		private delegate void set_rootBoneDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000B4C RID: 2892
		// (Invoke) Token: 0x060034F8 RID: 13560
		private delegate IntPtr get_bonesDelegate(IntPtr @this);

		// Token: 0x02000B4D RID: 2893
		// (Invoke) Token: 0x060034FA RID: 13562
		private delegate void set_bonesDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000B4E RID: 2894
		// (Invoke) Token: 0x060034FC RID: 13564
		private delegate IntPtr get_sharedMeshDelegate(IntPtr @this);

		// Token: 0x02000B4F RID: 2895
		// (Invoke) Token: 0x060034FE RID: 13566
		private delegate void set_sharedMeshDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000B50 RID: 2896
		// (Invoke) Token: 0x06003500 RID: 13568
		private delegate bool get_skinnedMotionVectorsDelegate(IntPtr @this);

		// Token: 0x02000B51 RID: 2897
		// (Invoke) Token: 0x06003502 RID: 13570
		private delegate void set_skinnedMotionVectorsDelegate(IntPtr @this, bool value);

		// Token: 0x02000B52 RID: 2898
		// (Invoke) Token: 0x06003504 RID: 13572
		private delegate float GetBlendShapeWeightDelegate(IntPtr @this, int index);

		// Token: 0x02000B53 RID: 2899
		// (Invoke) Token: 0x06003506 RID: 13574
		private delegate void SetBlendShapeWeightDelegate(IntPtr @this, int index, float value);

		// Token: 0x02000B54 RID: 2900
		// (Invoke) Token: 0x06003508 RID: 13576
		private delegate void BakeMeshDelegate(IntPtr @this, IntPtr mesh, bool useScale);

		// Token: 0x02000B55 RID: 2901
		// (Invoke) Token: 0x0600350A RID: 13578
		private delegate void GetLocalAABB_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000B56 RID: 2902
		// (Invoke) Token: 0x0600350C RID: 13580
		private delegate void SetLocalAABB_InjectedDelegate(IntPtr @this, IntPtr b);
	}
}
