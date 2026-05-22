using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine
{
	// Token: 0x020000EA RID: 234
	public class Object : Object
	{
		// Token: 0x06001394 RID: 5012 RVA: 0x0004F5E0 File Offset: 0x0004D7E0
		// Note: this type is marked as 'beforefieldinit'.
		static Object()
		{
			Il2CppClassPointerStore<Object>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Object");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Object>.NativeClassPtr);
			Object.NativeFieldInfoPtr_m_CachedPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Object>.NativeClassPtr, "m_CachedPtr");
			Object.NativeFieldInfoPtr_OffsetOfInstanceIDInCPlusPlusObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Object>.NativeClassPtr, "OffsetOfInstanceIDInCPlusPlusObject");
			Object.NativeFieldInfoPtr_objectIsNullMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Object>.NativeClassPtr, "objectIsNullMessage");
			Object.NativeFieldInfoPtr_cloneDestroyedMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Object>.NativeClassPtr, "cloneDestroyedMessage");
			Object.NativeMethodInfoPtr_GetInstanceID_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100665002);
			Object.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100665003);
			Object.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100665004);
			Object.NativeMethodInfoPtr_op_Implicit_Public_Static_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100665005);
			Object.NativeMethodInfoPtr_CompareBaseObjects_Private_Static_Boolean_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100665006);
			Object.NativeMethodInfoPtr_IsNativeObjectAlive_Private_Static_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100665007);
			Object.NativeMethodInfoPtr_GetCachedPtr_Private_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100665008);
			Object.NativeMethodInfoPtr_get_name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100665009);
			Object.NativeMethodInfoPtr_set_name_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100665010);
			Object.NativeMethodInfoPtr_Instantiate_Public_Static_Object_Object_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100665011);
			Object.NativeMethodInfoPtr_Instantiate_Public_Static_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100665012);
			Object.NativeMethodInfoPtr_Instantiate_Public_Static_Object_Object_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100665013);
			Object.NativeMethodInfoPtr_Instantiate_Public_Static_Object_Object_Transform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100665014);
			Object.NativeMethodInfoPtr_Instantiate_Public_Static_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100665015);
			Object.NativeMethodInfoPtr_Instantiate_Public_Static_T_T_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100665016);
			Object.NativeMethodInfoPtr_Instantiate_Public_Static_T_T_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100665017);
			Object.NativeMethodInfoPtr_Instantiate_Public_Static_T_T_Transform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100665018);
			Object.NativeMethodInfoPtr_Destroy_Public_Static_Void_Object_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100665019);
			Object.NativeMethodInfoPtr_Destroy_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100665020);
			Object.NativeMethodInfoPtr_DestroyImmediate_Public_Static_Void_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100665021);
			Object.NativeMethodInfoPtr_DestroyImmediate_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100665022);
			Object.NativeMethodInfoPtr_FindObjectsOfType_Public_Static_Il2CppReferenceArray_1_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100665023);
			Object.NativeMethodInfoPtr_FindObjectsOfType_Public_Static_Il2CppReferenceArray_1_Object_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100665024);
			Object.NativeMethodInfoPtr_DontDestroyOnLoad_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100665025);
			Object.NativeMethodInfoPtr_get_hideFlags_Public_get_HideFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100665026);
			Object.NativeMethodInfoPtr_set_hideFlags_Public_set_Void_HideFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100665027);
			Object.NativeMethodInfoPtr_FindObjectsOfType_Public_Static_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100665028);
			Object.NativeMethodInfoPtr_FindObjectOfType_Public_Static_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100665029);
			Object.NativeMethodInfoPtr_CheckNullArgument_Private_Static_Void_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100665030);
			Object.NativeMethodInfoPtr_FindObjectOfType_Public_Static_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100665031);
			Object.NativeMethodInfoPtr_FindObjectOfType_Public_Static_Object_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100665032);
			Object.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100665033);
			Object.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100665034);
			Object.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100665035);
			Object.NativeMethodInfoPtr_GetOffsetOfInstanceIDInCPlusPlusObject_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100665036);
			Object.NativeMethodInfoPtr_Internal_CloneSingle_Private_Static_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100665037);
			Object.NativeMethodInfoPtr_Internal_CloneSingleWithParent_Private_Static_Object_Object_Transform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100665038);
			Object.NativeMethodInfoPtr_Internal_InstantiateSingle_Private_Static_Object_Object_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100665039);
			Object.NativeMethodInfoPtr_ToString_Private_Static_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100665040);
			Object.NativeMethodInfoPtr_GetName_Private_Static_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100665041);
			Object.NativeMethodInfoPtr_SetName_Private_Static_Void_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100665042);
			Object.NativeMethodInfoPtr_FindObjectFromInstanceID_Internal_Static_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100665043);
			Object.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100665044);
			Object.NativeMethodInfoPtr_Internal_InstantiateSingle_Injected_Private_Static_Object_Object_byref_Vector3_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100665046);
			Object.FindObjectsByTypeDelegateField = IL2CPP.ResolveICall<Object.FindObjectsByTypeDelegate>("UnityEngine.Object::FindObjectsByType");
			Object.FindObjectsOfTypeIncludingAssetsDelegateField = IL2CPP.ResolveICall<Object.FindObjectsOfTypeIncludingAssetsDelegate>("UnityEngine.Object::FindObjectsOfTypeIncludingAssets");
			Object.CurrentThreadIsMainThreadDelegateField = IL2CPP.ResolveICall<Object.CurrentThreadIsMainThreadDelegate>("UnityEngine.Object::CurrentThreadIsMainThread");
			Object.IsPersistentDelegateField = IL2CPP.ResolveICall<Object.IsPersistentDelegate>("UnityEngine.Object::IsPersistent");
			Object.DoesObjectWithInstanceIDExistDelegateField = IL2CPP.ResolveICall<Object.DoesObjectWithInstanceIDExistDelegate>("UnityEngine.Object::DoesObjectWithInstanceIDExist");
			Object.ForceLoadFromInstanceIDDelegateField = IL2CPP.ResolveICall<Object.ForceLoadFromInstanceIDDelegate>("UnityEngine.Object::ForceLoadFromInstanceID");
			Object.Internal_InstantiateSingleWithParent_InjectedDelegateField = IL2CPP.ResolveICall<Object.Internal_InstantiateSingleWithParent_InjectedDelegate>("UnityEngine.Object::Internal_InstantiateSingleWithParent_Injected");
		}

		// Token: 0x06001395 RID: 5013 RVA: 0x0004FA3C File Offset: 0x0004DC3C
		[CallerCount(153)]
		[CachedScanResults(RefRangeStart = 496898, RefRangeEnd = 497051, XrefRangeStart = 496886, XrefRangeEnd = 496898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetInstanceID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_GetInstanceID_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001396 RID: 5014 RVA: 0x0004FA78 File Offset: 0x0004DC78
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Object.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001397 RID: 5015 RVA: 0x0004FAC0 File Offset: 0x0004DCC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 497051, XrefRangeEnd = 497079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Object.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001398 RID: 5016 RVA: 0x0004FB18 File Offset: 0x0004DD18
		[CallerCount(282)]
		[CachedScanResults(RefRangeStart = 497087, RefRangeEnd = 497369, XrefRangeStart = 497079, XrefRangeEnd = 497087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator bool(Object exists)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exists);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_op_Implicit_Public_Static_Boolean_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001399 RID: 5017 RVA: 0x0004FB5C File Offset: 0x0004DD5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 497369, XrefRangeEnd = 497370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CompareBaseObjects(Object lhs, Object rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lhs);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rhs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_CompareBaseObjects_Private_Static_Boolean_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600139A RID: 5018 RVA: 0x0004FBB0 File Offset: 0x0004DDB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 497370, XrefRangeEnd = 497371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsNativeObjectAlive(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_IsNativeObjectAlive_Private_Static_Boolean_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600139B RID: 5019 RVA: 0x0004FBF4 File Offset: 0x0004DDF4
		[CallerCount(0)]
		public unsafe IntPtr GetCachedPtr()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_GetCachedPtr_Private_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x0600139C RID: 5020 RVA: 0x0004FC30 File Offset: 0x0004DE30
		// (set) Token: 0x0600139D RID: 5021 RVA: 0x0004FC68 File Offset: 0x0004DE68
		public unsafe string name
		{
			[CallerCount(156)]
			[CachedScanResults(RefRangeStart = 497378, RefRangeEnd = 497534, XrefRangeStart = 497371, XrefRangeEnd = 497378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_get_name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(53)]
			[CachedScanResults(RefRangeStart = 497541, RefRangeEnd = 497594, XrefRangeStart = 497534, XrefRangeEnd = 497541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_set_name_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600139E RID: 5022 RVA: 0x0004FCAC File Offset: 0x0004DEAC
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 497617, RefRangeEnd = 497641, XrefRangeStart = 497594, XrefRangeEnd = 497617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object Instantiate(Object original, Vector3 position, Quaternion rotation)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(original);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_Instantiate_Public_Static_Object_Object_Vector3_Quaternion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600139F RID: 5023 RVA: 0x0004FD0C File Offset: 0x0004DF0C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 497656, RefRangeEnd = 497661, XrefRangeStart = 497641, XrefRangeEnd = 497656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object Instantiate(Object original)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(original);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_Instantiate_Public_Static_Object_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060013A0 RID: 5024 RVA: 0x0004FD50 File Offset: 0x0004DF50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 497661, XrefRangeEnd = 497665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object Instantiate(Object original, Transform parent)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(original);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_Instantiate_Public_Static_Object_Object_Transform_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060013A1 RID: 5025 RVA: 0x0004FDA8 File Offset: 0x0004DFA8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 497695, RefRangeEnd = 497699, XrefRangeStart = 497665, XrefRangeEnd = 497695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object Instantiate(Object original, Transform parent, bool instantiateInWorldSpace)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(original);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref instantiateInWorldSpace;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_Instantiate_Public_Static_Object_Object_Transform_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060013A2 RID: 5026 RVA: 0x0004FE0C File Offset: 0x0004E00C
		[CallerCount(34)]
		[CachedScanResults(RefRangeStart = 497717, RefRangeEnd = 497751, XrefRangeStart = 497699, XrefRangeEnd = 497717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T Instantiate<T>(T original) where T : Object
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t = original;
					if (!(t is string))
					{
						ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
						if ((ref ptr3) != null)
						{
							ptr4 = ref ptr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
							{
								ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
							}
						}
					}
					else
					{
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
					}
				}
				else
				{
					ptr4 = ref original;
				}
				*ptr2 = ref ptr4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.MethodInfoStoreGeneric_Instantiate_Public_Static_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x060013A3 RID: 5027 RVA: 0x0004FE98 File Offset: 0x0004E098
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 497751, XrefRangeEnd = 497756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T Instantiate<T>(T original, Vector3 position, Quaternion rotation) where T : Object
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t = original;
					if (!(t is string))
					{
						ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
						if ((ref ptr3) != null)
						{
							ptr4 = ref ptr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
							{
								ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
							}
						}
					}
					else
					{
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
					}
				}
				else
				{
					ptr4 = ref original;
				}
				*ptr2 = ref ptr4;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.MethodInfoStoreGeneric_Instantiate_Public_Static_T_T_Vector3_Quaternion_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060013A4 RID: 5028 RVA: 0x0004FF40 File Offset: 0x0004E140
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 497759, RefRangeEnd = 497778, XrefRangeStart = 497756, XrefRangeEnd = 497759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T Instantiate<T>(T original, Transform parent) where T : Object
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t = original;
					if (!(t is string))
					{
						ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
						if ((ref ptr3) != null)
						{
							ptr4 = ref ptr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
							{
								ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
							}
						}
					}
					else
					{
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
					}
				}
				else
				{
					ptr4 = ref original;
				}
				*ptr2 = ref ptr4;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.MethodInfoStoreGeneric_Instantiate_Public_Static_T_T_Transform_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060013A5 RID: 5029 RVA: 0x0004FFDC File Offset: 0x0004E1DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 497778, XrefRangeEnd = 497783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T Instantiate<T>(T original, Transform parent, bool worldPositionStays) where T : Object
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t = original;
					if (!(t is string))
					{
						ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
						if ((ref ptr3) != null)
						{
							ptr4 = ref ptr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
							{
								ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
							}
						}
					}
					else
					{
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
					}
				}
				else
				{
					ptr4 = ref original;
				}
				*ptr2 = ref ptr4;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref worldPositionStays;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.MethodInfoStoreGeneric_Instantiate_Public_Static_T_T_Transform_Boolean_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060013A6 RID: 5030 RVA: 0x00050088 File Offset: 0x0004E288
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 497783, XrefRangeEnd = 497787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Destroy(Object obj, float t)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_Destroy_Public_Static_Void_Object_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013A7 RID: 5031 RVA: 0x000500CC File Offset: 0x0004E2CC
		[CallerCount(147)]
		[CachedScanResults(RefRangeStart = 497794, RefRangeEnd = 497941, XrefRangeStart = 497787, XrefRangeEnd = 497794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Destroy(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_Destroy_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013A8 RID: 5032 RVA: 0x00050104 File Offset: 0x0004E304
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 497945, RefRangeEnd = 497946, XrefRangeStart = 497941, XrefRangeEnd = 497945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DestroyImmediate(Object obj, bool allowDestroyingAssets)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowDestroyingAssets;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_DestroyImmediate_Public_Static_Void_Object_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013A9 RID: 5033 RVA: 0x00050148 File Offset: 0x0004E348
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 497953, RefRangeEnd = 497967, XrefRangeStart = 497946, XrefRangeEnd = 497953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DestroyImmediate(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_DestroyImmediate_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013AA RID: 5034 RVA: 0x00050180 File Offset: 0x0004E380
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 497974, RefRangeEnd = 497980, XrefRangeStart = 497967, XrefRangeEnd = 497974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Object> FindObjectsOfType(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_FindObjectsOfType_Public_Static_Il2CppReferenceArray_1_Object_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x060013AB RID: 5035 RVA: 0x000501C4 File Offset: 0x0004E3C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 497980, XrefRangeEnd = 497984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Object> FindObjectsOfType(Type type, bool includeInactive)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeInactive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_FindObjectsOfType_Public_Static_Il2CppReferenceArray_1_Object_Type_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
		}

		// Token: 0x060013AC RID: 5036 RVA: 0x00050218 File Offset: 0x0004E418
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 497988, RefRangeEnd = 497990, XrefRangeStart = 497984, XrefRangeEnd = 497988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DontDestroyOnLoad(Object target)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_DontDestroyOnLoad_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x060013AD RID: 5037 RVA: 0x00050250 File Offset: 0x0004E450
		// (set) Token: 0x060013AE RID: 5038 RVA: 0x0005028C File Offset: 0x0004E48C
		public unsafe HideFlags hideFlags
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 497994, RefRangeEnd = 497996, XrefRangeStart = 497990, XrefRangeEnd = 497994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_get_hideFlags_Public_get_HideFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 498000, RefRangeEnd = 498010, XrefRangeStart = 497996, XrefRangeEnd = 498000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_set_hideFlags_Public_set_Void_HideFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060013AF RID: 5039 RVA: 0x000502CC File Offset: 0x0004E4CC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 498021, RefRangeEnd = 498024, XrefRangeStart = 498010, XrefRangeEnd = 498021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppArrayBase<T> FindObjectsOfType<T>() where T : Object
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.MethodInfoStoreGeneric_FindObjectsOfType_Public_Static_Il2CppArrayBase_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
		}

		// Token: 0x060013B0 RID: 5040 RVA: 0x000502F8 File Offset: 0x0004E4F8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 498039, RefRangeEnd = 498043, XrefRangeStart = 498024, XrefRangeEnd = 498039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T FindObjectOfType<T>() where T : Object
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.MethodInfoStoreGeneric_FindObjectOfType_Public_Static_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060013B1 RID: 5041 RVA: 0x00050328 File Offset: 0x0004E528
		[CallerCount(0)]
		public unsafe static void CheckNullArgument(Object arg, string message)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arg);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_CheckNullArgument_Private_Static_Void_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013B2 RID: 5042 RVA: 0x00050370 File Offset: 0x0004E570
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 498048, RefRangeEnd = 498053, XrefRangeStart = 498043, XrefRangeEnd = 498048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object FindObjectOfType(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_FindObjectOfType_Public_Static_Object_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060013B3 RID: 5043 RVA: 0x000503B4 File Offset: 0x0004E5B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498053, XrefRangeEnd = 498058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object FindObjectOfType(Type type, bool includeInactive)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeInactive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_FindObjectOfType_Public_Static_Object_Type_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060013B4 RID: 5044 RVA: 0x00050408 File Offset: 0x0004E608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498058, XrefRangeEnd = 498065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Object.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060013B5 RID: 5045 RVA: 0x0005044C File Offset: 0x0004E64C
		[CallerCount(57)]
		[CachedScanResults(RefRangeStart = 498071, RefRangeEnd = 498128, XrefRangeStart = 498065, XrefRangeEnd = 498071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(Object x, Object y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013B6 RID: 5046 RVA: 0x000504A0 File Offset: 0x0004E6A0
		[CallerCount(57)]
		[CachedScanResults(RefRangeStart = 498134, RefRangeEnd = 498191, XrefRangeStart = 498128, XrefRangeEnd = 498134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(Object x, Object y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013B7 RID: 5047 RVA: 0x000504F4 File Offset: 0x0004E6F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498191, XrefRangeEnd = 498195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetOffsetOfInstanceIDInCPlusPlusObject()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_GetOffsetOfInstanceIDInCPlusPlusObject_Private_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013B8 RID: 5048 RVA: 0x00050524 File Offset: 0x0004E724
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498195, XrefRangeEnd = 498199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object Internal_CloneSingle(Object data)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_Internal_CloneSingle_Private_Static_Object_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060013B9 RID: 5049 RVA: 0x00050568 File Offset: 0x0004E768
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498199, XrefRangeEnd = 498203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object Internal_CloneSingleWithParent(Object data, Transform parent, bool worldPositionStays)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref worldPositionStays;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_Internal_CloneSingleWithParent_Private_Static_Object_Object_Transform_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060013BA RID: 5050 RVA: 0x000505CC File Offset: 0x0004E7CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498203, XrefRangeEnd = 498208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object Internal_InstantiateSingle(Object data, Vector3 pos, Quaternion rot)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_Internal_InstantiateSingle_Private_Static_Object_Object_Vector3_Quaternion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060013BB RID: 5051 RVA: 0x0005062C File Offset: 0x0004E82C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498208, XrefRangeEnd = 498212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_ToString_Private_Static_String_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060013BC RID: 5052 RVA: 0x00050668 File Offset: 0x0004E868
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498212, XrefRangeEnd = 498216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetName(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_GetName_Private_Static_String_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060013BD RID: 5053 RVA: 0x000506A4 File Offset: 0x0004E8A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498216, XrefRangeEnd = 498220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetName(Object obj, string name)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_SetName_Private_Static_Void_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013BE RID: 5054 RVA: 0x000506EC File Offset: 0x0004E8EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498220, XrefRangeEnd = 498226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object FindObjectFromInstanceID(int instanceID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref instanceID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_FindObjectFromInstanceID_Internal_Static_Object_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060013BF RID: 5055 RVA: 0x0005072C File Offset: 0x0004E92C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Object>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013C0 RID: 5056 RVA: 0x00050768 File Offset: 0x0004E968
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498226, XrefRangeEnd = 498230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object Internal_InstantiateSingle_Injected(Object data, ref Vector3 pos, ref Quaternion rot)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &rot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_Internal_InstantiateSingle_Injected_Private_Static_Object_Object_byref_Vector3_byref_Quaternion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060013C1 RID: 5057 RVA: 0x0000AF60 File Offset: 0x00009160
		public Object(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x060013C2 RID: 5058 RVA: 0x000507C8 File Offset: 0x0004E9C8
		// (set) Token: 0x060013C3 RID: 5059 RVA: 0x0000AF69 File Offset: 0x00009169
		public unsafe IntPtr m_CachedPtr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Object.NativeFieldInfoPtr_m_CachedPtr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Object.NativeFieldInfoPtr_m_CachedPtr)) = value;
			}
		}

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x060013C4 RID: 5060 RVA: 0x000507F0 File Offset: 0x0004E9F0
		// (set) Token: 0x060013C5 RID: 5061 RVA: 0x0000AF84 File Offset: 0x00009184
		public unsafe static int OffsetOfInstanceIDInCPlusPlusObject
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Object.NativeFieldInfoPtr_OffsetOfInstanceIDInCPlusPlusObject, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Object.NativeFieldInfoPtr_OffsetOfInstanceIDInCPlusPlusObject, (void*)(&value));
			}
		}

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x060013C6 RID: 5062 RVA: 0x0005080C File Offset: 0x0004EA0C
		// (set) Token: 0x060013C7 RID: 5063 RVA: 0x0000AF92 File Offset: 0x00009192
		public unsafe static string objectIsNullMessage
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Object.NativeFieldInfoPtr_objectIsNullMessage, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Object.NativeFieldInfoPtr_objectIsNullMessage, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x060013C8 RID: 5064 RVA: 0x0005082C File Offset: 0x0004EA2C
		// (set) Token: 0x060013C9 RID: 5065 RVA: 0x0000AFA4 File Offset: 0x000091A4
		public unsafe static string cloneDestroyedMessage
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Object.NativeFieldInfoPtr_cloneDestroyedMessage, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Object.NativeFieldInfoPtr_cloneDestroyedMessage, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x060013CA RID: 5066 RVA: 0x0005084C File Offset: 0x0004EA4C
		public void EnsureRunningOnMainThread()
		{
			bool flag = !Object.CurrentThreadIsMainThread();
			if (flag)
			{
				throw new InvalidOperationException("EnsureRunningOnMainThread can only be called from the main thread");
			}
		}

		// Token: 0x060013CB RID: 5067 RVA: 0x00050874 File Offset: 0x0004EA74
		public static Object Instantiate(Object original, Vector3 position, Quaternion rotation, Transform parent)
		{
			bool flag = parent == null;
			Object @object;
			if (flag)
			{
				@object = Object.Instantiate(original, position, rotation);
			}
			else
			{
				Object.CheckNullArgument(original, "The Object you want to instantiate is null.");
				Object object2 = Object.Internal_InstantiateSingleWithParent(original, parent, position, rotation);
				bool flag2 = object2 == null;
				if (flag2)
				{
					throw new UnityException("Instantiate failed because the clone was destroyed during creation. This can happen if DestroyImmediate is called in MonoBehaviour.Awake.");
				}
				@object = object2;
			}
			return @object;
		}

		// Token: 0x060013CC RID: 5068 RVA: 0x000508CC File Offset: 0x0004EACC
		public static T Instantiate<T>(T original, Vector3 position, Quaternion rotation, Transform parent) where T : Object
		{
			return Object.Instantiate(original, position, rotation, parent).Cast<T>();
		}

		// Token: 0x060013CD RID: 5069 RVA: 0x000508F4 File Offset: 0x0004EAF4
		public static Il2CppReferenceArray<Object> FindObjectsByType(Type type, FindObjectsSortMode sortMode)
		{
			return Object.FindObjectsByType(type, FindObjectsInactive.Exclude, sortMode);
		}

		// Token: 0x060013CE RID: 5070 RVA: 0x00050910 File Offset: 0x0004EB10
		public static Il2CppReferenceArray<Object> FindObjectsByType(Type type, FindObjectsInactive findObjectsInactive, FindObjectsSortMode sortMode)
		{
			IntPtr intPtr = Object.FindObjectsByTypeDelegateField(IL2CPP.Il2CppObjectBaseToPtr(type), findObjectsInactive, sortMode);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
		}

		// Token: 0x060013CF RID: 5071 RVA: 0x0000AFB6 File Offset: 0x000091B6
		public static void DestroyObject(Object obj, float t)
		{
			Object.Destroy(obj, t);
		}

		// Token: 0x060013D0 RID: 5072 RVA: 0x00050940 File Offset: 0x0004EB40
		public static void DestroyObject(Object obj)
		{
			float num = 0f;
			Object.Destroy(obj, num);
		}

		// Token: 0x060013D1 RID: 5073 RVA: 0x0005095C File Offset: 0x0004EB5C
		public static Il2CppReferenceArray<Object> FindSceneObjectsOfType(Type type)
		{
			return Object.FindObjectsOfType(type);
		}

		// Token: 0x060013D2 RID: 5074 RVA: 0x00050974 File Offset: 0x0004EB74
		public static Il2CppReferenceArray<Object> FindObjectsOfTypeIncludingAssets(Type type)
		{
			IntPtr intPtr = Object.FindObjectsOfTypeIncludingAssetsDelegateField(IL2CPP.Il2CppObjectBaseToPtr(type));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
		}

		// Token: 0x060013D3 RID: 5075 RVA: 0x000509A0 File Offset: 0x0004EBA0
		public static Il2CppArrayBase<T> FindObjectsByType<T>(FindObjectsSortMode sortMode) where T : Object
		{
			return Resources.ConvertObjects<T>(Object.FindObjectsByType(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), FindObjectsInactive.Exclude, sortMode));
		}

		// Token: 0x060013D4 RID: 5076 RVA: 0x000509C8 File Offset: 0x0004EBC8
		public static Il2CppArrayBase<T> FindObjectsOfType<T>(bool includeInactive) where T : Object
		{
			return Resources.ConvertObjects<T>(Object.FindObjectsOfType(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), includeInactive));
		}

		// Token: 0x060013D5 RID: 5077 RVA: 0x000509F0 File Offset: 0x0004EBF0
		public static Il2CppArrayBase<T> FindObjectsByType<T>(FindObjectsInactive findObjectsInactive, FindObjectsSortMode sortMode) where T : Object
		{
			return Resources.ConvertObjects<T>(Object.FindObjectsByType(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), findObjectsInactive, sortMode));
		}

		// Token: 0x060013D6 RID: 5078 RVA: 0x00050A18 File Offset: 0x0004EC18
		public static T FindObjectOfType<T>(bool includeInactive) where T : Object
		{
			return Object.FindObjectOfType(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), includeInactive).Cast<T>();
		}

		// Token: 0x060013D7 RID: 5079 RVA: 0x00050A40 File Offset: 0x0004EC40
		public static T FindFirstObjectByType<T>() where T : Object
		{
			return Object.FindFirstObjectByType(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), FindObjectsInactive.Exclude).Cast<T>();
		}

		// Token: 0x060013D8 RID: 5080 RVA: 0x00050A68 File Offset: 0x0004EC68
		public static T FindAnyObjectByType<T>() where T : Object
		{
			return Object.FindAnyObjectByType(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), FindObjectsInactive.Exclude).Cast<T>();
		}

		// Token: 0x060013D9 RID: 5081 RVA: 0x00050A90 File Offset: 0x0004EC90
		public static T FindFirstObjectByType<T>(FindObjectsInactive findObjectsInactive) where T : Object
		{
			return Object.FindFirstObjectByType(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), findObjectsInactive).Cast<T>();
		}

		// Token: 0x060013DA RID: 5082 RVA: 0x00050AB8 File Offset: 0x0004ECB8
		public static T FindAnyObjectByType<T>(FindObjectsInactive findObjectsInactive) where T : Object
		{
			return Object.FindAnyObjectByType(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), findObjectsInactive).Cast<T>();
		}

		// Token: 0x060013DB RID: 5083 RVA: 0x00050AE0 File Offset: 0x0004ECE0
		public static Il2CppReferenceArray<Object> FindObjectsOfTypeAll(Type type)
		{
			return Resources.FindObjectsOfTypeAll(type);
		}

		// Token: 0x060013DC RID: 5084 RVA: 0x0000AFC1 File Offset: 0x000091C1
		public static Object FindFirstObjectByType(Type type)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060013DD RID: 5085 RVA: 0x0000AFCE File Offset: 0x000091CE
		public static Object FindAnyObjectByType(Type type)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060013DE RID: 5086 RVA: 0x0000AFDB File Offset: 0x000091DB
		public static Object FindFirstObjectByType(Type type, FindObjectsInactive findObjectsInactive)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060013DF RID: 5087 RVA: 0x0000AFE8 File Offset: 0x000091E8
		public static Object FindAnyObjectByType(Type type, FindObjectsInactive findObjectsInactive)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060013E0 RID: 5088 RVA: 0x0000AFF5 File Offset: 0x000091F5
		public static bool CurrentThreadIsMainThread()
		{
			return Object.CurrentThreadIsMainThreadDelegateField();
		}

		// Token: 0x060013E1 RID: 5089 RVA: 0x0000B001 File Offset: 0x00009201
		public static Object Internal_InstantiateSingleWithParent(Object data, Transform parent, Vector3 pos, Quaternion rot)
		{
			return Object.Internal_InstantiateSingleWithParent_Injected(data, parent, ref pos, ref rot);
		}

		// Token: 0x060013E2 RID: 5090 RVA: 0x0000B00E File Offset: 0x0000920E
		public static bool IsPersistent(Object obj)
		{
			return Object.IsPersistentDelegateField(IL2CPP.Il2CppObjectBaseToPtr(obj));
		}

		// Token: 0x060013E3 RID: 5091 RVA: 0x0000B020 File Offset: 0x00009220
		public static bool DoesObjectWithInstanceIDExist(int instanceID)
		{
			return Object.DoesObjectWithInstanceIDExistDelegateField(instanceID);
		}

		// Token: 0x060013E4 RID: 5092 RVA: 0x00050AF8 File Offset: 0x0004ECF8
		public static Object ForceLoadFromInstanceID(int instanceID)
		{
			IntPtr intPtr = Object.ForceLoadFromInstanceIDDelegateField(instanceID);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
		}

		// Token: 0x060013E5 RID: 5093 RVA: 0x00050B20 File Offset: 0x0004ED20
		public static Object Internal_InstantiateSingleWithParent_Injected(Object data, Transform parent, ref Vector3 pos, ref Quaternion rot)
		{
			IntPtr intPtr = Object.Internal_InstantiateSingleWithParent_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(data), IL2CPP.Il2CppObjectBaseToPtr(parent), ref pos, ref rot);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
		}

		// Token: 0x04000F97 RID: 3991
		private static readonly IntPtr NativeFieldInfoPtr_m_CachedPtr;

		// Token: 0x04000F98 RID: 3992
		private static readonly IntPtr NativeFieldInfoPtr_OffsetOfInstanceIDInCPlusPlusObject;

		// Token: 0x04000F99 RID: 3993
		private static readonly IntPtr NativeFieldInfoPtr_objectIsNullMessage;

		// Token: 0x04000F9A RID: 3994
		private static readonly IntPtr NativeFieldInfoPtr_cloneDestroyedMessage;

		// Token: 0x04000F9B RID: 3995
		private static readonly IntPtr NativeMethodInfoPtr_GetInstanceID_Public_Int32_0;

		// Token: 0x04000F9C RID: 3996
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000F9D RID: 3997
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000F9E RID: 3998
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Boolean_Object_0;

		// Token: 0x04000F9F RID: 3999
		private static readonly IntPtr NativeMethodInfoPtr_CompareBaseObjects_Private_Static_Boolean_Object_Object_0;

		// Token: 0x04000FA0 RID: 4000
		private static readonly IntPtr NativeMethodInfoPtr_IsNativeObjectAlive_Private_Static_Boolean_Object_0;

		// Token: 0x04000FA1 RID: 4001
		private static readonly IntPtr NativeMethodInfoPtr_GetCachedPtr_Private_IntPtr_0;

		// Token: 0x04000FA2 RID: 4002
		private static readonly IntPtr NativeMethodInfoPtr_get_name_Public_get_String_0;

		// Token: 0x04000FA3 RID: 4003
		private static readonly IntPtr NativeMethodInfoPtr_set_name_Public_set_Void_String_0;

		// Token: 0x04000FA4 RID: 4004
		private static readonly IntPtr NativeMethodInfoPtr_Instantiate_Public_Static_Object_Object_Vector3_Quaternion_0;

		// Token: 0x04000FA5 RID: 4005
		private static readonly IntPtr NativeMethodInfoPtr_Instantiate_Public_Static_Object_Object_0;

		// Token: 0x04000FA6 RID: 4006
		private static readonly IntPtr NativeMethodInfoPtr_Instantiate_Public_Static_Object_Object_Transform_0;

		// Token: 0x04000FA7 RID: 4007
		private static readonly IntPtr NativeMethodInfoPtr_Instantiate_Public_Static_Object_Object_Transform_Boolean_0;

		// Token: 0x04000FA8 RID: 4008
		private static readonly IntPtr NativeMethodInfoPtr_Instantiate_Public_Static_T_T_0;

		// Token: 0x04000FA9 RID: 4009
		private static readonly IntPtr NativeMethodInfoPtr_Instantiate_Public_Static_T_T_Vector3_Quaternion_0;

		// Token: 0x04000FAA RID: 4010
		private static readonly IntPtr NativeMethodInfoPtr_Instantiate_Public_Static_T_T_Transform_0;

		// Token: 0x04000FAB RID: 4011
		private static readonly IntPtr NativeMethodInfoPtr_Instantiate_Public_Static_T_T_Transform_Boolean_0;

		// Token: 0x04000FAC RID: 4012
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Static_Void_Object_Single_0;

		// Token: 0x04000FAD RID: 4013
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Static_Void_Object_0;

		// Token: 0x04000FAE RID: 4014
		private static readonly IntPtr NativeMethodInfoPtr_DestroyImmediate_Public_Static_Void_Object_Boolean_0;

		// Token: 0x04000FAF RID: 4015
		private static readonly IntPtr NativeMethodInfoPtr_DestroyImmediate_Public_Static_Void_Object_0;

		// Token: 0x04000FB0 RID: 4016
		private static readonly IntPtr NativeMethodInfoPtr_FindObjectsOfType_Public_Static_Il2CppReferenceArray_1_Object_Type_0;

		// Token: 0x04000FB1 RID: 4017
		private static readonly IntPtr NativeMethodInfoPtr_FindObjectsOfType_Public_Static_Il2CppReferenceArray_1_Object_Type_Boolean_0;

		// Token: 0x04000FB2 RID: 4018
		private static readonly IntPtr NativeMethodInfoPtr_DontDestroyOnLoad_Public_Static_Void_Object_0;

		// Token: 0x04000FB3 RID: 4019
		private static readonly IntPtr NativeMethodInfoPtr_get_hideFlags_Public_get_HideFlags_0;

		// Token: 0x04000FB4 RID: 4020
		private static readonly IntPtr NativeMethodInfoPtr_set_hideFlags_Public_set_Void_HideFlags_0;

		// Token: 0x04000FB5 RID: 4021
		private static readonly IntPtr NativeMethodInfoPtr_FindObjectsOfType_Public_Static_Il2CppArrayBase_1_T_0;

		// Token: 0x04000FB6 RID: 4022
		private static readonly IntPtr NativeMethodInfoPtr_FindObjectOfType_Public_Static_T_0;

		// Token: 0x04000FB7 RID: 4023
		private static readonly IntPtr NativeMethodInfoPtr_CheckNullArgument_Private_Static_Void_Object_String_0;

		// Token: 0x04000FB8 RID: 4024
		private static readonly IntPtr NativeMethodInfoPtr_FindObjectOfType_Public_Static_Object_Type_0;

		// Token: 0x04000FB9 RID: 4025
		private static readonly IntPtr NativeMethodInfoPtr_FindObjectOfType_Public_Static_Object_Type_Boolean_0;

		// Token: 0x04000FBA RID: 4026
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000FBB RID: 4027
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Object_Object_0;

		// Token: 0x04000FBC RID: 4028
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Object_Object_0;

		// Token: 0x04000FBD RID: 4029
		private static readonly IntPtr NativeMethodInfoPtr_GetOffsetOfInstanceIDInCPlusPlusObject_Private_Static_Int32_0;

		// Token: 0x04000FBE RID: 4030
		private static readonly IntPtr NativeMethodInfoPtr_Internal_CloneSingle_Private_Static_Object_Object_0;

		// Token: 0x04000FBF RID: 4031
		private static readonly IntPtr NativeMethodInfoPtr_Internal_CloneSingleWithParent_Private_Static_Object_Object_Transform_Boolean_0;

		// Token: 0x04000FC0 RID: 4032
		private static readonly IntPtr NativeMethodInfoPtr_Internal_InstantiateSingle_Private_Static_Object_Object_Vector3_Quaternion_0;

		// Token: 0x04000FC1 RID: 4033
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Private_Static_String_Object_0;

		// Token: 0x04000FC2 RID: 4034
		private static readonly IntPtr NativeMethodInfoPtr_GetName_Private_Static_String_Object_0;

		// Token: 0x04000FC3 RID: 4035
		private static readonly IntPtr NativeMethodInfoPtr_SetName_Private_Static_Void_Object_String_0;

		// Token: 0x04000FC4 RID: 4036
		private static readonly IntPtr NativeMethodInfoPtr_FindObjectFromInstanceID_Internal_Static_Object_Int32_0;

		// Token: 0x04000FC5 RID: 4037
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000FC6 RID: 4038
		private static readonly IntPtr NativeMethodInfoPtr_Internal_InstantiateSingle_Injected_Private_Static_Object_Object_byref_Vector3_byref_Quaternion_0;

		// Token: 0x04000FC7 RID: 4039
		private static readonly Object.FindObjectsByTypeDelegate FindObjectsByTypeDelegateField;

		// Token: 0x04000FC8 RID: 4040
		private static readonly Object.FindObjectsOfTypeIncludingAssetsDelegate FindObjectsOfTypeIncludingAssetsDelegateField;

		// Token: 0x04000FC9 RID: 4041
		private static readonly Object.CurrentThreadIsMainThreadDelegate CurrentThreadIsMainThreadDelegateField;

		// Token: 0x04000FCA RID: 4042
		private static readonly Object.IsPersistentDelegate IsPersistentDelegateField;

		// Token: 0x04000FCB RID: 4043
		private static readonly Object.DoesObjectWithInstanceIDExistDelegate DoesObjectWithInstanceIDExistDelegateField;

		// Token: 0x04000FCC RID: 4044
		private static readonly Object.ForceLoadFromInstanceIDDelegate ForceLoadFromInstanceIDDelegateField;

		// Token: 0x04000FCD RID: 4045
		private static readonly Object.Internal_InstantiateSingleWithParent_InjectedDelegate Internal_InstantiateSingleWithParent_InjectedDelegateField;

		// Token: 0x020007C0 RID: 1984
		private sealed class MethodInfoStoreGeneric_Instantiate_Public_Static_T_T_0<T>
		{
			// Token: 0x04001F2A RID: 7978
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Object.NativeMethodInfoPtr_Instantiate_Public_Static_T_T_0, Il2CppClassPointerStore<Object>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020007C1 RID: 1985
		private sealed class MethodInfoStoreGeneric_Instantiate_Public_Static_T_T_Vector3_Quaternion_0<T>
		{
			// Token: 0x04001F2B RID: 7979
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Object.NativeMethodInfoPtr_Instantiate_Public_Static_T_T_Vector3_Quaternion_0, Il2CppClassPointerStore<Object>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020007C2 RID: 1986
		private sealed class MethodInfoStoreGeneric_Instantiate_Public_Static_T_T_Transform_0<T>
		{
			// Token: 0x04001F2C RID: 7980
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Object.NativeMethodInfoPtr_Instantiate_Public_Static_T_T_Transform_0, Il2CppClassPointerStore<Object>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020007C3 RID: 1987
		private sealed class MethodInfoStoreGeneric_Instantiate_Public_Static_T_T_Transform_Boolean_0<T>
		{
			// Token: 0x04001F2D RID: 7981
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Object.NativeMethodInfoPtr_Instantiate_Public_Static_T_T_Transform_Boolean_0, Il2CppClassPointerStore<Object>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020007C4 RID: 1988
		private sealed class MethodInfoStoreGeneric_FindObjectsOfType_Public_Static_Il2CppArrayBase_1_T_0<T>
		{
			// Token: 0x04001F2E RID: 7982
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Object.NativeMethodInfoPtr_FindObjectsOfType_Public_Static_Il2CppArrayBase_1_T_0, Il2CppClassPointerStore<Object>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020007C5 RID: 1989
		private sealed class MethodInfoStoreGeneric_FindObjectOfType_Public_Static_T_0<T>
		{
			// Token: 0x04001F2F RID: 7983
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Object.NativeMethodInfoPtr_FindObjectOfType_Public_Static_T_0, Il2CppClassPointerStore<Object>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020007C6 RID: 1990
		// (Invoke) Token: 0x06002D85 RID: 11653
		private delegate IntPtr FindObjectsByTypeDelegate(IntPtr type, FindObjectsInactive findObjectsInactive, FindObjectsSortMode sortMode);

		// Token: 0x020007C7 RID: 1991
		// (Invoke) Token: 0x06002D87 RID: 11655
		private delegate IntPtr FindObjectsOfTypeIncludingAssetsDelegate(IntPtr type);

		// Token: 0x020007C8 RID: 1992
		// (Invoke) Token: 0x06002D89 RID: 11657
		private delegate bool CurrentThreadIsMainThreadDelegate();

		// Token: 0x020007C9 RID: 1993
		// (Invoke) Token: 0x06002D8B RID: 11659
		private delegate bool IsPersistentDelegate(IntPtr obj);

		// Token: 0x020007CA RID: 1994
		// (Invoke) Token: 0x06002D8D RID: 11661
		private delegate bool DoesObjectWithInstanceIDExistDelegate(int instanceID);

		// Token: 0x020007CB RID: 1995
		// (Invoke) Token: 0x06002D8F RID: 11663
		private delegate IntPtr ForceLoadFromInstanceIDDelegate(int instanceID);

		// Token: 0x020007CC RID: 1996
		// (Invoke) Token: 0x06002D91 RID: 11665
		private delegate IntPtr Internal_InstantiateSingleWithParent_InjectedDelegate(IntPtr data, IntPtr parent, IntPtr pos, IntPtr rot);
	}
}
