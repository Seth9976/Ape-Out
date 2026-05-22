using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine
{
	// Token: 0x02000013 RID: 19
	public sealed class PolygonCollider2D : Collider2D
	{
		// Token: 0x06000326 RID: 806 RVA: 0x0000CE00 File Offset: 0x0000B000
		// Note: this type is marked as 'beforefieldinit'.
		static PolygonCollider2D()
		{
			Il2CppClassPointerStore<PolygonCollider2D>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Physics2DModule.dll", "UnityEngine", "PolygonCollider2D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PolygonCollider2D>.NativeClassPtr);
			PolygonCollider2D.NativeMethodInfoPtr_get_points_Public_get_Il2CppStructArray_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonCollider2D>.NativeClassPtr, 100663448);
			PolygonCollider2D.get_autoTilingDelegateField = IL2CPP.ResolveICall<PolygonCollider2D.get_autoTilingDelegate>("UnityEngine.PolygonCollider2D::get_autoTiling");
			PolygonCollider2D.set_autoTilingDelegateField = IL2CPP.ResolveICall<PolygonCollider2D.set_autoTilingDelegate>("UnityEngine.PolygonCollider2D::set_autoTiling");
			PolygonCollider2D.GetTotalPointCountDelegateField = IL2CPP.ResolveICall<PolygonCollider2D.GetTotalPointCountDelegate>("UnityEngine.PolygonCollider2D::GetTotalPointCount");
			PolygonCollider2D.set_pointsDelegateField = IL2CPP.ResolveICall<PolygonCollider2D.set_pointsDelegate>("UnityEngine.PolygonCollider2D::set_points");
			PolygonCollider2D.get_pathCountDelegateField = IL2CPP.ResolveICall<PolygonCollider2D.get_pathCountDelegate>("UnityEngine.PolygonCollider2D::get_pathCount");
			PolygonCollider2D.set_pathCountDelegateField = IL2CPP.ResolveICall<PolygonCollider2D.set_pathCountDelegate>("UnityEngine.PolygonCollider2D::set_pathCount");
			PolygonCollider2D.GetPath_InternalDelegateField = IL2CPP.ResolveICall<PolygonCollider2D.GetPath_InternalDelegate>("UnityEngine.PolygonCollider2D::GetPath_Internal");
			PolygonCollider2D.SetPath_InternalDelegateField = IL2CPP.ResolveICall<PolygonCollider2D.SetPath_InternalDelegate>("UnityEngine.PolygonCollider2D::SetPath_Internal");
			PolygonCollider2D.GetPathList_InternalDelegateField = IL2CPP.ResolveICall<PolygonCollider2D.GetPathList_InternalDelegate>("UnityEngine.PolygonCollider2D::GetPathList_Internal");
			PolygonCollider2D.SetPathList_InternalDelegateField = IL2CPP.ResolveICall<PolygonCollider2D.SetPathList_InternalDelegate>("UnityEngine.PolygonCollider2D::SetPathList_Internal");
			PolygonCollider2D.CreatePrimitive_Internal_InjectedDelegateField = IL2CPP.ResolveICall<PolygonCollider2D.CreatePrimitive_Internal_InjectedDelegate>("UnityEngine.PolygonCollider2D::CreatePrimitive_Internal_Injected");
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000327 RID: 807 RVA: 0x0000CEEC File Offset: 0x0000B0EC
		// (set) Token: 0x0600032C RID: 812 RVA: 0x00003467 File Offset: 0x00001667
		public unsafe Il2CppStructArray<Vector2> points
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513495, XrefRangeEnd = 513499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonCollider2D.NativeMethodInfoPtr_get_points_Public_get_Il2CppStructArray_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr3) : null;
			}
			set
			{
				PolygonCollider2D.set_pointsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000328 RID: 808 RVA: 0x00003427 File Offset: 0x00001627
		public PolygonCollider2D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000329 RID: 809 RVA: 0x00003430 File Offset: 0x00001630
		// (set) Token: 0x0600032A RID: 810 RVA: 0x00003442 File Offset: 0x00001642
		public bool autoTiling
		{
			get
			{
				return PolygonCollider2D.get_autoTilingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				PolygonCollider2D.set_autoTilingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x0600032B RID: 811 RVA: 0x00003455 File Offset: 0x00001655
		public int GetTotalPointCount()
		{
			return PolygonCollider2D.GetTotalPointCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x0600032D RID: 813 RVA: 0x0000347F File Offset: 0x0000167F
		// (set) Token: 0x0600032E RID: 814 RVA: 0x00003491 File Offset: 0x00001691
		public int pathCount
		{
			get
			{
				return PolygonCollider2D.get_pathCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				PolygonCollider2D.set_pathCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x0600032F RID: 815 RVA: 0x0000CF2C File Offset: 0x0000B12C
		public Il2CppStructArray<Vector2> GetPath(int index)
		{
			bool flag = index >= this.pathCount;
			if (flag)
			{
				throw new ArgumentOutOfRangeException(String.Format("Path {0} does not exist.", index));
			}
			bool flag2 = index < 0;
			if (flag2)
			{
				throw new ArgumentOutOfRangeException(String.Format("Path {0} does not exist; negative path index is invalid.", index));
			}
			return this.GetPath_Internal(index);
		}

		// Token: 0x06000330 RID: 816 RVA: 0x0000CF8C File Offset: 0x0000B18C
		public Il2CppStructArray<Vector2> GetPath_Internal(int index)
		{
			IntPtr intPtr = PolygonCollider2D.GetPath_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
		}

		// Token: 0x06000331 RID: 817 RVA: 0x0000CFBC File Offset: 0x0000B1BC
		public void SetPath(int index, Il2CppStructArray<Vector2> points)
		{
			bool flag = index < 0;
			if (flag)
			{
				throw new ArgumentOutOfRangeException(String.Format("Negative path index {0} is invalid.", index));
			}
			this.SetPath_Internal(index, points);
		}

		// Token: 0x06000332 RID: 818 RVA: 0x000034A4 File Offset: 0x000016A4
		public void SetPath_Internal(int index, Il2CppStructArray<Vector2> points)
		{
			PolygonCollider2D.SetPath_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index, IL2CPP.Il2CppObjectBaseToPtr(points));
		}

		// Token: 0x06000333 RID: 819 RVA: 0x0000CFF4 File Offset: 0x0000B1F4
		public int GetPath(int index, List<Vector2> points)
		{
			bool flag = index < 0 || index >= this.pathCount;
			if (flag)
			{
				throw new ArgumentOutOfRangeException("index", String.Format("Path index {0} must be in the range of 0 to {1}.", index, this.pathCount - 1));
			}
			bool flag2 = points == null;
			if (flag2)
			{
				throw new ArgumentNullException("points");
			}
			return this.GetPathList_Internal(index, points);
		}

		// Token: 0x06000334 RID: 820 RVA: 0x000034BD File Offset: 0x000016BD
		public int GetPathList_Internal(int index, List<Vector2> points)
		{
			return PolygonCollider2D.GetPathList_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index, IL2CPP.Il2CppObjectBaseToPtr(points));
		}

		// Token: 0x06000335 RID: 821 RVA: 0x0000D060 File Offset: 0x0000B260
		public void SetPath(int index, List<Vector2> points)
		{
			bool flag = index < 0;
			if (flag)
			{
				throw new ArgumentOutOfRangeException(String.Format("Negative path index {0} is invalid.", index));
			}
			this.SetPathList_Internal(index, points);
		}

		// Token: 0x06000336 RID: 822 RVA: 0x000034D6 File Offset: 0x000016D6
		public void SetPathList_Internal(int index, List<Vector2> points)
		{
			PolygonCollider2D.SetPathList_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index, IL2CPP.Il2CppObjectBaseToPtr(points));
		}

		// Token: 0x06000337 RID: 823 RVA: 0x000034EF File Offset: 0x000016EF
		public void CreatePrimitive(int sides)
		{
			this.CreatePrimitive(sides, Vector2.one, Vector2.zero);
		}

		// Token: 0x06000338 RID: 824 RVA: 0x00003504 File Offset: 0x00001704
		public void CreatePrimitive(int sides, Vector2 scale)
		{
			this.CreatePrimitive(sides, scale, Vector2.zero);
		}

		// Token: 0x06000339 RID: 825 RVA: 0x0000D098 File Offset: 0x0000B298
		public void CreatePrimitive(int sides, Vector2 scale, Vector2 offset)
		{
			bool flag = sides < 3;
			if (flag)
			{
				Debug.LogWarning("Cannot create a 2D polygon primitive collider with less than two sides.", this);
			}
			else
			{
				bool flag2 = scale.x <= 0f || scale.y <= 0f;
				if (flag2)
				{
					Debug.LogWarning("Cannot create a 2D polygon primitive collider with an axis scale less than or equal to zero.", this);
				}
				else
				{
					this.CreatePrimitive_Internal(sides, scale, offset, true);
				}
			}
		}

		// Token: 0x0600033A RID: 826 RVA: 0x00003515 File Offset: 0x00001715
		public void CreatePrimitive_Internal(int sides, Vector2 scale, Vector2 offset, bool autoRefresh)
		{
			this.CreatePrimitive_Internal_Injected(sides, ref scale, ref offset, autoRefresh);
		}

		// Token: 0x0600033B RID: 827 RVA: 0x00003524 File Offset: 0x00001724
		public void CreatePrimitive_Internal_Injected(int sides, ref Vector2 scale, ref Vector2 offset, bool autoRefresh)
		{
			PolygonCollider2D.CreatePrimitive_Internal_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), sides, ref scale, ref offset, autoRefresh);
		}

		// Token: 0x040001CE RID: 462
		private static readonly IntPtr NativeMethodInfoPtr_get_points_Public_get_Il2CppStructArray_1_Vector2_0;

		// Token: 0x040001CF RID: 463
		private static readonly PolygonCollider2D.get_autoTilingDelegate get_autoTilingDelegateField;

		// Token: 0x040001D0 RID: 464
		private static readonly PolygonCollider2D.set_autoTilingDelegate set_autoTilingDelegateField;

		// Token: 0x040001D1 RID: 465
		private static readonly PolygonCollider2D.GetTotalPointCountDelegate GetTotalPointCountDelegateField;

		// Token: 0x040001D2 RID: 466
		private static readonly PolygonCollider2D.set_pointsDelegate set_pointsDelegateField;

		// Token: 0x040001D3 RID: 467
		private static readonly PolygonCollider2D.get_pathCountDelegate get_pathCountDelegateField;

		// Token: 0x040001D4 RID: 468
		private static readonly PolygonCollider2D.set_pathCountDelegate set_pathCountDelegateField;

		// Token: 0x040001D5 RID: 469
		private static readonly PolygonCollider2D.GetPath_InternalDelegate GetPath_InternalDelegateField;

		// Token: 0x040001D6 RID: 470
		private static readonly PolygonCollider2D.SetPath_InternalDelegate SetPath_InternalDelegateField;

		// Token: 0x040001D7 RID: 471
		private static readonly PolygonCollider2D.GetPathList_InternalDelegate GetPathList_InternalDelegateField;

		// Token: 0x040001D8 RID: 472
		private static readonly PolygonCollider2D.SetPathList_InternalDelegate SetPathList_InternalDelegateField;

		// Token: 0x040001D9 RID: 473
		private static readonly PolygonCollider2D.CreatePrimitive_Internal_InjectedDelegate CreatePrimitive_Internal_InjectedDelegateField;

		// Token: 0x02000109 RID: 265
		// (Invoke) Token: 0x060005EC RID: 1516
		private delegate bool get_autoTilingDelegate(IntPtr @this);

		// Token: 0x0200010A RID: 266
		// (Invoke) Token: 0x060005EE RID: 1518
		private delegate void set_autoTilingDelegate(IntPtr @this, bool value);

		// Token: 0x0200010B RID: 267
		// (Invoke) Token: 0x060005F0 RID: 1520
		private delegate int GetTotalPointCountDelegate(IntPtr @this);

		// Token: 0x0200010C RID: 268
		// (Invoke) Token: 0x060005F2 RID: 1522
		private delegate void set_pointsDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200010D RID: 269
		// (Invoke) Token: 0x060005F4 RID: 1524
		private delegate int get_pathCountDelegate(IntPtr @this);

		// Token: 0x0200010E RID: 270
		// (Invoke) Token: 0x060005F6 RID: 1526
		private delegate void set_pathCountDelegate(IntPtr @this, int value);

		// Token: 0x0200010F RID: 271
		// (Invoke) Token: 0x060005F8 RID: 1528
		private delegate IntPtr GetPath_InternalDelegate(IntPtr @this, int index);

		// Token: 0x02000110 RID: 272
		// (Invoke) Token: 0x060005FA RID: 1530
		private delegate void SetPath_InternalDelegate(IntPtr @this, int index, IntPtr points);

		// Token: 0x02000111 RID: 273
		// (Invoke) Token: 0x060005FC RID: 1532
		private delegate int GetPathList_InternalDelegate(IntPtr @this, int index, IntPtr points);

		// Token: 0x02000112 RID: 274
		// (Invoke) Token: 0x060005FE RID: 1534
		private delegate void SetPathList_InternalDelegate(IntPtr @this, int index, IntPtr points);

		// Token: 0x02000113 RID: 275
		// (Invoke) Token: 0x06000600 RID: 1536
		private delegate void CreatePrimitive_Internal_InjectedDelegate(IntPtr @this, int sides, IntPtr scale, IntPtr offset, bool autoRefresh);
	}
}
