using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000011 RID: 17
	[StructLayout(2)]
	public struct PhysicsScene
	{
		// Token: 0x0600015B RID: 347 RVA: 0x00006D40 File Offset: 0x00004F40
		// Note: this type is marked as 'beforefieldinit'.
		static PhysicsScene()
		{
			Il2CppClassPointerStore<PhysicsScene>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.PhysicsModule.dll", "UnityEngine", "PhysicsScene");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhysicsScene>.NativeClassPtr);
			PhysicsScene.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsScene>.NativeClassPtr, "m_Handle");
			PhysicsScene.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene>.NativeClassPtr, 100663363);
			PhysicsScene.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene>.NativeClassPtr, 100663364);
			PhysicsScene.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene>.NativeClassPtr, 100663365);
			PhysicsScene.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PhysicsScene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene>.NativeClassPtr, 100663366);
			PhysicsScene.NativeMethodInfoPtr_Raycast_Public_Boolean_Vector3_Vector3_Single_Int32_QueryTriggerInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene>.NativeClassPtr, 100663367);
			PhysicsScene.NativeMethodInfoPtr_Internal_RaycastTest_Private_Static_Boolean_PhysicsScene_Ray_Single_Int32_QueryTriggerInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene>.NativeClassPtr, 100663368);
			PhysicsScene.NativeMethodInfoPtr_Raycast_Public_Boolean_Vector3_Vector3_byref_RaycastHit_Single_Int32_QueryTriggerInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene>.NativeClassPtr, 100663369);
			PhysicsScene.NativeMethodInfoPtr_Internal_Raycast_Private_Static_Boolean_PhysicsScene_Ray_Single_byref_RaycastHit_Int32_QueryTriggerInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene>.NativeClassPtr, 100663370);
			PhysicsScene.NativeMethodInfoPtr_Raycast_Public_Int32_Vector3_Vector3_Il2CppStructArray_1_RaycastHit_Single_Int32_QueryTriggerInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene>.NativeClassPtr, 100663371);
			PhysicsScene.NativeMethodInfoPtr_Internal_RaycastNonAlloc_Private_Static_Int32_PhysicsScene_Ray_Il2CppStructArray_1_RaycastHit_Single_Int32_QueryTriggerInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene>.NativeClassPtr, 100663372);
			PhysicsScene.NativeMethodInfoPtr_Internal_RaycastTest_Injected_Private_Static_Boolean_byref_PhysicsScene_byref_Ray_Single_Int32_QueryTriggerInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene>.NativeClassPtr, 100663373);
			PhysicsScene.NativeMethodInfoPtr_Internal_Raycast_Injected_Private_Static_Boolean_byref_PhysicsScene_byref_Ray_Single_byref_RaycastHit_Int32_QueryTriggerInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene>.NativeClassPtr, 100663374);
			PhysicsScene.NativeMethodInfoPtr_Internal_RaycastNonAlloc_Injected_Private_Static_Int32_byref_PhysicsScene_byref_Ray_Il2CppStructArray_1_RaycastHit_Single_Int32_QueryTriggerInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene>.NativeClassPtr, 100663375);
			PhysicsScene.IsValid_Internal_InjectedDelegateField = IL2CPP.ResolveICall<PhysicsScene.IsValid_Internal_InjectedDelegate>("UnityEngine.PhysicsScene::IsValid_Internal_Injected");
			PhysicsScene.IsEmpty_Internal_InjectedDelegateField = IL2CPP.ResolveICall<PhysicsScene.IsEmpty_Internal_InjectedDelegate>("UnityEngine.PhysicsScene::IsEmpty_Internal_Injected");
			PhysicsScene.Query_CapsuleCast_InjectedDelegateField = IL2CPP.ResolveICall<PhysicsScene.Query_CapsuleCast_InjectedDelegate>("UnityEngine.PhysicsScene::Query_CapsuleCast_Injected");
			PhysicsScene.Internal_CapsuleCastNonAlloc_InjectedDelegateField = IL2CPP.ResolveICall<PhysicsScene.Internal_CapsuleCastNonAlloc_InjectedDelegate>("UnityEngine.PhysicsScene::Internal_CapsuleCastNonAlloc_Injected");
			PhysicsScene.OverlapCapsuleNonAlloc_Internal_InjectedDelegateField = IL2CPP.ResolveICall<PhysicsScene.OverlapCapsuleNonAlloc_Internal_InjectedDelegate>("UnityEngine.PhysicsScene::OverlapCapsuleNonAlloc_Internal_Injected");
			PhysicsScene.Query_SphereCast_InjectedDelegateField = IL2CPP.ResolveICall<PhysicsScene.Query_SphereCast_InjectedDelegate>("UnityEngine.PhysicsScene::Query_SphereCast_Injected");
			PhysicsScene.Internal_SphereCastNonAlloc_InjectedDelegateField = IL2CPP.ResolveICall<PhysicsScene.Internal_SphereCastNonAlloc_InjectedDelegate>("UnityEngine.PhysicsScene::Internal_SphereCastNonAlloc_Injected");
			PhysicsScene.OverlapSphereNonAlloc_Internal_InjectedDelegateField = IL2CPP.ResolveICall<PhysicsScene.OverlapSphereNonAlloc_Internal_InjectedDelegate>("UnityEngine.PhysicsScene::OverlapSphereNonAlloc_Internal_Injected");
			PhysicsScene.Query_BoxCast_InjectedDelegateField = IL2CPP.ResolveICall<PhysicsScene.Query_BoxCast_InjectedDelegate>("UnityEngine.PhysicsScene::Query_BoxCast_Injected");
			PhysicsScene.OverlapBoxNonAlloc_Internal_InjectedDelegateField = IL2CPP.ResolveICall<PhysicsScene.OverlapBoxNonAlloc_Internal_InjectedDelegate>("UnityEngine.PhysicsScene::OverlapBoxNonAlloc_Internal_Injected");
			PhysicsScene.Internal_BoxCastNonAlloc_InjectedDelegateField = IL2CPP.ResolveICall<PhysicsScene.Internal_BoxCastNonAlloc_InjectedDelegate>("UnityEngine.PhysicsScene::Internal_BoxCastNonAlloc_Injected");
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00006F30 File Offset: 0x00005130
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513715, XrefRangeEnd = 513729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00006F5C File Offset: 0x0000515C
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00006F8C File Offset: 0x0000518C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513729, XrefRangeEnd = 513731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00006FD0 File Offset: 0x000051D0
		[CallerCount(0)]
		public unsafe bool Equals(PhysicsScene other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PhysicsScene_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00007010 File Offset: 0x00005210
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 513739, RefRangeEnd = 513747, XrefRangeStart = 513731, XrefRangeEnd = 513739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Raycast(Vector3 origin, Vector3 direction, float maxDistance = float.PositiveInfinity, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref origin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref queryTriggerInteraction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene.NativeMethodInfoPtr_Raycast_Public_Boolean_Vector3_Vector3_Single_Int32_QueryTriggerInteraction_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00007088 File Offset: 0x00005288
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513747, XrefRangeEnd = 513749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Internal_RaycastTest(PhysicsScene physicsScene, Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref physicsScene;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ray;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref queryTriggerInteraction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene.NativeMethodInfoPtr_Internal_RaycastTest_Private_Static_Boolean_PhysicsScene_Ray_Single_Int32_QueryTriggerInteraction_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00007100 File Offset: 0x00005300
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 513757, RefRangeEnd = 513765, XrefRangeStart = 513749, XrefRangeEnd = 513757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance = float.PositiveInfinity, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref origin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hitInfo;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref queryTriggerInteraction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene.NativeMethodInfoPtr_Raycast_Public_Boolean_Vector3_Vector3_byref_RaycastHit_Single_Int32_QueryTriggerInteraction_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00007184 File Offset: 0x00005384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513765, XrefRangeEnd = 513767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Internal_Raycast(PhysicsScene physicsScene, Ray ray, float maxDistance, ref RaycastHit hit, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref physicsScene;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ray;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hit;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref queryTriggerInteraction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene.NativeMethodInfoPtr_Internal_Raycast_Private_Static_Boolean_PhysicsScene_Ray_Single_byref_RaycastHit_Int32_QueryTriggerInteraction_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00007208 File Offset: 0x00005408
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 513776, RefRangeEnd = 513785, XrefRangeStart = 513767, XrefRangeEnd = 513776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Raycast(Vector3 origin, Vector3 direction, Il2CppStructArray<RaycastHit> raycastHits, float maxDistance = float.PositiveInfinity, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref origin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(raycastHits);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref queryTriggerInteraction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene.NativeMethodInfoPtr_Raycast_Public_Int32_Vector3_Vector3_Il2CppStructArray_1_RaycastHit_Single_Int32_QueryTriggerInteraction_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00007290 File Offset: 0x00005490
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513785, XrefRangeEnd = 513787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Internal_RaycastNonAlloc(PhysicsScene physicsScene, Ray ray, Il2CppStructArray<RaycastHit> raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref physicsScene;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ray;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(raycastHits);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mask;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref queryTriggerInteraction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene.NativeMethodInfoPtr_Internal_RaycastNonAlloc_Private_Static_Int32_PhysicsScene_Ray_Il2CppStructArray_1_RaycastHit_Single_Int32_QueryTriggerInteraction_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00007318 File Offset: 0x00005518
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513787, XrefRangeEnd = 513791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Internal_RaycastTest_Injected(ref PhysicsScene physicsScene, ref Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &physicsScene;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ray;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref queryTriggerInteraction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene.NativeMethodInfoPtr_Internal_RaycastTest_Injected_Private_Static_Boolean_byref_PhysicsScene_byref_Ray_Single_Int32_QueryTriggerInteraction_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00007390 File Offset: 0x00005590
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513791, XrefRangeEnd = 513795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Internal_Raycast_Injected(ref PhysicsScene physicsScene, ref Ray ray, float maxDistance, ref RaycastHit hit, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &physicsScene;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ray;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hit;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref queryTriggerInteraction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene.NativeMethodInfoPtr_Internal_Raycast_Injected_Private_Static_Boolean_byref_PhysicsScene_byref_Ray_Single_byref_RaycastHit_Int32_QueryTriggerInteraction_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00007414 File Offset: 0x00005614
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513795, XrefRangeEnd = 513799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Internal_RaycastNonAlloc_Injected(ref PhysicsScene physicsScene, ref Ray ray, Il2CppStructArray<RaycastHit> raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &physicsScene;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ray;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(raycastHits);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mask;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref queryTriggerInteraction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsScene.NativeMethodInfoPtr_Internal_RaycastNonAlloc_Injected_Private_Static_Int32_byref_PhysicsScene_byref_Ray_Il2CppStructArray_1_RaycastHit_Single_Int32_QueryTriggerInteraction_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00002CBC File Offset: 0x00000EBC
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PhysicsScene>.NativeClassPtr, ref this));
		}

		// Token: 0x0600016A RID: 362 RVA: 0x0000749C File Offset: 0x0000569C
		public static bool operator ==(PhysicsScene lhs, PhysicsScene rhs)
		{
			return lhs.m_Handle == rhs.m_Handle;
		}

		// Token: 0x0600016B RID: 363 RVA: 0x000074BC File Offset: 0x000056BC
		public static bool operator !=(PhysicsScene lhs, PhysicsScene rhs)
		{
			return lhs.m_Handle != rhs.m_Handle;
		}

		// Token: 0x0600016C RID: 364 RVA: 0x000074E0 File Offset: 0x000056E0
		public bool IsValid()
		{
			return PhysicsScene.IsValid_Internal(this);
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00002CCE File Offset: 0x00000ECE
		public static bool IsValid_Internal(PhysicsScene physicsScene)
		{
			return PhysicsScene.IsValid_Internal_Injected(ref physicsScene);
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00007500 File Offset: 0x00005700
		public bool IsEmpty()
		{
			bool flag = this.IsValid();
			if (flag)
			{
				return PhysicsScene.IsEmpty_Internal(this);
			}
			throw new InvalidOperationException("Cannot check if physics scene is empty as it is invalid.");
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00002CD7 File Offset: 0x00000ED7
		public static bool IsEmpty_Internal(PhysicsScene physicsScene)
		{
			return PhysicsScene.IsEmpty_Internal_Injected(ref physicsScene);
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00007534 File Offset: 0x00005734
		public void Simulate(float step)
		{
			bool flag = this.IsValid();
			if (flag)
			{
				bool flag2 = this == Physics.defaultPhysicsScene && Physics.autoSimulation;
				if (flag2)
				{
					Debug.LogWarning("PhysicsScene.Simulate(...) was called but auto simulation is active. You should disable auto simulation first before calling this function therefore the simulation was not run.");
				}
				else
				{
					Physics.Simulate_Internal(this, step);
				}
				return;
			}
			throw new InvalidOperationException("Cannot simulate the physics scene as it is invalid.");
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00007594 File Offset: 0x00005794
		public static bool Query_CapsuleCast(PhysicsScene physicsScene, Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance, ref RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return PhysicsScene.Query_CapsuleCast_Injected(ref physicsScene, ref point1, ref point2, radius, ref direction, maxDistance, ref hitInfo, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06000172 RID: 370 RVA: 0x000075B8 File Offset: 0x000057B8
		public static bool Internal_CapsuleCast(PhysicsScene physicsScene, Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			float magnitude = direction.magnitude;
			hitInfo = default(RaycastHit);
			bool flag = magnitude > float.Epsilon;
			bool flag2;
			if (flag)
			{
				Vector3 vector = direction / magnitude;
				flag2 = PhysicsScene.Query_CapsuleCast(physicsScene, point1, point2, radius, vector, maxDistance, ref hitInfo, layerMask, queryTriggerInteraction);
			}
			else
			{
				flag2 = false;
			}
			return flag2;
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00007608 File Offset: 0x00005808
		public bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, [Optional] float maxDistance, [Optional] int layerMask, [Optional] QueryTriggerInteraction queryTriggerInteraction)
		{
			return PhysicsScene.Internal_CapsuleCast(this, point1, point2, radius, direction, out hitInfo, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00007634 File Offset: 0x00005834
		public static int Internal_CapsuleCastNonAlloc(PhysicsScene physicsScene, Vector3 p0, Vector3 p1, float radius, Vector3 direction, Il2CppStructArray<RaycastHit> raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return PhysicsScene.Internal_CapsuleCastNonAlloc_Injected(ref physicsScene, ref p0, ref p1, radius, ref direction, raycastHits, maxDistance, mask, queryTriggerInteraction);
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00007658 File Offset: 0x00005858
		public int CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, Il2CppStructArray<RaycastHit> results, [Optional] float maxDistance, [Optional] int layerMask, [Optional] QueryTriggerInteraction queryTriggerInteraction)
		{
			float magnitude = direction.magnitude;
			bool flag = magnitude > float.Epsilon;
			int num;
			if (flag)
			{
				num = PhysicsScene.Internal_CapsuleCastNonAlloc(this, point1, point2, radius, direction, results, maxDistance, layerMask, queryTriggerInteraction);
			}
			else
			{
				num = 0;
			}
			return num;
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00002CE0 File Offset: 0x00000EE0
		public static int OverlapCapsuleNonAlloc_Internal(PhysicsScene physicsScene, Vector3 point0, Vector3 point1, float radius, Il2CppReferenceArray<Collider> results, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return PhysicsScene.OverlapCapsuleNonAlloc_Internal_Injected(ref physicsScene, ref point0, ref point1, radius, results, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06000177 RID: 375 RVA: 0x0000769C File Offset: 0x0000589C
		public int OverlapCapsule(Vector3 point0, Vector3 point1, float radius, Il2CppReferenceArray<Collider> results, [Optional] int layerMask, [Optional] QueryTriggerInteraction queryTriggerInteraction)
		{
			return PhysicsScene.OverlapCapsuleNonAlloc_Internal(this, point0, point1, radius, results, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00002CF4 File Offset: 0x00000EF4
		public static bool Query_SphereCast(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, float maxDistance, ref RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return PhysicsScene.Query_SphereCast_Injected(ref physicsScene, ref origin, radius, ref direction, maxDistance, ref hitInfo, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06000179 RID: 377 RVA: 0x000076C4 File Offset: 0x000058C4
		public static bool Internal_SphereCast(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			float magnitude = direction.magnitude;
			hitInfo = default(RaycastHit);
			bool flag = magnitude > float.Epsilon;
			bool flag2;
			if (flag)
			{
				Vector3 vector = direction / magnitude;
				flag2 = PhysicsScene.Query_SphereCast(physicsScene, origin, radius, vector, maxDistance, ref hitInfo, layerMask, queryTriggerInteraction);
			}
			else
			{
				flag2 = false;
			}
			return flag2;
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00007710 File Offset: 0x00005910
		public bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, [Optional] float maxDistance, [Optional] int layerMask, [Optional] QueryTriggerInteraction queryTriggerInteraction)
		{
			return PhysicsScene.Internal_SphereCast(this, origin, radius, direction, out hitInfo, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00002D0A File Offset: 0x00000F0A
		public static int Internal_SphereCastNonAlloc(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, Il2CppStructArray<RaycastHit> raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return PhysicsScene.Internal_SphereCastNonAlloc_Injected(ref physicsScene, ref origin, radius, ref direction, raycastHits, maxDistance, mask, queryTriggerInteraction);
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00007738 File Offset: 0x00005938
		public int SphereCast(Vector3 origin, float radius, Vector3 direction, Il2CppStructArray<RaycastHit> results, [Optional] float maxDistance, [Optional] int layerMask, [Optional] QueryTriggerInteraction queryTriggerInteraction)
		{
			float magnitude = direction.magnitude;
			bool flag = magnitude > float.Epsilon;
			int num;
			if (flag)
			{
				num = PhysicsScene.Internal_SphereCastNonAlloc(this, origin, radius, direction, results, maxDistance, layerMask, queryTriggerInteraction);
			}
			else
			{
				num = 0;
			}
			return num;
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00002D20 File Offset: 0x00000F20
		public static int OverlapSphereNonAlloc_Internal(PhysicsScene physicsScene, Vector3 position, float radius, Il2CppReferenceArray<Collider> results, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return PhysicsScene.OverlapSphereNonAlloc_Internal_Injected(ref physicsScene, ref position, radius, results, layerMask, queryTriggerInteraction);
		}

		// Token: 0x0600017E RID: 382 RVA: 0x0000777C File Offset: 0x0000597C
		public int OverlapSphere(Vector3 position, float radius, Il2CppReferenceArray<Collider> results, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return PhysicsScene.OverlapSphereNonAlloc_Internal(this, position, radius, results, layerMask, queryTriggerInteraction);
		}

		// Token: 0x0600017F RID: 383 RVA: 0x000077A0 File Offset: 0x000059A0
		public static bool Query_BoxCast(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance, ref RaycastHit outHit, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return PhysicsScene.Query_BoxCast_Injected(ref physicsScene, ref center, ref halfExtents, ref direction, ref orientation, maxDistance, ref outHit, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06000180 RID: 384 RVA: 0x000077C4 File Offset: 0x000059C4
		public static bool Internal_BoxCast(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Quaternion orientation, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			float magnitude = direction.magnitude;
			hitInfo = default(RaycastHit);
			bool flag = magnitude > float.Epsilon;
			bool flag2;
			if (flag)
			{
				Vector3 vector = direction / magnitude;
				flag2 = PhysicsScene.Query_BoxCast(physicsScene, center, halfExtents, vector, orientation, maxDistance, ref hitInfo, layerMask, queryTriggerInteraction);
			}
			else
			{
				flag2 = false;
			}
			return flag2;
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00007814 File Offset: 0x00005A14
		public bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo, Quaternion orientation, [Optional] float maxDistance, [Optional] int layerMask, [Optional] QueryTriggerInteraction queryTriggerInteraction)
		{
			return PhysicsScene.Internal_BoxCast(this, center, halfExtents, orientation, direction, out hitInfo, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00007840 File Offset: 0x00005A40
		public bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo)
		{
			return PhysicsScene.Internal_BoxCast(this, center, halfExtents, Quaternion.identity, direction, out hitInfo, float.PositiveInfinity, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00002D31 File Offset: 0x00000F31
		public static int OverlapBoxNonAlloc_Internal(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Il2CppReferenceArray<Collider> results, Quaternion orientation, int mask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return PhysicsScene.OverlapBoxNonAlloc_Internal_Injected(ref physicsScene, ref center, ref halfExtents, results, ref orientation, mask, queryTriggerInteraction);
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00007870 File Offset: 0x00005A70
		public int OverlapBox(Vector3 center, Vector3 halfExtents, Il2CppReferenceArray<Collider> results, Quaternion orientation, [Optional] int layerMask, [Optional] QueryTriggerInteraction queryTriggerInteraction)
		{
			return PhysicsScene.OverlapBoxNonAlloc_Internal(this, center, halfExtents, results, orientation, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00007898 File Offset: 0x00005A98
		public int OverlapBox(Vector3 center, Vector3 halfExtents, Il2CppReferenceArray<Collider> results)
		{
			return PhysicsScene.OverlapBoxNonAlloc_Internal(this, center, halfExtents, results, Quaternion.identity, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x06000186 RID: 390 RVA: 0x000078C0 File Offset: 0x00005AC0
		public static int Internal_BoxCastNonAlloc(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Vector3 direction, Il2CppStructArray<RaycastHit> raycastHits, Quaternion orientation, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return PhysicsScene.Internal_BoxCastNonAlloc_Injected(ref physicsScene, ref center, ref halfExtents, ref direction, raycastHits, ref orientation, maxDistance, mask, queryTriggerInteraction);
		}

		// Token: 0x06000187 RID: 391 RVA: 0x000078E4 File Offset: 0x00005AE4
		public int BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, Il2CppStructArray<RaycastHit> results, Quaternion orientation, [Optional] float maxDistance, [Optional] int layerMask, [Optional] QueryTriggerInteraction queryTriggerInteraction)
		{
			float magnitude = direction.magnitude;
			bool flag = magnitude > float.Epsilon;
			int num;
			if (flag)
			{
				num = PhysicsScene.Internal_BoxCastNonAlloc(this, center, halfExtents, direction, results, orientation, maxDistance, layerMask, queryTriggerInteraction);
			}
			else
			{
				num = 0;
			}
			return num;
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00007928 File Offset: 0x00005B28
		public int BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, Il2CppStructArray<RaycastHit> results)
		{
			return this.BoxCast(center, halfExtents, direction, results, Quaternion.identity, float.PositiveInfinity, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00002D45 File Offset: 0x00000F45
		public static bool IsValid_Internal_Injected(ref PhysicsScene physicsScene)
		{
			return PhysicsScene.IsValid_Internal_InjectedDelegateField(ref physicsScene);
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00002D52 File Offset: 0x00000F52
		public static bool IsEmpty_Internal_Injected(ref PhysicsScene physicsScene)
		{
			return PhysicsScene.IsEmpty_Internal_InjectedDelegateField(ref physicsScene);
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00007954 File Offset: 0x00005B54
		public static bool Query_CapsuleCast_Injected(ref PhysicsScene physicsScene, ref Vector3 point1, ref Vector3 point2, float radius, ref Vector3 direction, float maxDistance, ref RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return PhysicsScene.Query_CapsuleCast_InjectedDelegateField(ref physicsScene, ref point1, ref point2, radius, ref direction, maxDistance, ref hitInfo, layerMask, queryTriggerInteraction);
		}

		// Token: 0x0600018C RID: 396 RVA: 0x0000797C File Offset: 0x00005B7C
		public static int Internal_CapsuleCastNonAlloc_Injected(ref PhysicsScene physicsScene, ref Vector3 p0, ref Vector3 p1, float radius, ref Vector3 direction, Il2CppStructArray<RaycastHit> raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return PhysicsScene.Internal_CapsuleCastNonAlloc_InjectedDelegateField(ref physicsScene, ref p0, ref p1, radius, ref direction, IL2CPP.Il2CppObjectBaseToPtr(raycastHits), maxDistance, mask, queryTriggerInteraction);
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00002D5F File Offset: 0x00000F5F
		public static int OverlapCapsuleNonAlloc_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 point0, ref Vector3 point1, float radius, Il2CppReferenceArray<Collider> results, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return PhysicsScene.OverlapCapsuleNonAlloc_Internal_InjectedDelegateField(ref physicsScene, ref point0, ref point1, radius, IL2CPP.Il2CppObjectBaseToPtr(results), layerMask, queryTriggerInteraction);
		}

		// Token: 0x0600018E RID: 398 RVA: 0x000079A8 File Offset: 0x00005BA8
		public static bool Query_SphereCast_Injected(ref PhysicsScene physicsScene, ref Vector3 origin, float radius, ref Vector3 direction, float maxDistance, ref RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return PhysicsScene.Query_SphereCast_InjectedDelegateField(ref physicsScene, ref origin, radius, ref direction, maxDistance, ref hitInfo, layerMask, queryTriggerInteraction);
		}

		// Token: 0x0600018F RID: 399 RVA: 0x000079CC File Offset: 0x00005BCC
		public static int Internal_SphereCastNonAlloc_Injected(ref PhysicsScene physicsScene, ref Vector3 origin, float radius, ref Vector3 direction, Il2CppStructArray<RaycastHit> raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return PhysicsScene.Internal_SphereCastNonAlloc_InjectedDelegateField(ref physicsScene, ref origin, radius, ref direction, IL2CPP.Il2CppObjectBaseToPtr(raycastHits), maxDistance, mask, queryTriggerInteraction);
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00002D7A File Offset: 0x00000F7A
		public static int OverlapSphereNonAlloc_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 position, float radius, Il2CppReferenceArray<Collider> results, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return PhysicsScene.OverlapSphereNonAlloc_Internal_InjectedDelegateField(ref physicsScene, ref position, radius, IL2CPP.Il2CppObjectBaseToPtr(results), layerMask, queryTriggerInteraction);
		}

		// Token: 0x06000191 RID: 401 RVA: 0x000079F4 File Offset: 0x00005BF4
		public static bool Query_BoxCast_Injected(ref PhysicsScene physicsScene, ref Vector3 center, ref Vector3 halfExtents, ref Vector3 direction, ref Quaternion orientation, float maxDistance, ref RaycastHit outHit, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return PhysicsScene.Query_BoxCast_InjectedDelegateField(ref physicsScene, ref center, ref halfExtents, ref direction, ref orientation, maxDistance, ref outHit, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00002D93 File Offset: 0x00000F93
		public static int OverlapBoxNonAlloc_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 center, ref Vector3 halfExtents, Il2CppReferenceArray<Collider> results, ref Quaternion orientation, int mask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return PhysicsScene.OverlapBoxNonAlloc_Internal_InjectedDelegateField(ref physicsScene, ref center, ref halfExtents, IL2CPP.Il2CppObjectBaseToPtr(results), ref orientation, mask, queryTriggerInteraction);
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00007A1C File Offset: 0x00005C1C
		public static int Internal_BoxCastNonAlloc_Injected(ref PhysicsScene physicsScene, ref Vector3 center, ref Vector3 halfExtents, ref Vector3 direction, Il2CppStructArray<RaycastHit> raycastHits, ref Quaternion orientation, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return PhysicsScene.Internal_BoxCastNonAlloc_InjectedDelegateField(ref physicsScene, ref center, ref halfExtents, ref direction, IL2CPP.Il2CppObjectBaseToPtr(raycastHits), ref orientation, maxDistance, mask, queryTriggerInteraction);
		}

		// Token: 0x040000E7 RID: 231
		private static readonly IntPtr NativeFieldInfoPtr_m_Handle;

		// Token: 0x040000E8 RID: 232
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040000E9 RID: 233
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040000EA RID: 234
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040000EB RID: 235
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PhysicsScene_0;

		// Token: 0x040000EC RID: 236
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Boolean_Vector3_Vector3_Single_Int32_QueryTriggerInteraction_0;

		// Token: 0x040000ED RID: 237
		private static readonly IntPtr NativeMethodInfoPtr_Internal_RaycastTest_Private_Static_Boolean_PhysicsScene_Ray_Single_Int32_QueryTriggerInteraction_0;

		// Token: 0x040000EE RID: 238
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Boolean_Vector3_Vector3_byref_RaycastHit_Single_Int32_QueryTriggerInteraction_0;

		// Token: 0x040000EF RID: 239
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Raycast_Private_Static_Boolean_PhysicsScene_Ray_Single_byref_RaycastHit_Int32_QueryTriggerInteraction_0;

		// Token: 0x040000F0 RID: 240
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Int32_Vector3_Vector3_Il2CppStructArray_1_RaycastHit_Single_Int32_QueryTriggerInteraction_0;

		// Token: 0x040000F1 RID: 241
		private static readonly IntPtr NativeMethodInfoPtr_Internal_RaycastNonAlloc_Private_Static_Int32_PhysicsScene_Ray_Il2CppStructArray_1_RaycastHit_Single_Int32_QueryTriggerInteraction_0;

		// Token: 0x040000F2 RID: 242
		private static readonly IntPtr NativeMethodInfoPtr_Internal_RaycastTest_Injected_Private_Static_Boolean_byref_PhysicsScene_byref_Ray_Single_Int32_QueryTriggerInteraction_0;

		// Token: 0x040000F3 RID: 243
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Raycast_Injected_Private_Static_Boolean_byref_PhysicsScene_byref_Ray_Single_byref_RaycastHit_Int32_QueryTriggerInteraction_0;

		// Token: 0x040000F4 RID: 244
		private static readonly IntPtr NativeMethodInfoPtr_Internal_RaycastNonAlloc_Injected_Private_Static_Int32_byref_PhysicsScene_byref_Ray_Il2CppStructArray_1_RaycastHit_Single_Int32_QueryTriggerInteraction_0;

		// Token: 0x040000F5 RID: 245
		[FieldOffset(0)]
		public int m_Handle;

		// Token: 0x040000F6 RID: 246
		private static readonly PhysicsScene.IsValid_Internal_InjectedDelegate IsValid_Internal_InjectedDelegateField;

		// Token: 0x040000F7 RID: 247
		private static readonly PhysicsScene.IsEmpty_Internal_InjectedDelegate IsEmpty_Internal_InjectedDelegateField;

		// Token: 0x040000F8 RID: 248
		private static readonly PhysicsScene.Query_CapsuleCast_InjectedDelegate Query_CapsuleCast_InjectedDelegateField;

		// Token: 0x040000F9 RID: 249
		private static readonly PhysicsScene.Internal_CapsuleCastNonAlloc_InjectedDelegate Internal_CapsuleCastNonAlloc_InjectedDelegateField;

		// Token: 0x040000FA RID: 250
		private static readonly PhysicsScene.OverlapCapsuleNonAlloc_Internal_InjectedDelegate OverlapCapsuleNonAlloc_Internal_InjectedDelegateField;

		// Token: 0x040000FB RID: 251
		private static readonly PhysicsScene.Query_SphereCast_InjectedDelegate Query_SphereCast_InjectedDelegateField;

		// Token: 0x040000FC RID: 252
		private static readonly PhysicsScene.Internal_SphereCastNonAlloc_InjectedDelegate Internal_SphereCastNonAlloc_InjectedDelegateField;

		// Token: 0x040000FD RID: 253
		private static readonly PhysicsScene.OverlapSphereNonAlloc_Internal_InjectedDelegate OverlapSphereNonAlloc_Internal_InjectedDelegateField;

		// Token: 0x040000FE RID: 254
		private static readonly PhysicsScene.Query_BoxCast_InjectedDelegate Query_BoxCast_InjectedDelegateField;

		// Token: 0x040000FF RID: 255
		private static readonly PhysicsScene.OverlapBoxNonAlloc_Internal_InjectedDelegate OverlapBoxNonAlloc_Internal_InjectedDelegateField;

		// Token: 0x04000100 RID: 256
		private static readonly PhysicsScene.Internal_BoxCastNonAlloc_InjectedDelegate Internal_BoxCastNonAlloc_InjectedDelegateField;

		// Token: 0x02000098 RID: 152
		// (Invoke) Token: 0x06000454 RID: 1108
		private delegate bool IsValid_Internal_InjectedDelegate(IntPtr physicsScene);

		// Token: 0x02000099 RID: 153
		// (Invoke) Token: 0x06000456 RID: 1110
		private delegate bool IsEmpty_Internal_InjectedDelegate(IntPtr physicsScene);

		// Token: 0x0200009A RID: 154
		// (Invoke) Token: 0x06000458 RID: 1112
		private delegate bool Query_CapsuleCast_InjectedDelegate(IntPtr physicsScene, IntPtr point1, IntPtr point2, float radius, IntPtr direction, float maxDistance, IntPtr hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction);

		// Token: 0x0200009B RID: 155
		// (Invoke) Token: 0x0600045A RID: 1114
		private delegate int Internal_CapsuleCastNonAlloc_InjectedDelegate(IntPtr physicsScene, IntPtr p0, IntPtr p1, float radius, IntPtr direction, IntPtr raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction);

		// Token: 0x0200009C RID: 156
		// (Invoke) Token: 0x0600045C RID: 1116
		private delegate int OverlapCapsuleNonAlloc_Internal_InjectedDelegate(IntPtr physicsScene, IntPtr point0, IntPtr point1, float radius, IntPtr results, int layerMask, QueryTriggerInteraction queryTriggerInteraction);

		// Token: 0x0200009D RID: 157
		// (Invoke) Token: 0x0600045E RID: 1118
		private delegate bool Query_SphereCast_InjectedDelegate(IntPtr physicsScene, IntPtr origin, float radius, IntPtr direction, float maxDistance, IntPtr hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction);

		// Token: 0x0200009E RID: 158
		// (Invoke) Token: 0x06000460 RID: 1120
		private delegate int Internal_SphereCastNonAlloc_InjectedDelegate(IntPtr physicsScene, IntPtr origin, float radius, IntPtr direction, IntPtr raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction);

		// Token: 0x0200009F RID: 159
		// (Invoke) Token: 0x06000462 RID: 1122
		private delegate int OverlapSphereNonAlloc_Internal_InjectedDelegate(IntPtr physicsScene, IntPtr position, float radius, IntPtr results, int layerMask, QueryTriggerInteraction queryTriggerInteraction);

		// Token: 0x020000A0 RID: 160
		// (Invoke) Token: 0x06000464 RID: 1124
		private delegate bool Query_BoxCast_InjectedDelegate(IntPtr physicsScene, IntPtr center, IntPtr halfExtents, IntPtr direction, IntPtr orientation, float maxDistance, IntPtr outHit, int layerMask, QueryTriggerInteraction queryTriggerInteraction);

		// Token: 0x020000A1 RID: 161
		// (Invoke) Token: 0x06000466 RID: 1126
		private delegate int OverlapBoxNonAlloc_Internal_InjectedDelegate(IntPtr physicsScene, IntPtr center, IntPtr halfExtents, IntPtr results, IntPtr orientation, int mask, QueryTriggerInteraction queryTriggerInteraction);

		// Token: 0x020000A2 RID: 162
		// (Invoke) Token: 0x06000468 RID: 1128
		private delegate int Internal_BoxCastNonAlloc_InjectedDelegate(IntPtr physicsScene, IntPtr center, IntPtr halfExtents, IntPtr direction, IntPtr raycastHits, IntPtr orientation, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction);
	}
}
