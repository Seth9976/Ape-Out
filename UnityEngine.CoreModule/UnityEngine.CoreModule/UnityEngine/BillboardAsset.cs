using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine
{
	// Token: 0x02000205 RID: 517
	public sealed class BillboardAsset : Object
	{
		// Token: 0x0600209F RID: 8351 RVA: 0x00010F86 File Offset: 0x0000F186
		public static void Internal_Create(BillboardAsset obj)
		{
			BillboardAsset.Internal_CreateDelegateField(IL2CPP.Il2CppObjectBaseToPtr(obj));
		}

		// Token: 0x1700068F RID: 1679
		// (get) Token: 0x060020A0 RID: 8352 RVA: 0x00010F98 File Offset: 0x0000F198
		// (set) Token: 0x060020A1 RID: 8353 RVA: 0x00010FAA File Offset: 0x0000F1AA
		public float width
		{
			get
			{
				return BillboardAsset.get_widthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				BillboardAsset.set_widthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000690 RID: 1680
		// (get) Token: 0x060020A2 RID: 8354 RVA: 0x00010FBD File Offset: 0x0000F1BD
		// (set) Token: 0x060020A3 RID: 8355 RVA: 0x00010FCF File Offset: 0x0000F1CF
		public float height
		{
			get
			{
				return BillboardAsset.get_heightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				BillboardAsset.set_heightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000691 RID: 1681
		// (get) Token: 0x060020A4 RID: 8356 RVA: 0x00010FE2 File Offset: 0x0000F1E2
		// (set) Token: 0x060020A5 RID: 8357 RVA: 0x00010FF4 File Offset: 0x0000F1F4
		public float bottom
		{
			get
			{
				return BillboardAsset.get_bottomDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				BillboardAsset.set_bottomDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000692 RID: 1682
		// (get) Token: 0x060020A6 RID: 8358 RVA: 0x00011007 File Offset: 0x0000F207
		public int imageCount
		{
			get
			{
				return BillboardAsset.get_imageCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000693 RID: 1683
		// (get) Token: 0x060020A7 RID: 8359 RVA: 0x00011019 File Offset: 0x0000F219
		public int vertexCount
		{
			get
			{
				return BillboardAsset.get_vertexCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000694 RID: 1684
		// (get) Token: 0x060020A8 RID: 8360 RVA: 0x0001102B File Offset: 0x0000F22B
		public int indexCount
		{
			get
			{
				return BillboardAsset.get_indexCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000695 RID: 1685
		// (get) Token: 0x060020A9 RID: 8361 RVA: 0x00075190 File Offset: 0x00073390
		// (set) Token: 0x060020AA RID: 8362 RVA: 0x0001103D File Offset: 0x0000F23D
		public Material material
		{
			get
			{
				IntPtr intPtr = BillboardAsset.get_materialDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				BillboardAsset.set_materialDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x060020AB RID: 8363 RVA: 0x000751BC File Offset: 0x000733BC
		public void GetImageTexCoords(List<Vector4> imageTexCoords)
		{
			bool flag = imageTexCoords == null;
			if (flag)
			{
				throw new ArgumentNullException("imageTexCoords");
			}
			this.GetImageTexCoordsInternal(imageTexCoords);
		}

		// Token: 0x060020AC RID: 8364 RVA: 0x000751E8 File Offset: 0x000733E8
		public Il2CppStructArray<Vector4> GetImageTexCoords()
		{
			IntPtr intPtr = BillboardAsset.GetImageTexCoordsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector4>>(intPtr2) : null;
		}

		// Token: 0x060020AD RID: 8365 RVA: 0x00011055 File Offset: 0x0000F255
		public void GetImageTexCoordsInternal(Object list)
		{
			BillboardAsset.GetImageTexCoordsInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(list));
		}

		// Token: 0x060020AE RID: 8366 RVA: 0x00075214 File Offset: 0x00073414
		public void SetImageTexCoords(List<Vector4> imageTexCoords)
		{
			bool flag = imageTexCoords == null;
			if (flag)
			{
				throw new ArgumentNullException("imageTexCoords");
			}
			this.SetImageTexCoordsInternalList(imageTexCoords);
		}

		// Token: 0x060020AF RID: 8367 RVA: 0x0001106D File Offset: 0x0000F26D
		public void SetImageTexCoords(Il2CppStructArray<Vector4> imageTexCoords)
		{
			BillboardAsset.SetImageTexCoordsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(imageTexCoords));
		}

		// Token: 0x060020B0 RID: 8368 RVA: 0x00011085 File Offset: 0x0000F285
		public void SetImageTexCoordsInternalList(Object list)
		{
			BillboardAsset.SetImageTexCoordsInternalListDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(list));
		}

		// Token: 0x060020B1 RID: 8369 RVA: 0x00075240 File Offset: 0x00073440
		public void GetVertices(List<Vector2> vertices)
		{
			bool flag = vertices == null;
			if (flag)
			{
				throw new ArgumentNullException("vertices");
			}
			this.GetVerticesInternal(vertices);
		}

		// Token: 0x060020B2 RID: 8370 RVA: 0x0007526C File Offset: 0x0007346C
		public Il2CppStructArray<Vector2> GetVertices()
		{
			IntPtr intPtr = BillboardAsset.GetVerticesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
		}

		// Token: 0x060020B3 RID: 8371 RVA: 0x0001109D File Offset: 0x0000F29D
		public void GetVerticesInternal(Object list)
		{
			BillboardAsset.GetVerticesInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(list));
		}

		// Token: 0x060020B4 RID: 8372 RVA: 0x00075298 File Offset: 0x00073498
		public void SetVertices(List<Vector2> vertices)
		{
			bool flag = vertices == null;
			if (flag)
			{
				throw new ArgumentNullException("vertices");
			}
			this.SetVerticesInternalList(vertices);
		}

		// Token: 0x060020B5 RID: 8373 RVA: 0x000110B5 File Offset: 0x0000F2B5
		public void SetVertices(Il2CppStructArray<Vector2> vertices)
		{
			BillboardAsset.SetVerticesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(vertices));
		}

		// Token: 0x060020B6 RID: 8374 RVA: 0x000110CD File Offset: 0x0000F2CD
		public void SetVerticesInternalList(Object list)
		{
			BillboardAsset.SetVerticesInternalListDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(list));
		}

		// Token: 0x060020B7 RID: 8375 RVA: 0x000752C4 File Offset: 0x000734C4
		public void GetIndices(List<ushort> indices)
		{
			bool flag = indices == null;
			if (flag)
			{
				throw new ArgumentNullException("indices");
			}
			this.GetIndicesInternal(indices);
		}

		// Token: 0x060020B8 RID: 8376 RVA: 0x000752F0 File Offset: 0x000734F0
		public Il2CppStructArray<ushort> GetIndices()
		{
			IntPtr intPtr = BillboardAsset.GetIndicesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ushort>>(intPtr2) : null;
		}

		// Token: 0x060020B9 RID: 8377 RVA: 0x000110E5 File Offset: 0x0000F2E5
		public void GetIndicesInternal(Object list)
		{
			BillboardAsset.GetIndicesInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(list));
		}

		// Token: 0x060020BA RID: 8378 RVA: 0x0007531C File Offset: 0x0007351C
		public void SetIndices(List<ushort> indices)
		{
			bool flag = indices == null;
			if (flag)
			{
				throw new ArgumentNullException("indices");
			}
			this.SetIndicesInternalList(indices);
		}

		// Token: 0x060020BB RID: 8379 RVA: 0x000110FD File Offset: 0x0000F2FD
		public void SetIndices(Il2CppStructArray<ushort> indices)
		{
			BillboardAsset.SetIndicesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(indices));
		}

		// Token: 0x060020BC RID: 8380 RVA: 0x00011115 File Offset: 0x0000F315
		public void SetIndicesInternalList(Object list)
		{
			BillboardAsset.SetIndicesInternalListDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(list));
		}

		// Token: 0x060020BD RID: 8381 RVA: 0x0001112D File Offset: 0x0000F32D
		public void MakeMaterialProperties(MaterialPropertyBlock properties, Camera camera)
		{
			BillboardAsset.MakeMaterialPropertiesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(properties), IL2CPP.Il2CppObjectBaseToPtr(camera));
		}

		// Token: 0x04001A8A RID: 6794
		private static readonly BillboardAsset.Internal_CreateDelegate Internal_CreateDelegateField = IL2CPP.ResolveICall<BillboardAsset.Internal_CreateDelegate>("UnityEngine.BillboardAsset::Internal_Create");

		// Token: 0x04001A8B RID: 6795
		private static readonly BillboardAsset.get_widthDelegate get_widthDelegateField = IL2CPP.ResolveICall<BillboardAsset.get_widthDelegate>("UnityEngine.BillboardAsset::get_width");

		// Token: 0x04001A8C RID: 6796
		private static readonly BillboardAsset.set_widthDelegate set_widthDelegateField = IL2CPP.ResolveICall<BillboardAsset.set_widthDelegate>("UnityEngine.BillboardAsset::set_width");

		// Token: 0x04001A8D RID: 6797
		private static readonly BillboardAsset.get_heightDelegate get_heightDelegateField = IL2CPP.ResolveICall<BillboardAsset.get_heightDelegate>("UnityEngine.BillboardAsset::get_height");

		// Token: 0x04001A8E RID: 6798
		private static readonly BillboardAsset.set_heightDelegate set_heightDelegateField = IL2CPP.ResolveICall<BillboardAsset.set_heightDelegate>("UnityEngine.BillboardAsset::set_height");

		// Token: 0x04001A8F RID: 6799
		private static readonly BillboardAsset.get_bottomDelegate get_bottomDelegateField = IL2CPP.ResolveICall<BillboardAsset.get_bottomDelegate>("UnityEngine.BillboardAsset::get_bottom");

		// Token: 0x04001A90 RID: 6800
		private static readonly BillboardAsset.set_bottomDelegate set_bottomDelegateField = IL2CPP.ResolveICall<BillboardAsset.set_bottomDelegate>("UnityEngine.BillboardAsset::set_bottom");

		// Token: 0x04001A91 RID: 6801
		private static readonly BillboardAsset.get_imageCountDelegate get_imageCountDelegateField = IL2CPP.ResolveICall<BillboardAsset.get_imageCountDelegate>("UnityEngine.BillboardAsset::get_imageCount");

		// Token: 0x04001A92 RID: 6802
		private static readonly BillboardAsset.get_vertexCountDelegate get_vertexCountDelegateField = IL2CPP.ResolveICall<BillboardAsset.get_vertexCountDelegate>("UnityEngine.BillboardAsset::get_vertexCount");

		// Token: 0x04001A93 RID: 6803
		private static readonly BillboardAsset.get_indexCountDelegate get_indexCountDelegateField = IL2CPP.ResolveICall<BillboardAsset.get_indexCountDelegate>("UnityEngine.BillboardAsset::get_indexCount");

		// Token: 0x04001A94 RID: 6804
		private static readonly BillboardAsset.get_materialDelegate get_materialDelegateField = IL2CPP.ResolveICall<BillboardAsset.get_materialDelegate>("UnityEngine.BillboardAsset::get_material");

		// Token: 0x04001A95 RID: 6805
		private static readonly BillboardAsset.set_materialDelegate set_materialDelegateField = IL2CPP.ResolveICall<BillboardAsset.set_materialDelegate>("UnityEngine.BillboardAsset::set_material");

		// Token: 0x04001A96 RID: 6806
		private static readonly BillboardAsset.GetImageTexCoordsDelegate GetImageTexCoordsDelegateField = IL2CPP.ResolveICall<BillboardAsset.GetImageTexCoordsDelegate>("UnityEngine.BillboardAsset::GetImageTexCoords");

		// Token: 0x04001A97 RID: 6807
		private static readonly BillboardAsset.GetImageTexCoordsInternalDelegate GetImageTexCoordsInternalDelegateField = IL2CPP.ResolveICall<BillboardAsset.GetImageTexCoordsInternalDelegate>("UnityEngine.BillboardAsset::GetImageTexCoordsInternal");

		// Token: 0x04001A98 RID: 6808
		private static readonly BillboardAsset.SetImageTexCoordsDelegate SetImageTexCoordsDelegateField = IL2CPP.ResolveICall<BillboardAsset.SetImageTexCoordsDelegate>("UnityEngine.BillboardAsset::SetImageTexCoords");

		// Token: 0x04001A99 RID: 6809
		private static readonly BillboardAsset.SetImageTexCoordsInternalListDelegate SetImageTexCoordsInternalListDelegateField = IL2CPP.ResolveICall<BillboardAsset.SetImageTexCoordsInternalListDelegate>("UnityEngine.BillboardAsset::SetImageTexCoordsInternalList");

		// Token: 0x04001A9A RID: 6810
		private static readonly BillboardAsset.GetVerticesDelegate GetVerticesDelegateField = IL2CPP.ResolveICall<BillboardAsset.GetVerticesDelegate>("UnityEngine.BillboardAsset::GetVertices");

		// Token: 0x04001A9B RID: 6811
		private static readonly BillboardAsset.GetVerticesInternalDelegate GetVerticesInternalDelegateField = IL2CPP.ResolveICall<BillboardAsset.GetVerticesInternalDelegate>("UnityEngine.BillboardAsset::GetVerticesInternal");

		// Token: 0x04001A9C RID: 6812
		private static readonly BillboardAsset.SetVerticesDelegate SetVerticesDelegateField = IL2CPP.ResolveICall<BillboardAsset.SetVerticesDelegate>("UnityEngine.BillboardAsset::SetVertices");

		// Token: 0x04001A9D RID: 6813
		private static readonly BillboardAsset.SetVerticesInternalListDelegate SetVerticesInternalListDelegateField = IL2CPP.ResolveICall<BillboardAsset.SetVerticesInternalListDelegate>("UnityEngine.BillboardAsset::SetVerticesInternalList");

		// Token: 0x04001A9E RID: 6814
		private static readonly BillboardAsset.GetIndicesDelegate GetIndicesDelegateField = IL2CPP.ResolveICall<BillboardAsset.GetIndicesDelegate>("UnityEngine.BillboardAsset::GetIndices");

		// Token: 0x04001A9F RID: 6815
		private static readonly BillboardAsset.GetIndicesInternalDelegate GetIndicesInternalDelegateField = IL2CPP.ResolveICall<BillboardAsset.GetIndicesInternalDelegate>("UnityEngine.BillboardAsset::GetIndicesInternal");

		// Token: 0x04001AA0 RID: 6816
		private static readonly BillboardAsset.SetIndicesDelegate SetIndicesDelegateField = IL2CPP.ResolveICall<BillboardAsset.SetIndicesDelegate>("UnityEngine.BillboardAsset::SetIndices");

		// Token: 0x04001AA1 RID: 6817
		private static readonly BillboardAsset.SetIndicesInternalListDelegate SetIndicesInternalListDelegateField = IL2CPP.ResolveICall<BillboardAsset.SetIndicesInternalListDelegate>("UnityEngine.BillboardAsset::SetIndicesInternalList");

		// Token: 0x04001AA2 RID: 6818
		private static readonly BillboardAsset.MakeMaterialPropertiesDelegate MakeMaterialPropertiesDelegateField = IL2CPP.ResolveICall<BillboardAsset.MakeMaterialPropertiesDelegate>("UnityEngine.BillboardAsset::MakeMaterialProperties");

		// Token: 0x02000AE7 RID: 2791
		// (Invoke) Token: 0x06003430 RID: 13360
		private delegate void Internal_CreateDelegate(IntPtr obj);

		// Token: 0x02000AE8 RID: 2792
		// (Invoke) Token: 0x06003432 RID: 13362
		private delegate float get_widthDelegate(IntPtr @this);

		// Token: 0x02000AE9 RID: 2793
		// (Invoke) Token: 0x06003434 RID: 13364
		private delegate void set_widthDelegate(IntPtr @this, float value);

		// Token: 0x02000AEA RID: 2794
		// (Invoke) Token: 0x06003436 RID: 13366
		private delegate float get_heightDelegate(IntPtr @this);

		// Token: 0x02000AEB RID: 2795
		// (Invoke) Token: 0x06003438 RID: 13368
		private delegate void set_heightDelegate(IntPtr @this, float value);

		// Token: 0x02000AEC RID: 2796
		// (Invoke) Token: 0x0600343A RID: 13370
		private delegate float get_bottomDelegate(IntPtr @this);

		// Token: 0x02000AED RID: 2797
		// (Invoke) Token: 0x0600343C RID: 13372
		private delegate void set_bottomDelegate(IntPtr @this, float value);

		// Token: 0x02000AEE RID: 2798
		// (Invoke) Token: 0x0600343E RID: 13374
		private delegate int get_imageCountDelegate(IntPtr @this);

		// Token: 0x02000AEF RID: 2799
		// (Invoke) Token: 0x06003440 RID: 13376
		private delegate int get_vertexCountDelegate(IntPtr @this);

		// Token: 0x02000AF0 RID: 2800
		// (Invoke) Token: 0x06003442 RID: 13378
		private delegate int get_indexCountDelegate(IntPtr @this);

		// Token: 0x02000AF1 RID: 2801
		// (Invoke) Token: 0x06003444 RID: 13380
		private delegate IntPtr get_materialDelegate(IntPtr @this);

		// Token: 0x02000AF2 RID: 2802
		// (Invoke) Token: 0x06003446 RID: 13382
		private delegate void set_materialDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000AF3 RID: 2803
		// (Invoke) Token: 0x06003448 RID: 13384
		private delegate IntPtr GetImageTexCoordsDelegate(IntPtr @this);

		// Token: 0x02000AF4 RID: 2804
		// (Invoke) Token: 0x0600344A RID: 13386
		private delegate void GetImageTexCoordsInternalDelegate(IntPtr @this, IntPtr list);

		// Token: 0x02000AF5 RID: 2805
		// (Invoke) Token: 0x0600344C RID: 13388
		private delegate void SetImageTexCoordsDelegate(IntPtr @this, IntPtr imageTexCoords);

		// Token: 0x02000AF6 RID: 2806
		// (Invoke) Token: 0x0600344E RID: 13390
		private delegate void SetImageTexCoordsInternalListDelegate(IntPtr @this, IntPtr list);

		// Token: 0x02000AF7 RID: 2807
		// (Invoke) Token: 0x06003450 RID: 13392
		private delegate IntPtr GetVerticesDelegate(IntPtr @this);

		// Token: 0x02000AF8 RID: 2808
		// (Invoke) Token: 0x06003452 RID: 13394
		private delegate void GetVerticesInternalDelegate(IntPtr @this, IntPtr list);

		// Token: 0x02000AF9 RID: 2809
		// (Invoke) Token: 0x06003454 RID: 13396
		private delegate void SetVerticesDelegate(IntPtr @this, IntPtr vertices);

		// Token: 0x02000AFA RID: 2810
		// (Invoke) Token: 0x06003456 RID: 13398
		private delegate void SetVerticesInternalListDelegate(IntPtr @this, IntPtr list);

		// Token: 0x02000AFB RID: 2811
		// (Invoke) Token: 0x06003458 RID: 13400
		private delegate IntPtr GetIndicesDelegate(IntPtr @this);

		// Token: 0x02000AFC RID: 2812
		// (Invoke) Token: 0x0600345A RID: 13402
		private delegate void GetIndicesInternalDelegate(IntPtr @this, IntPtr list);

		// Token: 0x02000AFD RID: 2813
		// (Invoke) Token: 0x0600345C RID: 13404
		private delegate void SetIndicesDelegate(IntPtr @this, IntPtr indices);

		// Token: 0x02000AFE RID: 2814
		// (Invoke) Token: 0x0600345E RID: 13406
		private delegate void SetIndicesInternalListDelegate(IntPtr @this, IntPtr list);

		// Token: 0x02000AFF RID: 2815
		// (Invoke) Token: 0x06003460 RID: 13408
		private delegate void MakeMaterialPropertiesDelegate(IntPtr @this, IntPtr properties, IntPtr camera);
	}
}
