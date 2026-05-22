using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000012 RID: 18
	public sealed class BoxCollider2D : Collider2D
	{
		// Token: 0x0600031C RID: 796 RVA: 0x0000CC48 File Offset: 0x0000AE48
		// Note: this type is marked as 'beforefieldinit'.
		static BoxCollider2D()
		{
			Il2CppClassPointerStore<BoxCollider2D>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Physics2DModule.dll", "UnityEngine", "BoxCollider2D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoxCollider2D>.NativeClassPtr);
			BoxCollider2D.NativeMethodInfoPtr_get_size_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxCollider2D>.NativeClassPtr, 100663444);
			BoxCollider2D.NativeMethodInfoPtr_set_size_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxCollider2D>.NativeClassPtr, 100663445);
			BoxCollider2D.NativeMethodInfoPtr_get_size_Injected_Private_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxCollider2D>.NativeClassPtr, 100663446);
			BoxCollider2D.NativeMethodInfoPtr_set_size_Injected_Private_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxCollider2D>.NativeClassPtr, 100663447);
			BoxCollider2D.get_edgeRadiusDelegateField = IL2CPP.ResolveICall<BoxCollider2D.get_edgeRadiusDelegate>("UnityEngine.BoxCollider2D::get_edgeRadius");
			BoxCollider2D.set_edgeRadiusDelegateField = IL2CPP.ResolveICall<BoxCollider2D.set_edgeRadiusDelegate>("UnityEngine.BoxCollider2D::set_edgeRadius");
			BoxCollider2D.get_autoTilingDelegateField = IL2CPP.ResolveICall<BoxCollider2D.get_autoTilingDelegate>("UnityEngine.BoxCollider2D::get_autoTiling");
			BoxCollider2D.set_autoTilingDelegateField = IL2CPP.ResolveICall<BoxCollider2D.set_autoTilingDelegate>("UnityEngine.BoxCollider2D::set_autoTiling");
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x0600031D RID: 797 RVA: 0x0000CD04 File Offset: 0x0000AF04
		// (set) Token: 0x0600031E RID: 798 RVA: 0x0000CD40 File Offset: 0x0000AF40
		public unsafe Vector2 size
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 513479, RefRangeEnd = 513484, XrefRangeStart = 513477, XrefRangeEnd = 513479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxCollider2D.NativeMethodInfoPtr_get_size_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 513486, RefRangeEnd = 513487, XrefRangeStart = 513484, XrefRangeEnd = 513486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxCollider2D.NativeMethodInfoPtr_set_size_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600031F RID: 799 RVA: 0x0000CD80 File Offset: 0x0000AF80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513487, XrefRangeEnd = 513491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_size_Injected(out Vector2 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxCollider2D.NativeMethodInfoPtr_get_size_Injected_Private_Void_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000320 RID: 800 RVA: 0x0000CDC0 File Offset: 0x0000AFC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513491, XrefRangeEnd = 513495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_size_Injected(ref Vector2 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxCollider2D.NativeMethodInfoPtr_set_size_Injected_Private_Void_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000321 RID: 801 RVA: 0x000033D4 File Offset: 0x000015D4
		public BoxCollider2D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000322 RID: 802 RVA: 0x000033DD File Offset: 0x000015DD
		// (set) Token: 0x06000323 RID: 803 RVA: 0x000033EF File Offset: 0x000015EF
		public float edgeRadius
		{
			get
			{
				return BoxCollider2D.get_edgeRadiusDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				BoxCollider2D.set_edgeRadiusDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000324 RID: 804 RVA: 0x00003402 File Offset: 0x00001602
		// (set) Token: 0x06000325 RID: 805 RVA: 0x00003414 File Offset: 0x00001614
		public bool autoTiling
		{
			get
			{
				return BoxCollider2D.get_autoTilingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				BoxCollider2D.set_autoTilingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x040001C6 RID: 454
		private static readonly IntPtr NativeMethodInfoPtr_get_size_Public_get_Vector2_0;

		// Token: 0x040001C7 RID: 455
		private static readonly IntPtr NativeMethodInfoPtr_set_size_Public_set_Void_Vector2_0;

		// Token: 0x040001C8 RID: 456
		private static readonly IntPtr NativeMethodInfoPtr_get_size_Injected_Private_Void_byref_Vector2_0;

		// Token: 0x040001C9 RID: 457
		private static readonly IntPtr NativeMethodInfoPtr_set_size_Injected_Private_Void_byref_Vector2_0;

		// Token: 0x040001CA RID: 458
		private static readonly BoxCollider2D.get_edgeRadiusDelegate get_edgeRadiusDelegateField;

		// Token: 0x040001CB RID: 459
		private static readonly BoxCollider2D.set_edgeRadiusDelegate set_edgeRadiusDelegateField;

		// Token: 0x040001CC RID: 460
		private static readonly BoxCollider2D.get_autoTilingDelegate get_autoTilingDelegateField;

		// Token: 0x040001CD RID: 461
		private static readonly BoxCollider2D.set_autoTilingDelegate set_autoTilingDelegateField;

		// Token: 0x02000105 RID: 261
		// (Invoke) Token: 0x060005E4 RID: 1508
		private delegate float get_edgeRadiusDelegate(IntPtr @this);

		// Token: 0x02000106 RID: 262
		// (Invoke) Token: 0x060005E6 RID: 1510
		private delegate void set_edgeRadiusDelegate(IntPtr @this, float value);

		// Token: 0x02000107 RID: 263
		// (Invoke) Token: 0x060005E8 RID: 1512
		private delegate bool get_autoTilingDelegate(IntPtr @this);

		// Token: 0x02000108 RID: 264
		// (Invoke) Token: 0x060005EA RID: 1514
		private delegate void set_autoTilingDelegate(IntPtr @this, bool value);
	}
}
