using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine
{
	// Token: 0x02000002 RID: 2
	[StructLayout(2)]
	public struct PhysicsScene2D
	{
		// Token: 0x06000001 RID: 1 RVA: 0x000044E4 File Offset: 0x000026E4
		// Note: this type is marked as 'beforefieldinit'.
		static PhysicsScene2D()
		{
			Il2CppClassPointerStore<PhysicsScene2D>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Physics2DModule.dll", "UnityEngine", "PhysicsScene2D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhysicsScene2D>.NativeClassPtr);
			PhysicsScene2D.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsScene2D>.NativeClassPtr, "m_Handle");
			PhysicsScene2D.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene2D>.NativeClassPtr, 100663297);
			PhysicsScene2D.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene2D>.NativeClassPtr, 100663298);
			PhysicsScene2D.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene2D>.NativeClassPtr, 100663299);
			PhysicsScene2D.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PhysicsScene2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene2D>.NativeClassPtr, 100663300);
			PhysicsScene2D.NativeMethodInfoPtr_Raycast_Public_RaycastHit2D_Vector2_Vector2_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene2D>.NativeClassPtr, 100663301);
			PhysicsScene2D.NativeMethodInfoPtr_Raycast_Public_RaycastHit2D_Vector2_Vector2_Single_ContactFilter2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene2D>.NativeClassPtr, 100663302);
			PhysicsScene2D.NativeMethodInfoPtr_Raycast_Internal_Private_Static_RaycastHit2D_PhysicsScene2D_Vector2_Vector2_Single_ContactFilter2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene2D>.NativeClassPtr, 100663303);
			PhysicsScene2D.NativeMethodInfoPtr_Raycast_Public_Int32_Vector2_Vector2_Single_ContactFilter2D_Il2CppStructArray_1_RaycastHit2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene2D>.NativeClassPtr, 100663304);
			PhysicsScene2D.NativeMethodInfoPtr_RaycastArray_Internal_Private_Static_Int32_PhysicsScene2D_Vector2_Vector2_Single_ContactFilter2D_Il2CppStructArray_1_RaycastHit2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene2D>.NativeClassPtr, 100663305);
			PhysicsScene2D.NativeMethodInfoPtr_Raycast_Public_Int32_Vector2_Vector2_Single_ContactFilter2D_List_1_RaycastHit2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene2D>.NativeClassPtr, 100663306);
			PhysicsScene2D.NativeMethodInfoPtr_RaycastList_Internal_Private_Static_Int32_PhysicsScene2D_Vector2_Vector2_Single_ContactFilter2D_List_1_RaycastHit2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene2D>.NativeClassPtr, 100663307);
			PhysicsScene2D.NativeMethodInfoPtr_CircleCast_Public_RaycastHit2D_Vector2_Single_Vector2_Single_ContactFilter2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene2D>.NativeClassPtr, 100663308);
			PhysicsScene2D.NativeMethodInfoPtr_CircleCast_Internal_Private_Static_RaycastHit2D_PhysicsScene2D_Vector2_Single_Vector2_Single_ContactFilter2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene2D>.NativeClassPtr, 100663309);
			PhysicsScene2D.NativeMethodInfoPtr_CircleCast_Public_Int32_Vector2_Single_Vector2_Single_ContactFilter2D_Il2CppStructArray_1_RaycastHit2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene2D>.NativeClassPtr, 100663310);
			PhysicsScene2D.NativeMethodInfoPtr_CircleCastArray_Internal_Private_Static_Int32_PhysicsScene2D_Vector2_Single_Vector2_Single_ContactFilter2D_Il2CppStructArray_1_RaycastHit2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene2D>.NativeClassPtr, 100663311);
			PhysicsScene2D.NativeMethodInfoPtr_GetRayIntersection_Public_Int32_Ray_Single_Il2CppStructArray_1_RaycastHit2D_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene2D>.NativeClassPtr, 100663312);
			PhysicsScene2D.NativeMethodInfoPtr_GetRayIntersectionArray_Internal_Private_Static_Int32_PhysicsScene2D_Vector3_Vector3_Single_Int32_Il2CppStructArray_1_RaycastHit2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene2D>.NativeClassPtr, 100663313);
			PhysicsScene2D.NativeMethodInfoPtr_OverlapPoint_Public_Collider2D_Vector2_ContactFilter2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene2D>.NativeClassPtr, 100663314);
			PhysicsScene2D.NativeMethodInfoPtr_OverlapPoint_Internal_Private_Static_Collider2D_PhysicsScene2D_Vector2_ContactFilter2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene2D>.NativeClassPtr, 100663315);
			PhysicsScene2D.NativeMethodInfoPtr_OverlapCircle_Public_Collider2D_Vector2_Single_ContactFilter2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene2D>.NativeClassPtr, 100663316);
			PhysicsScene2D.NativeMethodInfoPtr_OverlapCircle_Internal_Private_Static_Collider2D_PhysicsScene2D_Vector2_Single_ContactFilter2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene2D>.NativeClassPtr, 100663317);
			PhysicsScene2D.NativeMethodInfoPtr_OverlapCircle_Public_Int32_Vector2_Single_ContactFilter2D_Il2CppReferenceArray_1_Collider2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene2D>.NativeClassPtr, 100663318);
			PhysicsScene2D.NativeMethodInfoPtr_OverlapCircleArray_Internal_Private_Static_Int32_PhysicsScene2D_Vector2_Single_ContactFilter2D_Il2CppReferenceArray_1_Collider2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene2D>.NativeClassPtr, 100663319);
			PhysicsScene2D.NativeMethodInfoPtr_OverlapBox_Public_Collider2D_Vector2_Vector2_Single_ContactFilter2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene2D>.NativeClassPtr, 100663320);
			PhysicsScene2D.NativeMethodInfoPtr_OverlapBox_Internal_Private_Static_Collider2D_PhysicsScene2D_Vector2_Vector2_Single_ContactFilter2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene2D>.NativeClassPtr, 100663321);
			PhysicsScene2D.NativeMethodInfoPtr_OverlapBox_Public_Int32_Vector2_Vector2_Single_ContactFilter2D_Il2CppReferenceArray_1_Collider2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene2D>.NativeClassPtr, 100663322);
			PhysicsScene2D.NativeMethodInfoPtr_OverlapBoxArray_Internal_Private_Static_Int32_PhysicsScene2D_Vector2_Vector2_Single_ContactFilter2D_Il2CppReferenceArray_1_Collider2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene2D>.NativeClassPtr, 100663323);
			PhysicsScene2D.NativeMethodInfoPtr_OverlapArea_Public_Int32_Vector2_Vector2_ContactFilter2D_Il2CppReferenceArray_1_Collider2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene2D>.NativeClassPtr, 100663324);
			PhysicsScene2D.NativeMethodInfoPtr_OverlapAreaToBoxArray_Internal_Private_Int32_Vector2_Vector2_ContactFilter2D_Il2CppReferenceArray_1_Collider2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene2D>.NativeClassPtr, 100663325);
			PhysicsScene2D.NativeMethodInfoPtr_Raycast_Internal_Injected_Private_Static_Void_byref_PhysicsScene2D_byref_Vector2_byref_Vector2_Single_byref_ContactFilter2D_byref_RaycastHit2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene2D>.NativeClassPtr, 100663326);
			PhysicsScene2D.NativeMethodInfoPtr_RaycastArray_Internal_Injected_Private_Static_Int32_byref_PhysicsScene2D_byref_Vector2_byref_Vector2_Single_byref_ContactFilter2D_Il2CppStructArray_1_RaycastHit2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene2D>.NativeClassPtr, 100663327);
			PhysicsScene2D.NativeMethodInfoPtr_RaycastList_Internal_Injected_Private_Static_Int32_byref_PhysicsScene2D_byref_Vector2_byref_Vector2_Single_byref_ContactFilter2D_List_1_RaycastHit2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene2D>.NativeClassPtr, 100663328);
			PhysicsScene2D.NativeMethodInfoPtr_CircleCast_Internal_Injected_Private_Static_Void_byref_PhysicsScene2D_byref_Vector2_Single_byref_Vector2_Single_byref_ContactFilter2D_byref_RaycastHit2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene2D>.NativeClassPtr, 100663329);
			PhysicsScene2D.NativeMethodInfoPtr_CircleCastArray_Internal_Injected_Private_Static_Int32_byref_PhysicsScene2D_byref_Vector2_Single_byref_Vector2_Single_byref_ContactFilter2D_Il2CppStructArray_1_RaycastHit2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene2D>.NativeClassPtr, 100663330);
			PhysicsScene2D.NativeMethodInfoPtr_GetRayIntersectionArray_Internal_Injected_Private_Static_Int32_byref_PhysicsScene2D_byref_Vector3_byref_Vector3_Single_Int32_Il2CppStructArray_1_RaycastHit2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene2D>.NativeClassPtr, 100663331);
			PhysicsScene2D.NativeMethodInfoPtr_OverlapPoint_Internal_Injected_Private_Static_Collider2D_byref_PhysicsScene2D_byref_Vector2_byref_ContactFilter2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene2D>.NativeClassPtr, 100663332);
			PhysicsScene2D.NativeMethodInfoPtr_OverlapCircle_Internal_Injected_Private_Static_Collider2D_byref_PhysicsScene2D_byref_Vector2_Single_byref_ContactFilter2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene2D>.NativeClassPtr, 100663333);
			PhysicsScene2D.NativeMethodInfoPtr_OverlapCircleArray_Internal_Injected_Private_Static_Int32_byref_PhysicsScene2D_byref_Vector2_Single_byref_ContactFilter2D_Il2CppReferenceArray_1_Collider2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene2D>.NativeClassPtr, 100663334);
			PhysicsScene2D.NativeMethodInfoPtr_OverlapBox_Internal_Injected_Private_Static_Collider2D_byref_PhysicsScene2D_byref_Vector2_byref_Vector2_Single_byref_ContactFilter2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene2D>.NativeClassPtr, 100663335);
			PhysicsScene2D.NativeMethodInfoPtr_OverlapBoxArray_Internal_Injected_Private_Static_Int32_byref_PhysicsScene2D_byref_Vector2_byref_Vector2_Single_byref_ContactFilter2D_Il2CppReferenceArray_1_Collider2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene2D>.NativeClassPtr, 100663336);
			PhysicsScene2D.IsValid_Internal_InjectedDelegateField = IL2CPP.ResolveICall<PhysicsScene2D.IsValid_Internal_InjectedDelegate>("UnityEngine.PhysicsScene2D::IsValid_Internal_Injected");
			PhysicsScene2D.IsEmpty_Internal_InjectedDelegateField = IL2CPP.ResolveICall<PhysicsScene2D.IsEmpty_Internal_InjectedDelegate>("UnityEngine.PhysicsScene2D::IsEmpty_Internal_Injected");
			PhysicsScene2D.Linecast_Internal_InjectedDelegateField = IL2CPP.ResolveICall<PhysicsScene2D.Linecast_Internal_InjectedDelegate>("UnityEngine.PhysicsScene2D::Linecast_Internal_Injected");
			PhysicsScene2D.LinecastArray_Internal_InjectedDelegateField = IL2CPP.ResolveICall<PhysicsScene2D.LinecastArray_Internal_InjectedDelegate>("UnityEngine.PhysicsScene2D::LinecastArray_Internal_Injected");
			PhysicsScene2D.LinecastNonAllocList_Internal_InjectedDelegateField = IL2CPP.ResolveICall<PhysicsScene2D.LinecastNonAllocList_Internal_InjectedDelegate>("UnityEngine.PhysicsScene2D::LinecastNonAllocList_Internal_Injected");
			PhysicsScene2D.CircleCastList_Internal_InjectedDelegateField = IL2CPP.ResolveICall<PhysicsScene2D.CircleCastList_Internal_InjectedDelegate>("UnityEngine.PhysicsScene2D::CircleCastList_Internal_Injected");
			PhysicsScene2D.BoxCast_Internal_InjectedDelegateField = IL2CPP.ResolveICall<PhysicsScene2D.BoxCast_Internal_InjectedDelegate>("UnityEngine.PhysicsScene2D::BoxCast_Internal_Injected");
			PhysicsScene2D.BoxCastArray_Internal_InjectedDelegateField = IL2CPP.ResolveICall<PhysicsScene2D.BoxCastArray_Internal_InjectedDelegate>("UnityEngine.PhysicsScene2D::BoxCastArray_Internal_Injected");
			PhysicsScene2D.BoxCastList_Internal_InjectedDelegateField = IL2CPP.ResolveICall<PhysicsScene2D.BoxCastList_Internal_InjectedDelegate>("UnityEngine.PhysicsScene2D::BoxCastList_Internal_Injected");
			PhysicsScene2D.CapsuleCast_Internal_InjectedDelegateField = IL2CPP.ResolveICall<PhysicsScene2D.CapsuleCast_Internal_InjectedDelegate>("UnityEngine.PhysicsScene2D::CapsuleCast_Internal_Injected");
			PhysicsScene2D.CapsuleCastArray_Internal_InjectedDelegateField = IL2CPP.ResolveICall<PhysicsScene2D.CapsuleCastArray_Internal_InjectedDelegate>("UnityEngine.PhysicsScene2D::CapsuleCastArray_Internal_Injected");
			PhysicsScene2D.CapsuleCastList_Internal_InjectedDelegateField = IL2CPP.ResolveICall<PhysicsScene2D.CapsuleCastList_Internal_InjectedDelegate>("UnityEngine.PhysicsScene2D::CapsuleCastList_Internal_Injected");
			PhysicsScene2D.GetRayIntersection_Internal_InjectedDelegateField = IL2CPP.ResolveICall<PhysicsScene2D.GetRayIntersection_Internal_InjectedDelegate>("UnityEngine.PhysicsScene2D::GetRayIntersection_Internal_Injected");
			PhysicsScene2D.GetRayIntersectionList_Internal_InjectedDelegateField = IL2CPP.ResolveICall<PhysicsScene2D.GetRayIntersectionList_Internal_InjectedDelegate>("UnityEngine.PhysicsScene2D::GetRayIntersectionList_Internal_Injected");
			PhysicsScene2D.OverlapPointArray_Internal_InjectedDelegateField = IL2CPP.ResolveICall<PhysicsScene2D.OverlapPointArray_Internal_InjectedDelegate>("UnityEngine.PhysicsScene2D::OverlapPointArray_Internal_Injected");
			PhysicsScene2D.OverlapPointList_Internal_InjectedDelegateField = IL2CPP.ResolveICall<PhysicsScene2D.OverlapPointList_Internal_InjectedDelegate>("UnityEngine.PhysicsScene2D::OverlapPointList_Internal_Injected");
			PhysicsScene2D.OverlapCircleList_Internal_InjectedDelegateField = IL2CPP.ResolveICall<PhysicsScene2D.OverlapCircleList_Internal_InjectedDelegate>("UnityEngine.PhysicsScene2D::OverlapCircleList_Internal_Injected");
			PhysicsScene2D.OverlapBoxList_Internal_InjectedDelegateField = IL2CPP.ResolveICall<PhysicsScene2D.OverlapBoxList_Internal_InjectedDelegate>("UnityEngine.PhysicsScene2D::OverlapBoxList_Internal_Injected");
			PhysicsScene2D.OverlapCapsule_Internal_InjectedDelegateField = IL2CPP.ResolveICall<PhysicsScene2D.OverlapCapsule_Internal_InjectedDelegate>("UnityEngine.PhysicsScene2D::OverlapCapsule_Internal_Injected");
			PhysicsScene2D.OverlapCapsuleArray_Internal_InjectedDelegateField = IL2CPP.ResolveICall<PhysicsScene2D.OverlapCapsuleArray_Internal_InjectedDelegate>("UnityEngine.PhysicsScene2D::OverlapCapsuleArray_Internal_Injected");
			PhysicsScene2D.OverlapCapsuleList_Internal_InjectedDelegateField = IL2CPP.ResolveICall<PhysicsScene2D.OverlapCapsuleList_Internal_InjectedDelegate>("UnityEngine.PhysicsScene2D::OverlapCapsuleList_Internal_Injected");
			PhysicsScene2D.OverlapColliderArray_Internal_InjectedDelegateField = IL2CPP.ResolveICall<PhysicsScene2D.OverlapColliderArray_Internal_InjectedDelegate>("UnityEngine.PhysicsScene2D::OverlapColliderArray_Internal_Injected");
			PhysicsScene2D.OverlapColliderList_Internal_InjectedDelegateField = IL2CPP.ResolveICall<PhysicsScene2D.OverlapColliderList_Internal_InjectedDelegate>("UnityEngine.PhysicsScene2D::OverlapColliderList_Internal_Injected");
		}

		// Token: 0x06000002 RID: 2 RVA: 0x000049A4 File Offset: 0x00002BA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512524, XrefRangeEnd = 512538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene2D.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000003 RID: 3 RVA: 0x000049D0 File Offset: 0x00002BD0
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene2D.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00004A00 File Offset: 0x00002C00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512538, XrefRangeEnd = 512540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene2D.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00004A44 File Offset: 0x00002C44
		[CallerCount(0)]
		public unsafe bool Equals(PhysicsScene2D other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene2D.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PhysicsScene2D_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00004A84 File Offset: 0x00002C84
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 512543, RefRangeEnd = 512545, XrefRangeStart = 512540, XrefRangeEnd = 512543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask = -5)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref origin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene2D.NativeMethodInfoPtr_Raycast_Public_RaycastHit2D_Vector2_Vector2_Single_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00004AEC File Offset: 0x00002CEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512545, XrefRangeEnd = 512547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref origin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref contactFilter;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene2D.NativeMethodInfoPtr_Raycast_Public_RaycastHit2D_Vector2_Vector2_Single_ContactFilter2D_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00004B54 File Offset: 0x00002D54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512547, XrefRangeEnd = 512549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RaycastHit2D Raycast_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref physicsScene;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref origin;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref contactFilter;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene2D.NativeMethodInfoPtr_Raycast_Internal_Private_Static_RaycastHit2D_PhysicsScene2D_Vector2_Vector2_Single_ContactFilter2D_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00004BCC File Offset: 0x00002DCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512549, XrefRangeEnd = 512551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Raycast(Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref origin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref contactFilter;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene2D.NativeMethodInfoPtr_Raycast_Public_Int32_Vector2_Vector2_Single_ContactFilter2D_Il2CppStructArray_1_RaycastHit2D_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00004C48 File Offset: 0x00002E48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512551, XrefRangeEnd = 512553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int RaycastArray_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref physicsScene;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref origin;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref contactFilter;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene2D.NativeMethodInfoPtr_RaycastArray_Internal_Private_Static_Int32_PhysicsScene2D_Vector2_Vector2_Single_ContactFilter2D_Il2CppStructArray_1_RaycastHit2D_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00004CD0 File Offset: 0x00002ED0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512553, XrefRangeEnd = 512555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Raycast(Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, List<RaycastHit2D> results)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref origin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref contactFilter;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene2D.NativeMethodInfoPtr_Raycast_Public_Int32_Vector2_Vector2_Single_ContactFilter2D_List_1_RaycastHit2D_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00004D4C File Offset: 0x00002F4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512555, XrefRangeEnd = 512557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int RaycastList_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, List<RaycastHit2D> results)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref physicsScene;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref origin;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref contactFilter;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene2D.NativeMethodInfoPtr_RaycastList_Internal_Private_Static_Int32_PhysicsScene2D_Vector2_Vector2_Single_ContactFilter2D_List_1_RaycastHit2D_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00004DD4 File Offset: 0x00002FD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512557, XrefRangeEnd = 512559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RaycastHit2D CircleCast(Vector2 origin, float radius, Vector2 direction, float distance, ContactFilter2D contactFilter)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref origin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radius;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref contactFilter;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene2D.NativeMethodInfoPtr_CircleCast_Public_RaycastHit2D_Vector2_Single_Vector2_Single_ContactFilter2D_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00004E4C File Offset: 0x0000304C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512559, XrefRangeEnd = 512561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RaycastHit2D CircleCast_Internal(PhysicsScene2D physicsScene, Vector2 origin, float radius, Vector2 direction, float distance, ContactFilter2D contactFilter)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref physicsScene;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref origin;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radius;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref contactFilter;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene2D.NativeMethodInfoPtr_CircleCast_Internal_Private_Static_RaycastHit2D_PhysicsScene2D_Vector2_Single_Vector2_Single_ContactFilter2D_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00004ED0 File Offset: 0x000030D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512561, XrefRangeEnd = 512563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CircleCast(Vector2 origin, float radius, Vector2 direction, float distance, ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref origin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radius;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref contactFilter;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene2D.NativeMethodInfoPtr_CircleCast_Public_Int32_Vector2_Single_Vector2_Single_ContactFilter2D_Il2CppStructArray_1_RaycastHit2D_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00004F58 File Offset: 0x00003158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512563, XrefRangeEnd = 512565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CircleCastArray_Internal(PhysicsScene2D physicsScene, Vector2 origin, float radius, Vector2 direction, float distance, ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref physicsScene;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref origin;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radius;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref contactFilter;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene2D.NativeMethodInfoPtr_CircleCastArray_Internal_Private_Static_Int32_PhysicsScene2D_Vector2_Single_Vector2_Single_ContactFilter2D_Il2CppStructArray_1_RaycastHit2D_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00004FF0 File Offset: 0x000031F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512565, XrefRangeEnd = 512567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetRayIntersection(Ray ray, float distance, Il2CppStructArray<RaycastHit2D> results, int layerMask = -5)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ray;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene2D.NativeMethodInfoPtr_GetRayIntersection_Public_Int32_Ray_Single_Il2CppStructArray_1_RaycastHit2D_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x0000505C File Offset: 0x0000325C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512567, XrefRangeEnd = 512569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetRayIntersectionArray_Internal(PhysicsScene2D physicsScene, Vector3 origin, Vector3 direction, float distance, int layerMask, Il2CppStructArray<RaycastHit2D> results)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref physicsScene;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref origin;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene2D.NativeMethodInfoPtr_GetRayIntersectionArray_Internal_Private_Static_Int32_PhysicsScene2D_Vector3_Vector3_Single_Int32_Il2CppStructArray_1_RaycastHit2D_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000050E4 File Offset: 0x000032E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512569, XrefRangeEnd = 512571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Collider2D OverlapPoint(Vector2 point, ContactFilter2D contactFilter)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref point;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref contactFilter;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene2D.NativeMethodInfoPtr_OverlapPoint_Public_Collider2D_Vector2_ContactFilter2D_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Collider2D>(intPtr3) : null;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00005134 File Offset: 0x00003334
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512571, XrefRangeEnd = 512573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Collider2D OverlapPoint_Internal(PhysicsScene2D physicsScene, Vector2 point, ContactFilter2D contactFilter)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref physicsScene;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref point;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref contactFilter;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene2D.NativeMethodInfoPtr_OverlapPoint_Internal_Private_Static_Collider2D_PhysicsScene2D_Vector2_ContactFilter2D_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Collider2D>(intPtr3) : null;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00005190 File Offset: 0x00003390
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512573, XrefRangeEnd = 512575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Collider2D OverlapCircle(Vector2 point, float radius, ContactFilter2D contactFilter)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref point;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radius;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref contactFilter;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene2D.NativeMethodInfoPtr_OverlapCircle_Public_Collider2D_Vector2_Single_ContactFilter2D_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Collider2D>(intPtr3) : null;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000051EC File Offset: 0x000033EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512575, XrefRangeEnd = 512577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Collider2D OverlapCircle_Internal(PhysicsScene2D physicsScene, Vector2 point, float radius, ContactFilter2D contactFilter)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref physicsScene;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref point;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radius;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref contactFilter;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene2D.NativeMethodInfoPtr_OverlapCircle_Internal_Private_Static_Collider2D_PhysicsScene2D_Vector2_Single_ContactFilter2D_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Collider2D>(intPtr3) : null;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00005258 File Offset: 0x00003458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512577, XrefRangeEnd = 512579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int OverlapCircle(Vector2 point, float radius, ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> results)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref point;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radius;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref contactFilter;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene2D.NativeMethodInfoPtr_OverlapCircle_Public_Int32_Vector2_Single_ContactFilter2D_Il2CppReferenceArray_1_Collider2D_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000052C4 File Offset: 0x000034C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512579, XrefRangeEnd = 512581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int OverlapCircleArray_Internal(PhysicsScene2D physicsScene, Vector2 point, float radius, ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> results)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref physicsScene;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref point;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radius;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref contactFilter;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene2D.NativeMethodInfoPtr_OverlapCircleArray_Internal_Private_Static_Int32_PhysicsScene2D_Vector2_Single_ContactFilter2D_Il2CppReferenceArray_1_Collider2D_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00005340 File Offset: 0x00003540
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512581, XrefRangeEnd = 512583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Collider2D OverlapBox(Vector2 point, Vector2 size, float angle, ContactFilter2D contactFilter)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref point;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref angle;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref contactFilter;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene2D.NativeMethodInfoPtr_OverlapBox_Public_Collider2D_Vector2_Vector2_Single_ContactFilter2D_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Collider2D>(intPtr3) : null;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000053AC File Offset: 0x000035AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512583, XrefRangeEnd = 512585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Collider2D OverlapBox_Internal(PhysicsScene2D physicsScene, Vector2 point, Vector2 size, float angle, ContactFilter2D contactFilter)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref physicsScene;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref point;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref angle;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref contactFilter;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene2D.NativeMethodInfoPtr_OverlapBox_Internal_Private_Static_Collider2D_PhysicsScene2D_Vector2_Vector2_Single_ContactFilter2D_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Collider2D>(intPtr3) : null;
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00005424 File Offset: 0x00003624
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512585, XrefRangeEnd = 512587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int OverlapBox(Vector2 point, Vector2 size, float angle, ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> results)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref point;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref angle;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref contactFilter;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene2D.NativeMethodInfoPtr_OverlapBox_Public_Int32_Vector2_Vector2_Single_ContactFilter2D_Il2CppReferenceArray_1_Collider2D_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000054A0 File Offset: 0x000036A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512587, XrefRangeEnd = 512589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int OverlapBoxArray_Internal(PhysicsScene2D physicsScene, Vector2 point, Vector2 size, float angle, ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> results)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref physicsScene;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref point;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref angle;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref contactFilter;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene2D.NativeMethodInfoPtr_OverlapBoxArray_Internal_Private_Static_Int32_PhysicsScene2D_Vector2_Vector2_Single_ContactFilter2D_Il2CppReferenceArray_1_Collider2D_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00005528 File Offset: 0x00003728
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512589, XrefRangeEnd = 512590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int OverlapArea(Vector2 pointA, Vector2 pointB, ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> results)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointA;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointB;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref contactFilter;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene2D.NativeMethodInfoPtr_OverlapArea_Public_Int32_Vector2_Vector2_ContactFilter2D_Il2CppReferenceArray_1_Collider2D_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00005594 File Offset: 0x00003794
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 512595, RefRangeEnd = 512597, XrefRangeStart = 512590, XrefRangeEnd = 512595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int OverlapAreaToBoxArray_Internal(Vector2 pointA, Vector2 pointB, ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> results)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointA;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointB;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref contactFilter;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene2D.NativeMethodInfoPtr_OverlapAreaToBoxArray_Internal_Private_Int32_Vector2_Vector2_ContactFilter2D_Il2CppReferenceArray_1_Collider2D_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00005600 File Offset: 0x00003800
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512597, XrefRangeEnd = 512601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Raycast_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, out RaycastHit2D ret)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &physicsScene;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &origin;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &direction;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &contactFilter;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene2D.NativeMethodInfoPtr_Raycast_Internal_Injected_Private_Static_Void_byref_PhysicsScene2D_byref_Vector2_byref_Vector2_Single_byref_ContactFilter2D_byref_RaycastHit2D_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000020 RID: 32 RVA: 0x0000567C File Offset: 0x0000387C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512601, XrefRangeEnd = 512605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int RaycastArray_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &physicsScene;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &origin;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &direction;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &contactFilter;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene2D.NativeMethodInfoPtr_RaycastArray_Internal_Injected_Private_Static_Int32_byref_PhysicsScene2D_byref_Vector2_byref_Vector2_Single_byref_ContactFilter2D_Il2CppStructArray_1_RaycastHit2D_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00005708 File Offset: 0x00003908
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512605, XrefRangeEnd = 512609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int RaycastList_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, List<RaycastHit2D> results)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &physicsScene;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &origin;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &direction;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &contactFilter;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene2D.NativeMethodInfoPtr_RaycastList_Internal_Injected_Private_Static_Int32_byref_PhysicsScene2D_byref_Vector2_byref_Vector2_Single_byref_ContactFilter2D_List_1_RaycastHit2D_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00005794 File Offset: 0x00003994
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512609, XrefRangeEnd = 512613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CircleCast_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, float radius, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, out RaycastHit2D ret)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &physicsScene;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &origin;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radius;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &direction;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &contactFilter;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene2D.NativeMethodInfoPtr_CircleCast_Internal_Injected_Private_Static_Void_byref_PhysicsScene2D_byref_Vector2_Single_byref_Vector2_Single_byref_ContactFilter2D_byref_RaycastHit2D_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x0000581C File Offset: 0x00003A1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512613, XrefRangeEnd = 512617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CircleCastArray_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, float radius, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &physicsScene;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &origin;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radius;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &direction;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &contactFilter;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene2D.NativeMethodInfoPtr_CircleCastArray_Internal_Injected_Private_Static_Int32_byref_PhysicsScene2D_byref_Vector2_Single_byref_Vector2_Single_byref_ContactFilter2D_Il2CppStructArray_1_RaycastHit2D_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000058B4 File Offset: 0x00003AB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512617, XrefRangeEnd = 512621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetRayIntersectionArray_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector3 origin, ref Vector3 direction, float distance, int layerMask, Il2CppStructArray<RaycastHit2D> results)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &physicsScene;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &origin;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &direction;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene2D.NativeMethodInfoPtr_GetRayIntersectionArray_Internal_Injected_Private_Static_Int32_byref_PhysicsScene2D_byref_Vector3_byref_Vector3_Single_Int32_Il2CppStructArray_1_RaycastHit2D_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x0000593C File Offset: 0x00003B3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512621, XrefRangeEnd = 512625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Collider2D OverlapPoint_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 point, ref ContactFilter2D contactFilter)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &physicsScene;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &point;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &contactFilter;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene2D.NativeMethodInfoPtr_OverlapPoint_Internal_Injected_Private_Static_Collider2D_byref_PhysicsScene2D_byref_Vector2_byref_ContactFilter2D_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Collider2D>(intPtr3) : null;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00005998 File Offset: 0x00003B98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512625, XrefRangeEnd = 512629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Collider2D OverlapCircle_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 point, float radius, ref ContactFilter2D contactFilter)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &physicsScene;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &point;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radius;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &contactFilter;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene2D.NativeMethodInfoPtr_OverlapCircle_Internal_Injected_Private_Static_Collider2D_byref_PhysicsScene2D_byref_Vector2_Single_byref_ContactFilter2D_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Collider2D>(intPtr3) : null;
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00005A04 File Offset: 0x00003C04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512629, XrefRangeEnd = 512633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int OverlapCircleArray_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 point, float radius, ref ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> results)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &physicsScene;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &point;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radius;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &contactFilter;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene2D.NativeMethodInfoPtr_OverlapCircleArray_Internal_Injected_Private_Static_Int32_byref_PhysicsScene2D_byref_Vector2_Single_byref_ContactFilter2D_Il2CppReferenceArray_1_Collider2D_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00005A80 File Offset: 0x00003C80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512633, XrefRangeEnd = 512637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Collider2D OverlapBox_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 point, ref Vector2 size, float angle, ref ContactFilter2D contactFilter)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &physicsScene;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &point;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &size;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref angle;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &contactFilter;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene2D.NativeMethodInfoPtr_OverlapBox_Internal_Injected_Private_Static_Collider2D_byref_PhysicsScene2D_byref_Vector2_byref_Vector2_Single_byref_ContactFilter2D_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Collider2D>(intPtr3) : null;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00005AFC File Offset: 0x00003CFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512637, XrefRangeEnd = 512641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int OverlapBoxArray_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 point, ref Vector2 size, float angle, ref ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> results)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &physicsScene;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &point;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &size;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref angle;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &contactFilter;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene2D.NativeMethodInfoPtr_OverlapBoxArray_Internal_Injected_Private_Static_Int32_byref_PhysicsScene2D_byref_Vector2_byref_Vector2_Single_byref_ContactFilter2D_Il2CppReferenceArray_1_Collider2D_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002050 File Offset: 0x00000250
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PhysicsScene2D>.NativeClassPtr, ref this));
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00005B88 File Offset: 0x00003D88
		public static bool operator ==(PhysicsScene2D lhs, PhysicsScene2D rhs)
		{
			return lhs.m_Handle == rhs.m_Handle;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00005BA8 File Offset: 0x00003DA8
		public static bool operator !=(PhysicsScene2D lhs, PhysicsScene2D rhs)
		{
			return lhs.m_Handle != rhs.m_Handle;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00005BCC File Offset: 0x00003DCC
		public bool IsValid()
		{
			return PhysicsScene2D.IsValid_Internal(this);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002062 File Offset: 0x00000262
		public static bool IsValid_Internal(PhysicsScene2D physicsScene)
		{
			return PhysicsScene2D.IsValid_Internal_Injected(ref physicsScene);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00005BEC File Offset: 0x00003DEC
		public bool IsEmpty()
		{
			bool flag = this.IsValid();
			if (flag)
			{
				return PhysicsScene2D.IsEmpty_Internal(this);
			}
			throw new InvalidOperationException("Cannot check if physics scene is empty as it is invalid.");
		}

		// Token: 0x06000030 RID: 48 RVA: 0x0000206B File Offset: 0x0000026B
		public static bool IsEmpty_Internal(PhysicsScene2D physicsScene)
		{
			return PhysicsScene2D.IsEmpty_Internal_Injected(ref physicsScene);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00005C20 File Offset: 0x00003E20
		public bool Simulate(float step)
		{
			bool flag = this.IsValid();
			if (flag)
			{
				return Physics2D.Simulate_Internal(this, step);
			}
			throw new InvalidOperationException("Cannot simulate the physics scene as it is invalid.");
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00005C54 File Offset: 0x00003E54
		public RaycastHit2D Linecast(Vector2 start, Vector2 end, [Optional] int layerMask)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
			return PhysicsScene2D.Linecast_Internal(this, start, end, contactFilter2D);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00005C88 File Offset: 0x00003E88
		public RaycastHit2D Linecast(Vector2 start, Vector2 end, ContactFilter2D contactFilter)
		{
			return PhysicsScene2D.Linecast_Internal(this, start, end, contactFilter);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00005CA8 File Offset: 0x00003EA8
		public static RaycastHit2D Linecast_Internal(PhysicsScene2D physicsScene, Vector2 start, Vector2 end, ContactFilter2D contactFilter)
		{
			RaycastHit2D raycastHit2D;
			PhysicsScene2D.Linecast_Internal_Injected(ref physicsScene, ref start, ref end, ref contactFilter, out raycastHit2D);
			return raycastHit2D;
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00005CC8 File Offset: 0x00003EC8
		public int Linecast(Vector2 start, Vector2 end, Il2CppStructArray<RaycastHit2D> results, [Optional] int layerMask)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
			return PhysicsScene2D.LinecastArray_Internal(this, start, end, contactFilter2D, results);
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00005CFC File Offset: 0x00003EFC
		public int Linecast(Vector2 start, Vector2 end, ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results)
		{
			return PhysicsScene2D.LinecastArray_Internal(this, start, end, contactFilter, results);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002074 File Offset: 0x00000274
		public static int LinecastArray_Internal(PhysicsScene2D physicsScene, Vector2 start, Vector2 end, ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results)
		{
			return PhysicsScene2D.LinecastArray_Internal_Injected(ref physicsScene, ref start, ref end, ref contactFilter, results);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00005D20 File Offset: 0x00003F20
		public int Linecast(Vector2 start, Vector2 end, ContactFilter2D contactFilter, List<RaycastHit2D> results)
		{
			return PhysicsScene2D.LinecastNonAllocList_Internal(this, start, end, contactFilter, results);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002085 File Offset: 0x00000285
		public static int LinecastNonAllocList_Internal(PhysicsScene2D physicsScene, Vector2 start, Vector2 end, ContactFilter2D contactFilter, List<RaycastHit2D> results)
		{
			return PhysicsScene2D.LinecastNonAllocList_Internal_Injected(ref physicsScene, ref start, ref end, ref contactFilter, results);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00005D44 File Offset: 0x00003F44
		public int Raycast(Vector2 origin, Vector2 direction, float distance, Il2CppStructArray<RaycastHit2D> results, [Optional] int layerMask)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
			return PhysicsScene2D.RaycastArray_Internal(this, origin, direction, distance, contactFilter2D, results);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00005D7C File Offset: 0x00003F7C
		public RaycastHit2D CircleCast(Vector2 origin, float radius, Vector2 direction, float distance, [Optional] int layerMask)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
			return PhysicsScene2D.CircleCast_Internal(this, origin, radius, direction, distance, contactFilter2D);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00005DB4 File Offset: 0x00003FB4
		public int CircleCast(Vector2 origin, float radius, Vector2 direction, float distance, Il2CppStructArray<RaycastHit2D> results, [Optional] int layerMask)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
			return PhysicsScene2D.CircleCastArray_Internal(this, origin, radius, direction, distance, contactFilter2D, results);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00005DEC File Offset: 0x00003FEC
		public int CircleCast(Vector2 origin, float radius, Vector2 direction, float distance, ContactFilter2D contactFilter, List<RaycastHit2D> results)
		{
			return PhysicsScene2D.CircleCastList_Internal(this, origin, radius, direction, distance, contactFilter, results);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002096 File Offset: 0x00000296
		public static int CircleCastList_Internal(PhysicsScene2D physicsScene, Vector2 origin, float radius, Vector2 direction, float distance, ContactFilter2D contactFilter, List<RaycastHit2D> results)
		{
			return PhysicsScene2D.CircleCastList_Internal_Injected(ref physicsScene, ref origin, radius, ref direction, distance, ref contactFilter, results);
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00005E14 File Offset: 0x00004014
		public RaycastHit2D BoxCast(Vector2 origin, Vector2 size, float angle, Vector2 direction, float distance, [Optional] int layerMask)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
			return PhysicsScene2D.BoxCast_Internal(this, origin, size, angle, direction, distance, contactFilter2D);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00005E4C File Offset: 0x0000404C
		public RaycastHit2D BoxCast(Vector2 origin, Vector2 size, float angle, Vector2 direction, float distance, ContactFilter2D contactFilter)
		{
			return PhysicsScene2D.BoxCast_Internal(this, origin, size, angle, direction, distance, contactFilter);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00005E74 File Offset: 0x00004074
		public static RaycastHit2D BoxCast_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 size, float angle, Vector2 direction, float distance, ContactFilter2D contactFilter)
		{
			RaycastHit2D raycastHit2D;
			PhysicsScene2D.BoxCast_Internal_Injected(ref physicsScene, ref origin, ref size, angle, ref direction, distance, ref contactFilter, out raycastHit2D);
			return raycastHit2D;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00005E98 File Offset: 0x00004098
		public int BoxCast(Vector2 origin, Vector2 size, float angle, Vector2 direction, float distance, Il2CppStructArray<RaycastHit2D> results, [Optional] int layerMask)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
			return PhysicsScene2D.BoxCastArray_Internal(this, origin, size, angle, direction, distance, contactFilter2D, results);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00005ED4 File Offset: 0x000040D4
		public int BoxCast(Vector2 origin, Vector2 size, float angle, Vector2 direction, float distance, ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results)
		{
			return PhysicsScene2D.BoxCastArray_Internal(this, origin, size, angle, direction, distance, contactFilter, results);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x000020AA File Offset: 0x000002AA
		public static int BoxCastArray_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 size, float angle, Vector2 direction, float distance, ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results)
		{
			return PhysicsScene2D.BoxCastArray_Internal_Injected(ref physicsScene, ref origin, ref size, angle, ref direction, distance, ref contactFilter, results);
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00005EFC File Offset: 0x000040FC
		public int BoxCast(Vector2 origin, Vector2 size, float angle, Vector2 direction, float distance, ContactFilter2D contactFilter, List<RaycastHit2D> results)
		{
			return PhysicsScene2D.BoxCastList_Internal(this, origin, size, angle, direction, distance, contactFilter, results);
		}

		// Token: 0x06000046 RID: 70 RVA: 0x000020C0 File Offset: 0x000002C0
		public static int BoxCastList_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 size, float angle, Vector2 direction, float distance, ContactFilter2D contactFilter, List<RaycastHit2D> results)
		{
			return PhysicsScene2D.BoxCastList_Internal_Injected(ref physicsScene, ref origin, ref size, angle, ref direction, distance, ref contactFilter, results);
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00005F24 File Offset: 0x00004124
		public RaycastHit2D CapsuleCast(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, float distance, [Optional] int layerMask)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
			return PhysicsScene2D.CapsuleCast_Internal(this, origin, size, capsuleDirection, angle, direction, distance, contactFilter2D);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00005F60 File Offset: 0x00004160
		public RaycastHit2D CapsuleCast(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, float distance, ContactFilter2D contactFilter)
		{
			return PhysicsScene2D.CapsuleCast_Internal(this, origin, size, capsuleDirection, angle, direction, distance, contactFilter);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00005F88 File Offset: 0x00004188
		public static RaycastHit2D CapsuleCast_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, float distance, ContactFilter2D contactFilter)
		{
			RaycastHit2D raycastHit2D;
			PhysicsScene2D.CapsuleCast_Internal_Injected(ref physicsScene, ref origin, ref size, capsuleDirection, angle, ref direction, distance, ref contactFilter, out raycastHit2D);
			return raycastHit2D;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00005FAC File Offset: 0x000041AC
		public int CapsuleCast(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, float distance, Il2CppStructArray<RaycastHit2D> results, [Optional] int layerMask)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
			return PhysicsScene2D.CapsuleCastArray_Internal(this, origin, size, capsuleDirection, angle, direction, distance, contactFilter2D, results);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00005FE8 File Offset: 0x000041E8
		public int CapsuleCast(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, float distance, ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results)
		{
			return PhysicsScene2D.CapsuleCastArray_Internal(this, origin, size, capsuleDirection, angle, direction, distance, contactFilter, results);
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00006014 File Offset: 0x00004214
		public static int CapsuleCastArray_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, float distance, ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results)
		{
			return PhysicsScene2D.CapsuleCastArray_Internal_Injected(ref physicsScene, ref origin, ref size, capsuleDirection, angle, ref direction, distance, ref contactFilter, results);
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00006038 File Offset: 0x00004238
		public int CapsuleCast(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, float distance, ContactFilter2D contactFilter, List<RaycastHit2D> results)
		{
			return PhysicsScene2D.CapsuleCastList_Internal(this, origin, size, capsuleDirection, angle, direction, distance, contactFilter, results);
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00006064 File Offset: 0x00004264
		public static int CapsuleCastList_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, float distance, ContactFilter2D contactFilter, List<RaycastHit2D> results)
		{
			return PhysicsScene2D.CapsuleCastList_Internal_Injected(ref physicsScene, ref origin, ref size, capsuleDirection, angle, ref direction, distance, ref contactFilter, results);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00006088 File Offset: 0x00004288
		public RaycastHit2D GetRayIntersection(Ray ray, float distance, [Optional] int layerMask)
		{
			return PhysicsScene2D.GetRayIntersection_Internal(this, ray.origin, ray.direction, distance, layerMask);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x000060B8 File Offset: 0x000042B8
		public static RaycastHit2D GetRayIntersection_Internal(PhysicsScene2D physicsScene, Vector3 origin, Vector3 direction, float distance, int layerMask)
		{
			RaycastHit2D raycastHit2D;
			PhysicsScene2D.GetRayIntersection_Internal_Injected(ref physicsScene, ref origin, ref direction, distance, layerMask, out raycastHit2D);
			return raycastHit2D;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x000020D6 File Offset: 0x000002D6
		public static int GetRayIntersectionList_Internal(PhysicsScene2D physicsScene, Vector3 origin, Vector3 direction, float distance, int layerMask, List<RaycastHit2D> results)
		{
			return PhysicsScene2D.GetRayIntersectionList_Internal_Injected(ref physicsScene, ref origin, ref direction, distance, layerMask, results);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x000060D8 File Offset: 0x000042D8
		public Collider2D OverlapPoint(Vector2 point, [Optional] int layerMask)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
			return PhysicsScene2D.OverlapPoint_Internal(this, point, contactFilter2D);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00006108 File Offset: 0x00004308
		public int OverlapPoint(Vector2 point, Il2CppReferenceArray<Collider2D> results, [Optional] int layerMask)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
			return PhysicsScene2D.OverlapPointArray_Internal(this, point, contactFilter2D, results);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x0000613C File Offset: 0x0000433C
		public int OverlapPoint(Vector2 point, ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> results)
		{
			return PhysicsScene2D.OverlapPointArray_Internal(this, point, contactFilter, results);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x000020E8 File Offset: 0x000002E8
		public static int OverlapPointArray_Internal(PhysicsScene2D physicsScene, Vector2 point, ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> results)
		{
			return PhysicsScene2D.OverlapPointArray_Internal_Injected(ref physicsScene, ref point, ref contactFilter, results);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x0000615C File Offset: 0x0000435C
		public int OverlapPoint(Vector2 point, ContactFilter2D contactFilter, List<Collider2D> results)
		{
			return PhysicsScene2D.OverlapPointList_Internal(this, point, contactFilter, results);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x000020F6 File Offset: 0x000002F6
		public static int OverlapPointList_Internal(PhysicsScene2D physicsScene, Vector2 point, ContactFilter2D contactFilter, List<Collider2D> results)
		{
			return PhysicsScene2D.OverlapPointList_Internal_Injected(ref physicsScene, ref point, ref contactFilter, results);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x0000617C File Offset: 0x0000437C
		public Collider2D OverlapCircle(Vector2 point, float radius, [Optional] int layerMask)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
			return PhysicsScene2D.OverlapCircle_Internal(this, point, radius, contactFilter2D);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x000061B0 File Offset: 0x000043B0
		public int OverlapCircle(Vector2 point, float radius, Il2CppReferenceArray<Collider2D> results, [Optional] int layerMask)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
			return PhysicsScene2D.OverlapCircleArray_Internal(this, point, radius, contactFilter2D, results);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x000061E4 File Offset: 0x000043E4
		public int OverlapCircle(Vector2 point, float radius, ContactFilter2D contactFilter, List<Collider2D> results)
		{
			return PhysicsScene2D.OverlapCircleList_Internal(this, point, radius, contactFilter, results);
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00002104 File Offset: 0x00000304
		public static int OverlapCircleList_Internal(PhysicsScene2D physicsScene, Vector2 point, float radius, ContactFilter2D contactFilter, List<Collider2D> results)
		{
			return PhysicsScene2D.OverlapCircleList_Internal_Injected(ref physicsScene, ref point, radius, ref contactFilter, results);
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00006208 File Offset: 0x00004408
		public Collider2D OverlapBox(Vector2 point, Vector2 size, float angle, [Optional] int layerMask)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
			return PhysicsScene2D.OverlapBox_Internal(this, point, size, angle, contactFilter2D);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x0000623C File Offset: 0x0000443C
		public int OverlapBox(Vector2 point, Vector2 size, float angle, Il2CppReferenceArray<Collider2D> results, [Optional] int layerMask)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
			return PhysicsScene2D.OverlapBoxArray_Internal(this, point, size, angle, contactFilter2D, results);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00006274 File Offset: 0x00004474
		public int OverlapBox(Vector2 point, Vector2 size, float angle, ContactFilter2D contactFilter, List<Collider2D> results)
		{
			return PhysicsScene2D.OverlapBoxList_Internal(this, point, size, angle, contactFilter, results);
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00002114 File Offset: 0x00000314
		public static int OverlapBoxList_Internal(PhysicsScene2D physicsScene, Vector2 point, Vector2 size, float angle, ContactFilter2D contactFilter, List<Collider2D> results)
		{
			return PhysicsScene2D.OverlapBoxList_Internal_Injected(ref physicsScene, ref point, ref size, angle, ref contactFilter, results);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00006298 File Offset: 0x00004498
		public Collider2D OverlapArea(Vector2 pointA, Vector2 pointB, [Optional] int layerMask)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
			return this.OverlapAreaToBoxArray_Internal(pointA, pointB, contactFilter2D);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x000062C4 File Offset: 0x000044C4
		public Collider2D OverlapArea(Vector2 pointA, Vector2 pointB, ContactFilter2D contactFilter)
		{
			return this.OverlapAreaToBoxArray_Internal(pointA, pointB, contactFilter);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x000062E0 File Offset: 0x000044E0
		public Collider2D OverlapAreaToBoxArray_Internal(Vector2 pointA, Vector2 pointB, ContactFilter2D contactFilter)
		{
			Vector2 vector = (pointA + pointB) * 0.5f;
			Vector2 vector2 = new Vector2(Mathf.Abs(pointA.x - pointB.x), Math.Abs(pointA.y - pointB.y));
			return this.OverlapBox(vector, vector2, 0f, contactFilter);
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00006340 File Offset: 0x00004540
		public int OverlapArea(Vector2 pointA, Vector2 pointB, Il2CppReferenceArray<Collider2D> results, [Optional] int layerMask)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
			return this.OverlapAreaToBoxArray_Internal(pointA, pointB, contactFilter2D, results);
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00006370 File Offset: 0x00004570
		public int OverlapArea(Vector2 pointA, Vector2 pointB, ContactFilter2D contactFilter, List<Collider2D> results)
		{
			return this.OverlapAreaToBoxList_Internal(pointA, pointB, contactFilter, results);
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00006390 File Offset: 0x00004590
		public int OverlapAreaToBoxList_Internal(Vector2 pointA, Vector2 pointB, ContactFilter2D contactFilter, List<Collider2D> results)
		{
			Vector2 vector = (pointA + pointB) * 0.5f;
			Vector2 vector2 = new Vector2(Mathf.Abs(pointA.x - pointB.x), Math.Abs(pointA.y - pointB.y));
			return this.OverlapBox(vector, vector2, 0f, contactFilter, results);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x000063F0 File Offset: 0x000045F0
		public Collider2D OverlapCapsule(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, [Optional] int layerMask)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
			return PhysicsScene2D.OverlapCapsule_Internal(this, point, size, direction, angle, contactFilter2D);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00006428 File Offset: 0x00004628
		public Collider2D OverlapCapsule(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, ContactFilter2D contactFilter)
		{
			return PhysicsScene2D.OverlapCapsule_Internal(this, point, size, direction, angle, contactFilter);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00002126 File Offset: 0x00000326
		public static Collider2D OverlapCapsule_Internal(PhysicsScene2D physicsScene, Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, ContactFilter2D contactFilter)
		{
			return PhysicsScene2D.OverlapCapsule_Internal_Injected(ref physicsScene, ref point, ref size, direction, angle, ref contactFilter);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x0000644C File Offset: 0x0000464C
		public int OverlapCapsule(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, Il2CppReferenceArray<Collider2D> results, [Optional] int layerMask)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
			return PhysicsScene2D.OverlapCapsuleArray_Internal(this, point, size, direction, angle, contactFilter2D, results);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00006484 File Offset: 0x00004684
		public int OverlapCapsule(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> results)
		{
			return PhysicsScene2D.OverlapCapsuleArray_Internal(this, point, size, direction, angle, contactFilter, results);
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00002138 File Offset: 0x00000338
		public static int OverlapCapsuleArray_Internal(PhysicsScene2D physicsScene, Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> results)
		{
			return PhysicsScene2D.OverlapCapsuleArray_Internal_Injected(ref physicsScene, ref point, ref size, direction, angle, ref contactFilter, results);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x000064AC File Offset: 0x000046AC
		public int OverlapCapsule(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, ContactFilter2D contactFilter, List<Collider2D> results)
		{
			return PhysicsScene2D.OverlapCapsuleList_Internal(this, point, size, direction, angle, contactFilter, results);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x0000214C File Offset: 0x0000034C
		public static int OverlapCapsuleList_Internal(PhysicsScene2D physicsScene, Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, ContactFilter2D contactFilter, List<Collider2D> results)
		{
			return PhysicsScene2D.OverlapCapsuleList_Internal_Injected(ref physicsScene, ref point, ref size, direction, angle, ref contactFilter, results);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x000064D4 File Offset: 0x000046D4
		public static int OverlapCollider(Collider2D collider, Il2CppReferenceArray<Collider2D> results, [Optional] int layerMask)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
			return PhysicsScene2D.OverlapColliderArray_Internal(collider, contactFilter2D, results);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00006500 File Offset: 0x00004700
		public static int OverlapCollider(Collider2D collider, ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> results)
		{
			return PhysicsScene2D.OverlapColliderArray_Internal(collider, contactFilter, results);
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00002160 File Offset: 0x00000360
		public static int OverlapColliderArray_Internal(Collider2D collider, ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> results)
		{
			return PhysicsScene2D.OverlapColliderArray_Internal_Injected(collider, ref contactFilter, results);
		}

		// Token: 0x06000071 RID: 113 RVA: 0x0000651C File Offset: 0x0000471C
		public static int OverlapCollider(Collider2D collider, ContactFilter2D contactFilter, List<Collider2D> results)
		{
			return PhysicsScene2D.OverlapColliderList_Internal(collider, contactFilter, results);
		}

		// Token: 0x06000072 RID: 114 RVA: 0x0000216B File Offset: 0x0000036B
		public static int OverlapColliderList_Internal(Collider2D collider, ContactFilter2D contactFilter, List<Collider2D> results)
		{
			return PhysicsScene2D.OverlapColliderList_Internal_Injected(collider, ref contactFilter, results);
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00002176 File Offset: 0x00000376
		public static bool IsValid_Internal_Injected(ref PhysicsScene2D physicsScene)
		{
			return PhysicsScene2D.IsValid_Internal_InjectedDelegateField(ref physicsScene);
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00002183 File Offset: 0x00000383
		public static bool IsEmpty_Internal_Injected(ref PhysicsScene2D physicsScene)
		{
			return PhysicsScene2D.IsEmpty_Internal_InjectedDelegateField(ref physicsScene);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00002190 File Offset: 0x00000390
		public static void Linecast_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 start, ref Vector2 end, ref ContactFilter2D contactFilter, out RaycastHit2D ret)
		{
			PhysicsScene2D.Linecast_Internal_InjectedDelegateField(ref physicsScene, ref start, ref end, ref contactFilter, out ret);
		}

		// Token: 0x06000076 RID: 118 RVA: 0x000021A2 File Offset: 0x000003A2
		public static int LinecastArray_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 start, ref Vector2 end, ref ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results)
		{
			return PhysicsScene2D.LinecastArray_Internal_InjectedDelegateField(ref physicsScene, ref start, ref end, ref contactFilter, IL2CPP.Il2CppObjectBaseToPtr(results));
		}

		// Token: 0x06000077 RID: 119 RVA: 0x000021B9 File Offset: 0x000003B9
		public static int LinecastNonAllocList_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 start, ref Vector2 end, ref ContactFilter2D contactFilter, List<RaycastHit2D> results)
		{
			return PhysicsScene2D.LinecastNonAllocList_Internal_InjectedDelegateField(ref physicsScene, ref start, ref end, ref contactFilter, IL2CPP.Il2CppObjectBaseToPtr(results));
		}

		// Token: 0x06000078 RID: 120 RVA: 0x000021D0 File Offset: 0x000003D0
		public static int CircleCastList_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, float radius, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, List<RaycastHit2D> results)
		{
			return PhysicsScene2D.CircleCastList_Internal_InjectedDelegateField(ref physicsScene, ref origin, radius, ref direction, distance, ref contactFilter, IL2CPP.Il2CppObjectBaseToPtr(results));
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00006538 File Offset: 0x00004738
		public static void BoxCast_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, ref Vector2 size, float angle, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, out RaycastHit2D ret)
		{
			PhysicsScene2D.BoxCast_Internal_InjectedDelegateField(ref physicsScene, ref origin, ref size, angle, ref direction, distance, ref contactFilter, out ret);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x0000655C File Offset: 0x0000475C
		public static int BoxCastArray_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, ref Vector2 size, float angle, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results)
		{
			return PhysicsScene2D.BoxCastArray_Internal_InjectedDelegateField(ref physicsScene, ref origin, ref size, angle, ref direction, distance, ref contactFilter, IL2CPP.Il2CppObjectBaseToPtr(results));
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00006584 File Offset: 0x00004784
		public static int BoxCastList_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, ref Vector2 size, float angle, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, List<RaycastHit2D> results)
		{
			return PhysicsScene2D.BoxCastList_Internal_InjectedDelegateField(ref physicsScene, ref origin, ref size, angle, ref direction, distance, ref contactFilter, IL2CPP.Il2CppObjectBaseToPtr(results));
		}

		// Token: 0x0600007C RID: 124 RVA: 0x000065AC File Offset: 0x000047AC
		public static void CapsuleCast_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, ref Vector2 size, CapsuleDirection2D capsuleDirection, float angle, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, out RaycastHit2D ret)
		{
			PhysicsScene2D.CapsuleCast_Internal_InjectedDelegateField(ref physicsScene, ref origin, ref size, capsuleDirection, angle, ref direction, distance, ref contactFilter, out ret);
		}

		// Token: 0x0600007D RID: 125 RVA: 0x000065D4 File Offset: 0x000047D4
		public static int CapsuleCastArray_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, ref Vector2 size, CapsuleDirection2D capsuleDirection, float angle, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results)
		{
			return PhysicsScene2D.CapsuleCastArray_Internal_InjectedDelegateField(ref physicsScene, ref origin, ref size, capsuleDirection, angle, ref direction, distance, ref contactFilter, IL2CPP.Il2CppObjectBaseToPtr(results));
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00006600 File Offset: 0x00004800
		public static int CapsuleCastList_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, ref Vector2 size, CapsuleDirection2D capsuleDirection, float angle, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, List<RaycastHit2D> results)
		{
			return PhysicsScene2D.CapsuleCastList_Internal_InjectedDelegateField(ref physicsScene, ref origin, ref size, capsuleDirection, angle, ref direction, distance, ref contactFilter, IL2CPP.Il2CppObjectBaseToPtr(results));
		}

		// Token: 0x0600007F RID: 127 RVA: 0x000021EB File Offset: 0x000003EB
		public static void GetRayIntersection_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector3 origin, ref Vector3 direction, float distance, int layerMask, out RaycastHit2D ret)
		{
			PhysicsScene2D.GetRayIntersection_Internal_InjectedDelegateField(ref physicsScene, ref origin, ref direction, distance, layerMask, out ret);
		}

		// Token: 0x06000080 RID: 128 RVA: 0x000021FF File Offset: 0x000003FF
		public static int GetRayIntersectionList_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector3 origin, ref Vector3 direction, float distance, int layerMask, List<RaycastHit2D> results)
		{
			return PhysicsScene2D.GetRayIntersectionList_Internal_InjectedDelegateField(ref physicsScene, ref origin, ref direction, distance, layerMask, IL2CPP.Il2CppObjectBaseToPtr(results));
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00002218 File Offset: 0x00000418
		public static int OverlapPointArray_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 point, ref ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> results)
		{
			return PhysicsScene2D.OverlapPointArray_Internal_InjectedDelegateField(ref physicsScene, ref point, ref contactFilter, IL2CPP.Il2CppObjectBaseToPtr(results));
		}

		// Token: 0x06000082 RID: 130 RVA: 0x0000222D File Offset: 0x0000042D
		public static int OverlapPointList_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 point, ref ContactFilter2D contactFilter, List<Collider2D> results)
		{
			return PhysicsScene2D.OverlapPointList_Internal_InjectedDelegateField(ref physicsScene, ref point, ref contactFilter, IL2CPP.Il2CppObjectBaseToPtr(results));
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00002242 File Offset: 0x00000442
		public static int OverlapCircleList_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 point, float radius, ref ContactFilter2D contactFilter, List<Collider2D> results)
		{
			return PhysicsScene2D.OverlapCircleList_Internal_InjectedDelegateField(ref physicsScene, ref point, radius, ref contactFilter, IL2CPP.Il2CppObjectBaseToPtr(results));
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00002259 File Offset: 0x00000459
		public static int OverlapBoxList_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 point, ref Vector2 size, float angle, ref ContactFilter2D contactFilter, List<Collider2D> results)
		{
			return PhysicsScene2D.OverlapBoxList_Internal_InjectedDelegateField(ref physicsScene, ref point, ref size, angle, ref contactFilter, IL2CPP.Il2CppObjectBaseToPtr(results));
		}

		// Token: 0x06000085 RID: 133 RVA: 0x0000662C File Offset: 0x0000482C
		public static Collider2D OverlapCapsule_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 point, ref Vector2 size, CapsuleDirection2D direction, float angle, ref ContactFilter2D contactFilter)
		{
			IntPtr intPtr = PhysicsScene2D.OverlapCapsule_Internal_InjectedDelegateField(ref physicsScene, ref point, ref size, direction, angle, ref contactFilter);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider2D>(intPtr2) : null;
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00002272 File Offset: 0x00000472
		public static int OverlapCapsuleArray_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 point, ref Vector2 size, CapsuleDirection2D direction, float angle, ref ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> results)
		{
			return PhysicsScene2D.OverlapCapsuleArray_Internal_InjectedDelegateField(ref physicsScene, ref point, ref size, direction, angle, ref contactFilter, IL2CPP.Il2CppObjectBaseToPtr(results));
		}

		// Token: 0x06000087 RID: 135 RVA: 0x0000228D File Offset: 0x0000048D
		public static int OverlapCapsuleList_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 point, ref Vector2 size, CapsuleDirection2D direction, float angle, ref ContactFilter2D contactFilter, List<Collider2D> results)
		{
			return PhysicsScene2D.OverlapCapsuleList_Internal_InjectedDelegateField(ref physicsScene, ref point, ref size, direction, angle, ref contactFilter, IL2CPP.Il2CppObjectBaseToPtr(results));
		}

		// Token: 0x06000088 RID: 136 RVA: 0x000022A8 File Offset: 0x000004A8
		public static int OverlapColliderArray_Internal_Injected(Collider2D collider, ref ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> results)
		{
			return PhysicsScene2D.OverlapColliderArray_Internal_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(collider), ref contactFilter, IL2CPP.Il2CppObjectBaseToPtr(results));
		}

		// Token: 0x06000089 RID: 137 RVA: 0x000022C1 File Offset: 0x000004C1
		public static int OverlapColliderList_Internal_Injected(Collider2D collider, ref ContactFilter2D contactFilter, List<Collider2D> results)
		{
			return PhysicsScene2D.OverlapColliderList_Internal_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(collider), ref contactFilter, IL2CPP.Il2CppObjectBaseToPtr(results));
		}

		// Token: 0x04000001 RID: 1
		private static readonly IntPtr NativeFieldInfoPtr_m_Handle;

		// Token: 0x04000002 RID: 2
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000003 RID: 3
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000004 RID: 4
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000005 RID: 5
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PhysicsScene2D_0;

		// Token: 0x04000006 RID: 6
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_RaycastHit2D_Vector2_Vector2_Single_Int32_0;

		// Token: 0x04000007 RID: 7
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_RaycastHit2D_Vector2_Vector2_Single_ContactFilter2D_0;

		// Token: 0x04000008 RID: 8
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Internal_Private_Static_RaycastHit2D_PhysicsScene2D_Vector2_Vector2_Single_ContactFilter2D_0;

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Int32_Vector2_Vector2_Single_ContactFilter2D_Il2CppStructArray_1_RaycastHit2D_0;

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeMethodInfoPtr_RaycastArray_Internal_Private_Static_Int32_PhysicsScene2D_Vector2_Vector2_Single_ContactFilter2D_Il2CppStructArray_1_RaycastHit2D_0;

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Int32_Vector2_Vector2_Single_ContactFilter2D_List_1_RaycastHit2D_0;

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeMethodInfoPtr_RaycastList_Internal_Private_Static_Int32_PhysicsScene2D_Vector2_Vector2_Single_ContactFilter2D_List_1_RaycastHit2D_0;

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeMethodInfoPtr_CircleCast_Public_RaycastHit2D_Vector2_Single_Vector2_Single_ContactFilter2D_0;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeMethodInfoPtr_CircleCast_Internal_Private_Static_RaycastHit2D_PhysicsScene2D_Vector2_Single_Vector2_Single_ContactFilter2D_0;

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeMethodInfoPtr_CircleCast_Public_Int32_Vector2_Single_Vector2_Single_ContactFilter2D_Il2CppStructArray_1_RaycastHit2D_0;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeMethodInfoPtr_CircleCastArray_Internal_Private_Static_Int32_PhysicsScene2D_Vector2_Single_Vector2_Single_ContactFilter2D_Il2CppStructArray_1_RaycastHit2D_0;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeMethodInfoPtr_GetRayIntersection_Public_Int32_Ray_Single_Il2CppStructArray_1_RaycastHit2D_Int32_0;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeMethodInfoPtr_GetRayIntersectionArray_Internal_Private_Static_Int32_PhysicsScene2D_Vector3_Vector3_Single_Int32_Il2CppStructArray_1_RaycastHit2D_0;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeMethodInfoPtr_OverlapPoint_Public_Collider2D_Vector2_ContactFilter2D_0;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeMethodInfoPtr_OverlapPoint_Internal_Private_Static_Collider2D_PhysicsScene2D_Vector2_ContactFilter2D_0;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeMethodInfoPtr_OverlapCircle_Public_Collider2D_Vector2_Single_ContactFilter2D_0;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeMethodInfoPtr_OverlapCircle_Internal_Private_Static_Collider2D_PhysicsScene2D_Vector2_Single_ContactFilter2D_0;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeMethodInfoPtr_OverlapCircle_Public_Int32_Vector2_Single_ContactFilter2D_Il2CppReferenceArray_1_Collider2D_0;

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeMethodInfoPtr_OverlapCircleArray_Internal_Private_Static_Int32_PhysicsScene2D_Vector2_Single_ContactFilter2D_Il2CppReferenceArray_1_Collider2D_0;

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeMethodInfoPtr_OverlapBox_Public_Collider2D_Vector2_Vector2_Single_ContactFilter2D_0;

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeMethodInfoPtr_OverlapBox_Internal_Private_Static_Collider2D_PhysicsScene2D_Vector2_Vector2_Single_ContactFilter2D_0;

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeMethodInfoPtr_OverlapBox_Public_Int32_Vector2_Vector2_Single_ContactFilter2D_Il2CppReferenceArray_1_Collider2D_0;

		// Token: 0x0400001C RID: 28
		private static readonly IntPtr NativeMethodInfoPtr_OverlapBoxArray_Internal_Private_Static_Int32_PhysicsScene2D_Vector2_Vector2_Single_ContactFilter2D_Il2CppReferenceArray_1_Collider2D_0;

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeMethodInfoPtr_OverlapArea_Public_Int32_Vector2_Vector2_ContactFilter2D_Il2CppReferenceArray_1_Collider2D_0;

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeMethodInfoPtr_OverlapAreaToBoxArray_Internal_Private_Int32_Vector2_Vector2_ContactFilter2D_Il2CppReferenceArray_1_Collider2D_0;

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Internal_Injected_Private_Static_Void_byref_PhysicsScene2D_byref_Vector2_byref_Vector2_Single_byref_ContactFilter2D_byref_RaycastHit2D_0;

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeMethodInfoPtr_RaycastArray_Internal_Injected_Private_Static_Int32_byref_PhysicsScene2D_byref_Vector2_byref_Vector2_Single_byref_ContactFilter2D_Il2CppStructArray_1_RaycastHit2D_0;

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeMethodInfoPtr_RaycastList_Internal_Injected_Private_Static_Int32_byref_PhysicsScene2D_byref_Vector2_byref_Vector2_Single_byref_ContactFilter2D_List_1_RaycastHit2D_0;

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeMethodInfoPtr_CircleCast_Internal_Injected_Private_Static_Void_byref_PhysicsScene2D_byref_Vector2_Single_byref_Vector2_Single_byref_ContactFilter2D_byref_RaycastHit2D_0;

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeMethodInfoPtr_CircleCastArray_Internal_Injected_Private_Static_Int32_byref_PhysicsScene2D_byref_Vector2_Single_byref_Vector2_Single_byref_ContactFilter2D_Il2CppStructArray_1_RaycastHit2D_0;

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeMethodInfoPtr_GetRayIntersectionArray_Internal_Injected_Private_Static_Int32_byref_PhysicsScene2D_byref_Vector3_byref_Vector3_Single_Int32_Il2CppStructArray_1_RaycastHit2D_0;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeMethodInfoPtr_OverlapPoint_Internal_Injected_Private_Static_Collider2D_byref_PhysicsScene2D_byref_Vector2_byref_ContactFilter2D_0;

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeMethodInfoPtr_OverlapCircle_Internal_Injected_Private_Static_Collider2D_byref_PhysicsScene2D_byref_Vector2_Single_byref_ContactFilter2D_0;

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeMethodInfoPtr_OverlapCircleArray_Internal_Injected_Private_Static_Int32_byref_PhysicsScene2D_byref_Vector2_Single_byref_ContactFilter2D_Il2CppReferenceArray_1_Collider2D_0;

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeMethodInfoPtr_OverlapBox_Internal_Injected_Private_Static_Collider2D_byref_PhysicsScene2D_byref_Vector2_byref_Vector2_Single_byref_ContactFilter2D_0;

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeMethodInfoPtr_OverlapBoxArray_Internal_Injected_Private_Static_Int32_byref_PhysicsScene2D_byref_Vector2_byref_Vector2_Single_byref_ContactFilter2D_Il2CppReferenceArray_1_Collider2D_0;

		// Token: 0x0400002A RID: 42
		[FieldOffset(0)]
		public int m_Handle;

		// Token: 0x0400002B RID: 43
		private static readonly PhysicsScene2D.IsValid_Internal_InjectedDelegate IsValid_Internal_InjectedDelegateField;

		// Token: 0x0400002C RID: 44
		private static readonly PhysicsScene2D.IsEmpty_Internal_InjectedDelegate IsEmpty_Internal_InjectedDelegateField;

		// Token: 0x0400002D RID: 45
		private static readonly PhysicsScene2D.Linecast_Internal_InjectedDelegate Linecast_Internal_InjectedDelegateField;

		// Token: 0x0400002E RID: 46
		private static readonly PhysicsScene2D.LinecastArray_Internal_InjectedDelegate LinecastArray_Internal_InjectedDelegateField;

		// Token: 0x0400002F RID: 47
		private static readonly PhysicsScene2D.LinecastNonAllocList_Internal_InjectedDelegate LinecastNonAllocList_Internal_InjectedDelegateField;

		// Token: 0x04000030 RID: 48
		private static readonly PhysicsScene2D.CircleCastList_Internal_InjectedDelegate CircleCastList_Internal_InjectedDelegateField;

		// Token: 0x04000031 RID: 49
		private static readonly PhysicsScene2D.BoxCast_Internal_InjectedDelegate BoxCast_Internal_InjectedDelegateField;

		// Token: 0x04000032 RID: 50
		private static readonly PhysicsScene2D.BoxCastArray_Internal_InjectedDelegate BoxCastArray_Internal_InjectedDelegateField;

		// Token: 0x04000033 RID: 51
		private static readonly PhysicsScene2D.BoxCastList_Internal_InjectedDelegate BoxCastList_Internal_InjectedDelegateField;

		// Token: 0x04000034 RID: 52
		private static readonly PhysicsScene2D.CapsuleCast_Internal_InjectedDelegate CapsuleCast_Internal_InjectedDelegateField;

		// Token: 0x04000035 RID: 53
		private static readonly PhysicsScene2D.CapsuleCastArray_Internal_InjectedDelegate CapsuleCastArray_Internal_InjectedDelegateField;

		// Token: 0x04000036 RID: 54
		private static readonly PhysicsScene2D.CapsuleCastList_Internal_InjectedDelegate CapsuleCastList_Internal_InjectedDelegateField;

		// Token: 0x04000037 RID: 55
		private static readonly PhysicsScene2D.GetRayIntersection_Internal_InjectedDelegate GetRayIntersection_Internal_InjectedDelegateField;

		// Token: 0x04000038 RID: 56
		private static readonly PhysicsScene2D.GetRayIntersectionList_Internal_InjectedDelegate GetRayIntersectionList_Internal_InjectedDelegateField;

		// Token: 0x04000039 RID: 57
		private static readonly PhysicsScene2D.OverlapPointArray_Internal_InjectedDelegate OverlapPointArray_Internal_InjectedDelegateField;

		// Token: 0x0400003A RID: 58
		private static readonly PhysicsScene2D.OverlapPointList_Internal_InjectedDelegate OverlapPointList_Internal_InjectedDelegateField;

		// Token: 0x0400003B RID: 59
		private static readonly PhysicsScene2D.OverlapCircleList_Internal_InjectedDelegate OverlapCircleList_Internal_InjectedDelegateField;

		// Token: 0x0400003C RID: 60
		private static readonly PhysicsScene2D.OverlapBoxList_Internal_InjectedDelegate OverlapBoxList_Internal_InjectedDelegateField;

		// Token: 0x0400003D RID: 61
		private static readonly PhysicsScene2D.OverlapCapsule_Internal_InjectedDelegate OverlapCapsule_Internal_InjectedDelegateField;

		// Token: 0x0400003E RID: 62
		private static readonly PhysicsScene2D.OverlapCapsuleArray_Internal_InjectedDelegate OverlapCapsuleArray_Internal_InjectedDelegateField;

		// Token: 0x0400003F RID: 63
		private static readonly PhysicsScene2D.OverlapCapsuleList_Internal_InjectedDelegate OverlapCapsuleList_Internal_InjectedDelegateField;

		// Token: 0x04000040 RID: 64
		private static readonly PhysicsScene2D.OverlapColliderArray_Internal_InjectedDelegate OverlapColliderArray_Internal_InjectedDelegateField;

		// Token: 0x04000041 RID: 65
		private static readonly PhysicsScene2D.OverlapColliderList_Internal_InjectedDelegate OverlapColliderList_Internal_InjectedDelegateField;

		// Token: 0x02000031 RID: 49
		// (Invoke) Token: 0x0600043C RID: 1084
		private delegate bool IsValid_Internal_InjectedDelegate(IntPtr physicsScene);

		// Token: 0x02000032 RID: 50
		// (Invoke) Token: 0x0600043E RID: 1086
		private delegate bool IsEmpty_Internal_InjectedDelegate(IntPtr physicsScene);

		// Token: 0x02000033 RID: 51
		// (Invoke) Token: 0x06000440 RID: 1088
		private delegate void Linecast_Internal_InjectedDelegate(IntPtr physicsScene, IntPtr start, IntPtr end, IntPtr contactFilter, [Out] IntPtr ret);

		// Token: 0x02000034 RID: 52
		// (Invoke) Token: 0x06000442 RID: 1090
		private delegate int LinecastArray_Internal_InjectedDelegate(IntPtr physicsScene, IntPtr start, IntPtr end, IntPtr contactFilter, IntPtr results);

		// Token: 0x02000035 RID: 53
		// (Invoke) Token: 0x06000444 RID: 1092
		private delegate int LinecastNonAllocList_Internal_InjectedDelegate(IntPtr physicsScene, IntPtr start, IntPtr end, IntPtr contactFilter, IntPtr results);

		// Token: 0x02000036 RID: 54
		// (Invoke) Token: 0x06000446 RID: 1094
		private delegate int CircleCastList_Internal_InjectedDelegate(IntPtr physicsScene, IntPtr origin, float radius, IntPtr direction, float distance, IntPtr contactFilter, IntPtr results);

		// Token: 0x02000037 RID: 55
		// (Invoke) Token: 0x06000448 RID: 1096
		private delegate void BoxCast_Internal_InjectedDelegate(IntPtr physicsScene, IntPtr origin, IntPtr size, float angle, IntPtr direction, float distance, IntPtr contactFilter, [Out] IntPtr ret);

		// Token: 0x02000038 RID: 56
		// (Invoke) Token: 0x0600044A RID: 1098
		private delegate int BoxCastArray_Internal_InjectedDelegate(IntPtr physicsScene, IntPtr origin, IntPtr size, float angle, IntPtr direction, float distance, IntPtr contactFilter, IntPtr results);

		// Token: 0x02000039 RID: 57
		// (Invoke) Token: 0x0600044C RID: 1100
		private delegate int BoxCastList_Internal_InjectedDelegate(IntPtr physicsScene, IntPtr origin, IntPtr size, float angle, IntPtr direction, float distance, IntPtr contactFilter, IntPtr results);

		// Token: 0x0200003A RID: 58
		// (Invoke) Token: 0x0600044E RID: 1102
		private delegate void CapsuleCast_Internal_InjectedDelegate(IntPtr physicsScene, IntPtr origin, IntPtr size, CapsuleDirection2D capsuleDirection, float angle, IntPtr direction, float distance, IntPtr contactFilter, [Out] IntPtr ret);

		// Token: 0x0200003B RID: 59
		// (Invoke) Token: 0x06000450 RID: 1104
		private delegate int CapsuleCastArray_Internal_InjectedDelegate(IntPtr physicsScene, IntPtr origin, IntPtr size, CapsuleDirection2D capsuleDirection, float angle, IntPtr direction, float distance, IntPtr contactFilter, IntPtr results);

		// Token: 0x0200003C RID: 60
		// (Invoke) Token: 0x06000452 RID: 1106
		private delegate int CapsuleCastList_Internal_InjectedDelegate(IntPtr physicsScene, IntPtr origin, IntPtr size, CapsuleDirection2D capsuleDirection, float angle, IntPtr direction, float distance, IntPtr contactFilter, IntPtr results);

		// Token: 0x0200003D RID: 61
		// (Invoke) Token: 0x06000454 RID: 1108
		private delegate void GetRayIntersection_Internal_InjectedDelegate(IntPtr physicsScene, IntPtr origin, IntPtr direction, float distance, int layerMask, [Out] IntPtr ret);

		// Token: 0x0200003E RID: 62
		// (Invoke) Token: 0x06000456 RID: 1110
		private delegate int GetRayIntersectionList_Internal_InjectedDelegate(IntPtr physicsScene, IntPtr origin, IntPtr direction, float distance, int layerMask, IntPtr results);

		// Token: 0x0200003F RID: 63
		// (Invoke) Token: 0x06000458 RID: 1112
		private delegate int OverlapPointArray_Internal_InjectedDelegate(IntPtr physicsScene, IntPtr point, IntPtr contactFilter, IntPtr results);

		// Token: 0x02000040 RID: 64
		// (Invoke) Token: 0x0600045A RID: 1114
		private delegate int OverlapPointList_Internal_InjectedDelegate(IntPtr physicsScene, IntPtr point, IntPtr contactFilter, IntPtr results);

		// Token: 0x02000041 RID: 65
		// (Invoke) Token: 0x0600045C RID: 1116
		private delegate int OverlapCircleList_Internal_InjectedDelegate(IntPtr physicsScene, IntPtr point, float radius, IntPtr contactFilter, IntPtr results);

		// Token: 0x02000042 RID: 66
		// (Invoke) Token: 0x0600045E RID: 1118
		private delegate int OverlapBoxList_Internal_InjectedDelegate(IntPtr physicsScene, IntPtr point, IntPtr size, float angle, IntPtr contactFilter, IntPtr results);

		// Token: 0x02000043 RID: 67
		// (Invoke) Token: 0x06000460 RID: 1120
		private delegate IntPtr OverlapCapsule_Internal_InjectedDelegate(IntPtr physicsScene, IntPtr point, IntPtr size, CapsuleDirection2D direction, float angle, IntPtr contactFilter);

		// Token: 0x02000044 RID: 68
		// (Invoke) Token: 0x06000462 RID: 1122
		private delegate int OverlapCapsuleArray_Internal_InjectedDelegate(IntPtr physicsScene, IntPtr point, IntPtr size, CapsuleDirection2D direction, float angle, IntPtr contactFilter, IntPtr results);

		// Token: 0x02000045 RID: 69
		// (Invoke) Token: 0x06000464 RID: 1124
		private delegate int OverlapCapsuleList_Internal_InjectedDelegate(IntPtr physicsScene, IntPtr point, IntPtr size, CapsuleDirection2D direction, float angle, IntPtr contactFilter, IntPtr results);

		// Token: 0x02000046 RID: 70
		// (Invoke) Token: 0x06000466 RID: 1126
		private delegate int OverlapColliderArray_Internal_InjectedDelegate(IntPtr collider, IntPtr contactFilter, IntPtr results);

		// Token: 0x02000047 RID: 71
		// (Invoke) Token: 0x06000468 RID: 1128
		private delegate int OverlapColliderList_Internal_InjectedDelegate(IntPtr collider, IntPtr contactFilter, IntPtr results);
	}
}
