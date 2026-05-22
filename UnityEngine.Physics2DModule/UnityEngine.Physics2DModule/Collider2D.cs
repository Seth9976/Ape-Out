using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine
{
	// Token: 0x0200000F RID: 15
	public class Collider2D : Behaviour
	{
		// Token: 0x060002B8 RID: 696 RVA: 0x0000C048 File Offset: 0x0000A248
		// Note: this type is marked as 'beforefieldinit'.
		static Collider2D()
		{
			Il2CppClassPointerStore<Collider2D>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Physics2DModule.dll", "UnityEngine", "Collider2D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Collider2D>.NativeClassPtr);
			Collider2D.NativeMethodInfoPtr_set_isTrigger_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collider2D>.NativeClassPtr, 100663433);
			Collider2D.NativeMethodInfoPtr_get_offset_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collider2D>.NativeClassPtr, 100663434);
			Collider2D.NativeMethodInfoPtr_set_offset_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collider2D>.NativeClassPtr, 100663435);
			Collider2D.NativeMethodInfoPtr_get_attachedRigidbody_Public_get_Rigidbody2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collider2D>.NativeClassPtr, 100663436);
			Collider2D.NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collider2D>.NativeClassPtr, 100663437);
			Collider2D.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collider2D>.NativeClassPtr, 100663438);
			Collider2D.NativeMethodInfoPtr_get_offset_Injected_Private_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collider2D>.NativeClassPtr, 100663439);
			Collider2D.NativeMethodInfoPtr_set_offset_Injected_Private_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collider2D>.NativeClassPtr, 100663440);
			Collider2D.NativeMethodInfoPtr_get_bounds_Injected_Private_Void_byref_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collider2D>.NativeClassPtr, 100663441);
			Collider2D.get_densityDelegateField = IL2CPP.ResolveICall<Collider2D.get_densityDelegate>("UnityEngine.Collider2D::get_density");
			Collider2D.set_densityDelegateField = IL2CPP.ResolveICall<Collider2D.set_densityDelegate>("UnityEngine.Collider2D::set_density");
			Collider2D.get_isTriggerDelegateField = IL2CPP.ResolveICall<Collider2D.get_isTriggerDelegate>("UnityEngine.Collider2D::get_isTrigger");
			Collider2D.get_usedByEffectorDelegateField = IL2CPP.ResolveICall<Collider2D.get_usedByEffectorDelegate>("UnityEngine.Collider2D::get_usedByEffector");
			Collider2D.set_usedByEffectorDelegateField = IL2CPP.ResolveICall<Collider2D.set_usedByEffectorDelegate>("UnityEngine.Collider2D::set_usedByEffector");
			Collider2D.get_usedByCompositeDelegateField = IL2CPP.ResolveICall<Collider2D.get_usedByCompositeDelegate>("UnityEngine.Collider2D::get_usedByComposite");
			Collider2D.set_usedByCompositeDelegateField = IL2CPP.ResolveICall<Collider2D.set_usedByCompositeDelegate>("UnityEngine.Collider2D::set_usedByComposite");
			Collider2D.get_compositeDelegateField = IL2CPP.ResolveICall<Collider2D.get_compositeDelegate>("UnityEngine.Collider2D::get_composite");
			Collider2D.get_shapeCountDelegateField = IL2CPP.ResolveICall<Collider2D.get_shapeCountDelegate>("UnityEngine.Collider2D::get_shapeCount");
			Collider2D.CreateMeshDelegateField = IL2CPP.ResolveICall<Collider2D.CreateMeshDelegate>("UnityEngine.Collider2D::CreateMesh");
			Collider2D.GetShapeHashDelegateField = IL2CPP.ResolveICall<Collider2D.GetShapeHashDelegate>("UnityEngine.Collider2D::GetShapeHash");
			Collider2D.get_errorStateDelegateField = IL2CPP.ResolveICall<Collider2D.get_errorStateDelegate>("UnityEngine.Collider2D::get_errorState");
			Collider2D.get_compositeCapableDelegateField = IL2CPP.ResolveICall<Collider2D.get_compositeCapableDelegate>("UnityEngine.Collider2D::get_compositeCapable");
			Collider2D.get_sharedMaterialDelegateField = IL2CPP.ResolveICall<Collider2D.get_sharedMaterialDelegate>("UnityEngine.Collider2D::get_sharedMaterial");
			Collider2D.set_sharedMaterialDelegateField = IL2CPP.ResolveICall<Collider2D.set_sharedMaterialDelegate>("UnityEngine.Collider2D::set_sharedMaterial");
			Collider2D.get_frictionDelegateField = IL2CPP.ResolveICall<Collider2D.get_frictionDelegate>("UnityEngine.Collider2D::get_friction");
			Collider2D.get_bouncinessDelegateField = IL2CPP.ResolveICall<Collider2D.get_bouncinessDelegate>("UnityEngine.Collider2D::get_bounciness");
			Collider2D.IsTouchingDelegateField = IL2CPP.ResolveICall<Collider2D.IsTouchingDelegate>("UnityEngine.Collider2D::IsTouching");
			Collider2D.IsTouchingLayersDelegateField = IL2CPP.ResolveICall<Collider2D.IsTouchingLayersDelegate>("UnityEngine.Collider2D::IsTouchingLayers");
			Collider2D.IsTouching_OtherColliderWithFilter_InjectedDelegateField = IL2CPP.ResolveICall<Collider2D.IsTouching_OtherColliderWithFilter_InjectedDelegate>("UnityEngine.Collider2D::IsTouching_OtherColliderWithFilter_Injected");
			Collider2D.IsTouching_AnyColliderWithFilter_InjectedDelegateField = IL2CPP.ResolveICall<Collider2D.IsTouching_AnyColliderWithFilter_InjectedDelegate>("UnityEngine.Collider2D::IsTouching_AnyColliderWithFilter_Injected");
			Collider2D.OverlapPoint_InjectedDelegateField = IL2CPP.ResolveICall<Collider2D.OverlapPoint_InjectedDelegate>("UnityEngine.Collider2D::OverlapPoint_Injected");
			Collider2D.CastArray_Internal_InjectedDelegateField = IL2CPP.ResolveICall<Collider2D.CastArray_Internal_InjectedDelegate>("UnityEngine.Collider2D::CastArray_Internal_Injected");
			Collider2D.CastList_Internal_InjectedDelegateField = IL2CPP.ResolveICall<Collider2D.CastList_Internal_InjectedDelegate>("UnityEngine.Collider2D::CastList_Internal_Injected");
			Collider2D.RaycastArray_Internal_InjectedDelegateField = IL2CPP.ResolveICall<Collider2D.RaycastArray_Internal_InjectedDelegate>("UnityEngine.Collider2D::RaycastArray_Internal_Injected");
			Collider2D.RaycastList_Internal_InjectedDelegateField = IL2CPP.ResolveICall<Collider2D.RaycastList_Internal_InjectedDelegate>("UnityEngine.Collider2D::RaycastList_Internal_Injected");
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060002C5 RID: 709 RVA: 0x00003058 File Offset: 0x00001258
		// (set) Token: 0x060002B9 RID: 697 RVA: 0x0000C2B4 File Offset: 0x0000A4B4
		public unsafe bool isTrigger
		{
			get
			{
				return Collider2D.get_isTriggerDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513432, XrefRangeEnd = 513436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Collider2D.NativeMethodInfoPtr_set_isTrigger_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060002BA RID: 698 RVA: 0x0000C2F4 File Offset: 0x0000A4F4
		// (set) Token: 0x060002BB RID: 699 RVA: 0x0000C330 File Offset: 0x0000A530
		public unsafe Vector2 offset
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 513438, RefRangeEnd = 513447, XrefRangeStart = 513436, XrefRangeEnd = 513438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Collider2D.NativeMethodInfoPtr_get_offset_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513447, XrefRangeEnd = 513449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Collider2D.NativeMethodInfoPtr_set_offset_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060002BC RID: 700 RVA: 0x0000C370 File Offset: 0x0000A570
		public unsafe Rigidbody2D attachedRigidbody
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513449, XrefRangeEnd = 513453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Collider2D.NativeMethodInfoPtr_get_attachedRigidbody_Public_get_Rigidbody2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Rigidbody2D>(intPtr3) : null;
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060002BD RID: 701 RVA: 0x0000C3B0 File Offset: 0x0000A5B0
		public unsafe Bounds bounds
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 513455, RefRangeEnd = 513457, XrefRangeStart = 513453, XrefRangeEnd = 513455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Collider2D.NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002BE RID: 702 RVA: 0x0000C3EC File Offset: 0x0000A5EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Collider2D()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Collider2D>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Collider2D.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002BF RID: 703 RVA: 0x0000C428 File Offset: 0x0000A628
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513457, XrefRangeEnd = 513461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_offset_Injected(out Vector2 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Collider2D.NativeMethodInfoPtr_get_offset_Injected_Private_Void_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x0000C468 File Offset: 0x0000A668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513461, XrefRangeEnd = 513465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_offset_Injected(ref Vector2 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Collider2D.NativeMethodInfoPtr_set_offset_Injected_Private_Void_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x0000C4A8 File Offset: 0x0000A6A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513465, XrefRangeEnd = 513469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_bounds_Injected(out Bounds ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Collider2D.NativeMethodInfoPtr_get_bounds_Injected_Private_Void_byref_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x0000302A File Offset: 0x0000122A
		public Collider2D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060002C3 RID: 707 RVA: 0x00003033 File Offset: 0x00001233
		// (set) Token: 0x060002C4 RID: 708 RVA: 0x00003045 File Offset: 0x00001245
		public float density
		{
			get
			{
				return Collider2D.get_densityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Collider2D.set_densityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060002C6 RID: 710 RVA: 0x0000306A File Offset: 0x0000126A
		// (set) Token: 0x060002C7 RID: 711 RVA: 0x0000307C File Offset: 0x0000127C
		public bool usedByEffector
		{
			get
			{
				return Collider2D.get_usedByEffectorDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Collider2D.set_usedByEffectorDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060002C8 RID: 712 RVA: 0x0000308F File Offset: 0x0000128F
		// (set) Token: 0x060002C9 RID: 713 RVA: 0x000030A1 File Offset: 0x000012A1
		public bool usedByComposite
		{
			get
			{
				return Collider2D.get_usedByCompositeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Collider2D.set_usedByCompositeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060002CA RID: 714 RVA: 0x0000C4E8 File Offset: 0x0000A6E8
		public CompositeCollider2D composite
		{
			get
			{
				IntPtr intPtr = Collider2D.get_compositeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CompositeCollider2D>(intPtr2) : null;
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060002CB RID: 715 RVA: 0x000030B4 File Offset: 0x000012B4
		public int shapeCount
		{
			get
			{
				return Collider2D.get_shapeCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x060002CC RID: 716 RVA: 0x0000C514 File Offset: 0x0000A714
		public Mesh CreateMesh(bool useBodyPosition, bool useBodyRotation)
		{
			IntPtr intPtr = Collider2D.CreateMeshDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), useBodyPosition, useBodyRotation);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
		}

		// Token: 0x060002CD RID: 717 RVA: 0x000030C6 File Offset: 0x000012C6
		public uint GetShapeHash()
		{
			return Collider2D.GetShapeHashDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060002CE RID: 718 RVA: 0x000030D8 File Offset: 0x000012D8
		public ColliderErrorState2D errorState
		{
			get
			{
				return Collider2D.get_errorStateDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060002CF RID: 719 RVA: 0x000030EA File Offset: 0x000012EA
		public bool compositeCapable
		{
			get
			{
				return Collider2D.get_compositeCapableDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060002D0 RID: 720 RVA: 0x0000C544 File Offset: 0x0000A744
		// (set) Token: 0x060002D1 RID: 721 RVA: 0x000030FC File Offset: 0x000012FC
		public PhysicsMaterial2D sharedMaterial
		{
			get
			{
				IntPtr intPtr = Collider2D.get_sharedMaterialDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PhysicsMaterial2D>(intPtr2) : null;
			}
			set
			{
				Collider2D.set_sharedMaterialDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060002D2 RID: 722 RVA: 0x00003114 File Offset: 0x00001314
		public float friction
		{
			get
			{
				return Collider2D.get_frictionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060002D3 RID: 723 RVA: 0x00003126 File Offset: 0x00001326
		public float bounciness
		{
			get
			{
				return Collider2D.get_bouncinessDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x00003138 File Offset: 0x00001338
		public bool IsTouching(Collider2D collider)
		{
			return Collider2D.IsTouchingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(collider));
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x0000C570 File Offset: 0x0000A770
		public bool IsTouching(Collider2D collider, ContactFilter2D contactFilter)
		{
			return this.IsTouching_OtherColliderWithFilter(collider, contactFilter);
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x00003150 File Offset: 0x00001350
		public bool IsTouching_OtherColliderWithFilter(Collider2D collider, ContactFilter2D contactFilter)
		{
			return this.IsTouching_OtherColliderWithFilter_Injected(collider, ref contactFilter);
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x0000C58C File Offset: 0x0000A78C
		public bool IsTouching(ContactFilter2D contactFilter)
		{
			return this.IsTouching_AnyColliderWithFilter(contactFilter);
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x0000315B File Offset: 0x0000135B
		public bool IsTouching_AnyColliderWithFilter(ContactFilter2D contactFilter)
		{
			return this.IsTouching_AnyColliderWithFilter_Injected(ref contactFilter);
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x0000C5A8 File Offset: 0x0000A7A8
		public bool IsTouchingLayers()
		{
			return this.IsTouchingLayers(-1);
		}

		// Token: 0x060002DA RID: 730 RVA: 0x00003165 File Offset: 0x00001365
		public bool IsTouchingLayers(int layerMask)
		{
			return Collider2D.IsTouchingLayersDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), layerMask);
		}

		// Token: 0x060002DB RID: 731 RVA: 0x00003178 File Offset: 0x00001378
		public bool OverlapPoint(Vector2 point)
		{
			return this.OverlapPoint_Injected(ref point);
		}

		// Token: 0x060002DC RID: 732 RVA: 0x0000C5C4 File Offset: 0x0000A7C4
		public int OverlapCollider(ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> results)
		{
			return PhysicsScene2D.OverlapCollider(this, contactFilter, results);
		}

		// Token: 0x060002DD RID: 733 RVA: 0x0000C5E0 File Offset: 0x0000A7E0
		public int OverlapCollider(ContactFilter2D contactFilter, List<Collider2D> results)
		{
			return PhysicsScene2D.OverlapCollider(this, contactFilter, results);
		}

		// Token: 0x060002DE RID: 734 RVA: 0x0000C5FC File Offset: 0x0000A7FC
		public int GetContacts(Il2CppStructArray<ContactPoint2D> contacts)
		{
			return Physics2D.GetContacts(this, default(ContactFilter2D).NoFilter(), contacts);
		}

		// Token: 0x060002DF RID: 735 RVA: 0x0000C624 File Offset: 0x0000A824
		public int GetContacts(List<ContactPoint2D> contacts)
		{
			return Physics2D.GetContacts(this, default(ContactFilter2D).NoFilter(), contacts);
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x0000C64C File Offset: 0x0000A84C
		public int GetContacts(ContactFilter2D contactFilter, Il2CppStructArray<ContactPoint2D> contacts)
		{
			return Physics2D.GetContacts(this, contactFilter, contacts);
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x0000C668 File Offset: 0x0000A868
		public int GetContacts(ContactFilter2D contactFilter, List<ContactPoint2D> contacts)
		{
			return Physics2D.GetContacts(this, contactFilter, contacts);
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x0000C684 File Offset: 0x0000A884
		public int GetContacts(Il2CppReferenceArray<Collider2D> colliders)
		{
			return Physics2D.GetContacts(this, default(ContactFilter2D).NoFilter(), colliders);
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x0000C6AC File Offset: 0x0000A8AC
		public int GetContacts(List<Collider2D> colliders)
		{
			return Physics2D.GetContacts(this, default(ContactFilter2D).NoFilter(), colliders);
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x0000C6D4 File Offset: 0x0000A8D4
		public int GetContacts(ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> colliders)
		{
			return Physics2D.GetContacts(this, contactFilter, colliders);
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x0000C6F0 File Offset: 0x0000A8F0
		public int GetContacts(ContactFilter2D contactFilter, List<Collider2D> colliders)
		{
			return Physics2D.GetContacts(this, contactFilter, colliders);
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x0000C70C File Offset: 0x0000A90C
		public int Cast(Vector2 direction, Il2CppStructArray<RaycastHit2D> results)
		{
			ContactFilter2D contactFilter2D = default(ContactFilter2D);
			contactFilter2D.useTriggers = Physics2D.queriesHitTriggers;
			contactFilter2D.SetLayerMask(Physics2D.GetLayerCollisionMask(base.gameObject.layer));
			return this.CastArray_Internal(direction, float.PositiveInfinity, contactFilter2D, true, results);
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x0000C760 File Offset: 0x0000A960
		public int Cast(Vector2 direction, Il2CppStructArray<RaycastHit2D> results, float distance)
		{
			ContactFilter2D contactFilter2D = default(ContactFilter2D);
			contactFilter2D.useTriggers = Physics2D.queriesHitTriggers;
			contactFilter2D.SetLayerMask(Physics2D.GetLayerCollisionMask(base.gameObject.layer));
			return this.CastArray_Internal(direction, distance, contactFilter2D, true, results);
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x0000C7B0 File Offset: 0x0000A9B0
		public int Cast(Vector2 direction, Il2CppStructArray<RaycastHit2D> results, float distance, bool ignoreSiblingColliders)
		{
			ContactFilter2D contactFilter2D = default(ContactFilter2D);
			contactFilter2D.useTriggers = Physics2D.queriesHitTriggers;
			contactFilter2D.SetLayerMask(Physics2D.GetLayerCollisionMask(base.gameObject.layer));
			return this.CastArray_Internal(direction, distance, contactFilter2D, ignoreSiblingColliders, results);
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x0000C800 File Offset: 0x0000AA00
		public int Cast(Vector2 direction, ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results)
		{
			return this.CastArray_Internal(direction, float.PositiveInfinity, contactFilter, true, results);
		}

		// Token: 0x060002EA RID: 746 RVA: 0x0000C824 File Offset: 0x0000AA24
		public int Cast(Vector2 direction, ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results, float distance)
		{
			return this.CastArray_Internal(direction, distance, contactFilter, true, results);
		}

		// Token: 0x060002EB RID: 747 RVA: 0x0000C844 File Offset: 0x0000AA44
		public int Cast(Vector2 direction, ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results, float distance, bool ignoreSiblingColliders)
		{
			return this.CastArray_Internal(direction, distance, contactFilter, ignoreSiblingColliders, results);
		}

		// Token: 0x060002EC RID: 748 RVA: 0x00003182 File Offset: 0x00001382
		public int CastArray_Internal(Vector2 direction, float distance, ContactFilter2D contactFilter, bool ignoreSiblingColliders, Il2CppStructArray<RaycastHit2D> results)
		{
			return this.CastArray_Internal_Injected(ref direction, distance, ref contactFilter, ignoreSiblingColliders, results);
		}

		// Token: 0x060002ED RID: 749 RVA: 0x0000C864 File Offset: 0x0000AA64
		public int Cast(Vector2 direction, ContactFilter2D contactFilter, List<RaycastHit2D> results, [Optional] float distance, [Optional] bool ignoreSiblingColliders)
		{
			return this.CastList_Internal(direction, distance, contactFilter, ignoreSiblingColliders, results);
		}

		// Token: 0x060002EE RID: 750 RVA: 0x00003193 File Offset: 0x00001393
		public int CastList_Internal(Vector2 direction, float distance, ContactFilter2D contactFilter, bool ignoreSiblingColliders, List<RaycastHit2D> results)
		{
			return this.CastList_Internal_Injected(ref direction, distance, ref contactFilter, ignoreSiblingColliders, results);
		}

		// Token: 0x060002EF RID: 751 RVA: 0x0000C884 File Offset: 0x0000AA84
		public int Raycast(Vector2 direction, Il2CppStructArray<RaycastHit2D> results)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(-1, float.NegativeInfinity, float.PositiveInfinity);
			return this.RaycastArray_Internal(direction, float.PositiveInfinity, contactFilter2D, results);
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x0000C8B8 File Offset: 0x0000AAB8
		public int Raycast(Vector2 direction, Il2CppStructArray<RaycastHit2D> results, float distance)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(-1, float.NegativeInfinity, float.PositiveInfinity);
			return this.RaycastArray_Internal(direction, distance, contactFilter2D, results);
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x0000C8E8 File Offset: 0x0000AAE8
		public int Raycast(Vector2 direction, Il2CppStructArray<RaycastHit2D> results, float distance, int layerMask)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
			return this.RaycastArray_Internal(direction, distance, contactFilter2D, results);
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x0000C918 File Offset: 0x0000AB18
		public int Raycast(Vector2 direction, Il2CppStructArray<RaycastHit2D> results, float distance, int layerMask, float minDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
			return this.RaycastArray_Internal(direction, distance, contactFilter2D, results);
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x0000C944 File Offset: 0x0000AB44
		public int Raycast(Vector2 direction, Il2CppStructArray<RaycastHit2D> results, float distance, int layerMask, float minDepth, float maxDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
			return this.RaycastArray_Internal(direction, distance, contactFilter2D, results);
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x0000C96C File Offset: 0x0000AB6C
		public int Raycast(Vector2 direction, ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results)
		{
			return this.RaycastArray_Internal(direction, float.PositiveInfinity, contactFilter, results);
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x0000C98C File Offset: 0x0000AB8C
		public int Raycast(Vector2 direction, ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results, float distance)
		{
			return this.RaycastArray_Internal(direction, distance, contactFilter, results);
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x000031A4 File Offset: 0x000013A4
		public int RaycastArray_Internal(Vector2 direction, float distance, ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results)
		{
			return this.RaycastArray_Internal_Injected(ref direction, distance, ref contactFilter, results);
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x0000C9AC File Offset: 0x0000ABAC
		public int Raycast(Vector2 direction, ContactFilter2D contactFilter, List<RaycastHit2D> results, [Optional] float distance)
		{
			return this.RaycastList_Internal(direction, distance, contactFilter, results);
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x000031B3 File Offset: 0x000013B3
		public int RaycastList_Internal(Vector2 direction, float distance, ContactFilter2D contactFilter, List<RaycastHit2D> results)
		{
			return this.RaycastList_Internal_Injected(ref direction, distance, ref contactFilter, results);
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x0000C9CC File Offset: 0x0000ABCC
		public Vector2 ClosestPoint(Vector2 position)
		{
			return Physics2D.ClosestPoint(position, this);
		}

		// Token: 0x060002FA RID: 762 RVA: 0x000031C2 File Offset: 0x000013C2
		public bool IsTouching_OtherColliderWithFilter_Injected(Collider2D collider, ref ContactFilter2D contactFilter)
		{
			return Collider2D.IsTouching_OtherColliderWithFilter_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(collider), ref contactFilter);
		}

		// Token: 0x060002FB RID: 763 RVA: 0x000031DB File Offset: 0x000013DB
		public bool IsTouching_AnyColliderWithFilter_Injected(ref ContactFilter2D contactFilter)
		{
			return Collider2D.IsTouching_AnyColliderWithFilter_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref contactFilter);
		}

		// Token: 0x060002FC RID: 764 RVA: 0x000031EE File Offset: 0x000013EE
		public bool OverlapPoint_Injected(ref Vector2 point)
		{
			return Collider2D.OverlapPoint_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref point);
		}

		// Token: 0x060002FD RID: 765 RVA: 0x00003201 File Offset: 0x00001401
		public int CastArray_Internal_Injected(ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, bool ignoreSiblingColliders, Il2CppStructArray<RaycastHit2D> results)
		{
			return Collider2D.CastArray_Internal_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref direction, distance, ref contactFilter, ignoreSiblingColliders, IL2CPP.Il2CppObjectBaseToPtr(results));
		}

		// Token: 0x060002FE RID: 766 RVA: 0x0000321F File Offset: 0x0000141F
		public int CastList_Internal_Injected(ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, bool ignoreSiblingColliders, List<RaycastHit2D> results)
		{
			return Collider2D.CastList_Internal_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref direction, distance, ref contactFilter, ignoreSiblingColliders, IL2CPP.Il2CppObjectBaseToPtr(results));
		}

		// Token: 0x060002FF RID: 767 RVA: 0x0000323D File Offset: 0x0000143D
		public int RaycastArray_Internal_Injected(ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results)
		{
			return Collider2D.RaycastArray_Internal_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref direction, distance, ref contactFilter, IL2CPP.Il2CppObjectBaseToPtr(results));
		}

		// Token: 0x06000300 RID: 768 RVA: 0x00003259 File Offset: 0x00001459
		public int RaycastList_Internal_Injected(ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, List<RaycastHit2D> results)
		{
			return Collider2D.RaycastList_Internal_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref direction, distance, ref contactFilter, IL2CPP.Il2CppObjectBaseToPtr(results));
		}

		// Token: 0x04000190 RID: 400
		private static readonly IntPtr NativeMethodInfoPtr_set_isTrigger_Public_set_Void_Boolean_0;

		// Token: 0x04000191 RID: 401
		private static readonly IntPtr NativeMethodInfoPtr_get_offset_Public_get_Vector2_0;

		// Token: 0x04000192 RID: 402
		private static readonly IntPtr NativeMethodInfoPtr_set_offset_Public_set_Void_Vector2_0;

		// Token: 0x04000193 RID: 403
		private static readonly IntPtr NativeMethodInfoPtr_get_attachedRigidbody_Public_get_Rigidbody2D_0;

		// Token: 0x04000194 RID: 404
		private static readonly IntPtr NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0;

		// Token: 0x04000195 RID: 405
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000196 RID: 406
		private static readonly IntPtr NativeMethodInfoPtr_get_offset_Injected_Private_Void_byref_Vector2_0;

		// Token: 0x04000197 RID: 407
		private static readonly IntPtr NativeMethodInfoPtr_set_offset_Injected_Private_Void_byref_Vector2_0;

		// Token: 0x04000198 RID: 408
		private static readonly IntPtr NativeMethodInfoPtr_get_bounds_Injected_Private_Void_byref_Bounds_0;

		// Token: 0x04000199 RID: 409
		private static readonly Collider2D.get_densityDelegate get_densityDelegateField;

		// Token: 0x0400019A RID: 410
		private static readonly Collider2D.set_densityDelegate set_densityDelegateField;

		// Token: 0x0400019B RID: 411
		private static readonly Collider2D.get_isTriggerDelegate get_isTriggerDelegateField;

		// Token: 0x0400019C RID: 412
		private static readonly Collider2D.get_usedByEffectorDelegate get_usedByEffectorDelegateField;

		// Token: 0x0400019D RID: 413
		private static readonly Collider2D.set_usedByEffectorDelegate set_usedByEffectorDelegateField;

		// Token: 0x0400019E RID: 414
		private static readonly Collider2D.get_usedByCompositeDelegate get_usedByCompositeDelegateField;

		// Token: 0x0400019F RID: 415
		private static readonly Collider2D.set_usedByCompositeDelegate set_usedByCompositeDelegateField;

		// Token: 0x040001A0 RID: 416
		private static readonly Collider2D.get_compositeDelegate get_compositeDelegateField;

		// Token: 0x040001A1 RID: 417
		private static readonly Collider2D.get_shapeCountDelegate get_shapeCountDelegateField;

		// Token: 0x040001A2 RID: 418
		private static readonly Collider2D.CreateMeshDelegate CreateMeshDelegateField;

		// Token: 0x040001A3 RID: 419
		private static readonly Collider2D.GetShapeHashDelegate GetShapeHashDelegateField;

		// Token: 0x040001A4 RID: 420
		private static readonly Collider2D.get_errorStateDelegate get_errorStateDelegateField;

		// Token: 0x040001A5 RID: 421
		private static readonly Collider2D.get_compositeCapableDelegate get_compositeCapableDelegateField;

		// Token: 0x040001A6 RID: 422
		private static readonly Collider2D.get_sharedMaterialDelegate get_sharedMaterialDelegateField;

		// Token: 0x040001A7 RID: 423
		private static readonly Collider2D.set_sharedMaterialDelegate set_sharedMaterialDelegateField;

		// Token: 0x040001A8 RID: 424
		private static readonly Collider2D.get_frictionDelegate get_frictionDelegateField;

		// Token: 0x040001A9 RID: 425
		private static readonly Collider2D.get_bouncinessDelegate get_bouncinessDelegateField;

		// Token: 0x040001AA RID: 426
		private static readonly Collider2D.IsTouchingDelegate IsTouchingDelegateField;

		// Token: 0x040001AB RID: 427
		private static readonly Collider2D.IsTouchingLayersDelegate IsTouchingLayersDelegateField;

		// Token: 0x040001AC RID: 428
		private static readonly Collider2D.IsTouching_OtherColliderWithFilter_InjectedDelegate IsTouching_OtherColliderWithFilter_InjectedDelegateField;

		// Token: 0x040001AD RID: 429
		private static readonly Collider2D.IsTouching_AnyColliderWithFilter_InjectedDelegate IsTouching_AnyColliderWithFilter_InjectedDelegateField;

		// Token: 0x040001AE RID: 430
		private static readonly Collider2D.OverlapPoint_InjectedDelegate OverlapPoint_InjectedDelegateField;

		// Token: 0x040001AF RID: 431
		private static readonly Collider2D.CastArray_Internal_InjectedDelegate CastArray_Internal_InjectedDelegateField;

		// Token: 0x040001B0 RID: 432
		private static readonly Collider2D.CastList_Internal_InjectedDelegate CastList_Internal_InjectedDelegateField;

		// Token: 0x040001B1 RID: 433
		private static readonly Collider2D.RaycastArray_Internal_InjectedDelegate RaycastArray_Internal_InjectedDelegateField;

		// Token: 0x040001B2 RID: 434
		private static readonly Collider2D.RaycastList_Internal_InjectedDelegate RaycastList_Internal_InjectedDelegateField;

		// Token: 0x020000DA RID: 218
		// (Invoke) Token: 0x0600058E RID: 1422
		private delegate float get_densityDelegate(IntPtr @this);

		// Token: 0x020000DB RID: 219
		// (Invoke) Token: 0x06000590 RID: 1424
		private delegate void set_densityDelegate(IntPtr @this, float value);

		// Token: 0x020000DC RID: 220
		// (Invoke) Token: 0x06000592 RID: 1426
		private delegate bool get_isTriggerDelegate(IntPtr @this);

		// Token: 0x020000DD RID: 221
		// (Invoke) Token: 0x06000594 RID: 1428
		private delegate bool get_usedByEffectorDelegate(IntPtr @this);

		// Token: 0x020000DE RID: 222
		// (Invoke) Token: 0x06000596 RID: 1430
		private delegate void set_usedByEffectorDelegate(IntPtr @this, bool value);

		// Token: 0x020000DF RID: 223
		// (Invoke) Token: 0x06000598 RID: 1432
		private delegate bool get_usedByCompositeDelegate(IntPtr @this);

		// Token: 0x020000E0 RID: 224
		// (Invoke) Token: 0x0600059A RID: 1434
		private delegate void set_usedByCompositeDelegate(IntPtr @this, bool value);

		// Token: 0x020000E1 RID: 225
		// (Invoke) Token: 0x0600059C RID: 1436
		private delegate IntPtr get_compositeDelegate(IntPtr @this);

		// Token: 0x020000E2 RID: 226
		// (Invoke) Token: 0x0600059E RID: 1438
		private delegate int get_shapeCountDelegate(IntPtr @this);

		// Token: 0x020000E3 RID: 227
		// (Invoke) Token: 0x060005A0 RID: 1440
		private delegate IntPtr CreateMeshDelegate(IntPtr @this, bool useBodyPosition, bool useBodyRotation);

		// Token: 0x020000E4 RID: 228
		// (Invoke) Token: 0x060005A2 RID: 1442
		private delegate uint GetShapeHashDelegate(IntPtr @this);

		// Token: 0x020000E5 RID: 229
		// (Invoke) Token: 0x060005A4 RID: 1444
		private delegate ColliderErrorState2D get_errorStateDelegate(IntPtr @this);

		// Token: 0x020000E6 RID: 230
		// (Invoke) Token: 0x060005A6 RID: 1446
		private delegate bool get_compositeCapableDelegate(IntPtr @this);

		// Token: 0x020000E7 RID: 231
		// (Invoke) Token: 0x060005A8 RID: 1448
		private delegate IntPtr get_sharedMaterialDelegate(IntPtr @this);

		// Token: 0x020000E8 RID: 232
		// (Invoke) Token: 0x060005AA RID: 1450
		private delegate void set_sharedMaterialDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020000E9 RID: 233
		// (Invoke) Token: 0x060005AC RID: 1452
		private delegate float get_frictionDelegate(IntPtr @this);

		// Token: 0x020000EA RID: 234
		// (Invoke) Token: 0x060005AE RID: 1454
		private delegate float get_bouncinessDelegate(IntPtr @this);

		// Token: 0x020000EB RID: 235
		// (Invoke) Token: 0x060005B0 RID: 1456
		private delegate bool IsTouchingDelegate(IntPtr @this, IntPtr collider);

		// Token: 0x020000EC RID: 236
		// (Invoke) Token: 0x060005B2 RID: 1458
		private delegate bool IsTouchingLayersDelegate(IntPtr @this, int layerMask);

		// Token: 0x020000ED RID: 237
		// (Invoke) Token: 0x060005B4 RID: 1460
		private delegate bool IsTouching_OtherColliderWithFilter_InjectedDelegate(IntPtr @this, IntPtr collider, IntPtr contactFilter);

		// Token: 0x020000EE RID: 238
		// (Invoke) Token: 0x060005B6 RID: 1462
		private delegate bool IsTouching_AnyColliderWithFilter_InjectedDelegate(IntPtr @this, IntPtr contactFilter);

		// Token: 0x020000EF RID: 239
		// (Invoke) Token: 0x060005B8 RID: 1464
		private delegate bool OverlapPoint_InjectedDelegate(IntPtr @this, IntPtr point);

		// Token: 0x020000F0 RID: 240
		// (Invoke) Token: 0x060005BA RID: 1466
		private delegate int CastArray_Internal_InjectedDelegate(IntPtr @this, IntPtr direction, float distance, IntPtr contactFilter, bool ignoreSiblingColliders, IntPtr results);

		// Token: 0x020000F1 RID: 241
		// (Invoke) Token: 0x060005BC RID: 1468
		private delegate int CastList_Internal_InjectedDelegate(IntPtr @this, IntPtr direction, float distance, IntPtr contactFilter, bool ignoreSiblingColliders, IntPtr results);

		// Token: 0x020000F2 RID: 242
		// (Invoke) Token: 0x060005BE RID: 1470
		private delegate int RaycastArray_Internal_InjectedDelegate(IntPtr @this, IntPtr direction, float distance, IntPtr contactFilter, IntPtr results);

		// Token: 0x020000F3 RID: 243
		// (Invoke) Token: 0x060005C0 RID: 1472
		private delegate int RaycastList_Internal_InjectedDelegate(IntPtr @this, IntPtr direction, float distance, IntPtr contactFilter, IntPtr results);
	}
}
