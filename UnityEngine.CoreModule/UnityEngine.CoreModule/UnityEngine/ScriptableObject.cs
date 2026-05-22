using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine
{
	// Token: 0x020000E1 RID: 225
	public class ScriptableObject : Object
	{
		// Token: 0x0600135F RID: 4959 RVA: 0x0004EBB8 File Offset: 0x0004CDB8
		// Note: this type is marked as 'beforefieldinit'.
		static ScriptableObject()
		{
			Il2CppClassPointerStore<ScriptableObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ScriptableObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptableObject>.NativeClassPtr);
			ScriptableObject.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableObject>.NativeClassPtr, 100664974);
			ScriptableObject.NativeMethodInfoPtr_CreateInstance_Public_Static_ScriptableObject_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableObject>.NativeClassPtr, 100664975);
			ScriptableObject.NativeMethodInfoPtr_CreateInstance_Public_Static_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableObject>.NativeClassPtr, 100664976);
			ScriptableObject.NativeMethodInfoPtr_CreateScriptableObject_Private_Static_Void_ScriptableObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableObject>.NativeClassPtr, 100664977);
			ScriptableObject.NativeMethodInfoPtr_CreateScriptableObjectInstanceFromType_Internal_Static_ScriptableObject_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableObject>.NativeClassPtr, 100664978);
			ScriptableObject.SetDirtyDelegateField = IL2CPP.ResolveICall<ScriptableObject.SetDirtyDelegate>("UnityEngine.ScriptableObject::SetDirty");
			ScriptableObject.CreateScriptableObjectInstanceFromNameDelegateField = IL2CPP.ResolveICall<ScriptableObject.CreateScriptableObjectInstanceFromNameDelegate>("UnityEngine.ScriptableObject::CreateScriptableObjectInstanceFromName");
			ScriptableObject.ResetAndApplyDefaultInstancesDelegateField = IL2CPP.ResolveICall<ScriptableObject.ResetAndApplyDefaultInstancesDelegate>("UnityEngine.ScriptableObject::ResetAndApplyDefaultInstances");
		}

		// Token: 0x06001360 RID: 4960 RVA: 0x0004EC7C File Offset: 0x0004CE7C
		[CallerCount(83)]
		[CachedScanResults(RefRangeStart = 496520, RefRangeEnd = 496603, XrefRangeStart = 496513, XrefRangeEnd = 496520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScriptableObject()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScriptableObject>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableObject.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001361 RID: 4961 RVA: 0x0004ECB8 File Offset: 0x0004CEB8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 496607, RefRangeEnd = 496609, XrefRangeStart = 496603, XrefRangeEnd = 496607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ScriptableObject CreateInstance(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableObject.NativeMethodInfoPtr_CreateInstance_Public_Static_ScriptableObject_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScriptableObject>(intPtr3) : null;
			}
		}

		// Token: 0x06001362 RID: 4962 RVA: 0x0004ECFC File Offset: 0x0004CEFC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 496616, RefRangeEnd = 496621, XrefRangeStart = 496609, XrefRangeEnd = 496616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T CreateInstance<T>() where T : ScriptableObject
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableObject.MethodInfoStoreGeneric_CreateInstance_Public_Static_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06001363 RID: 4963 RVA: 0x0004ED2C File Offset: 0x0004CF2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 496621, XrefRangeEnd = 496625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CreateScriptableObject(ScriptableObject self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableObject.NativeMethodInfoPtr_CreateScriptableObject_Private_Static_Void_ScriptableObject_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001364 RID: 4964 RVA: 0x0004ED64 File Offset: 0x0004CF64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 496625, XrefRangeEnd = 496629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ScriptableObject CreateScriptableObjectInstanceFromType(Type type, bool applyDefaultsAndReset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref applyDefaultsAndReset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableObject.NativeMethodInfoPtr_CreateScriptableObjectInstanceFromType_Internal_Static_ScriptableObject_Type_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScriptableObject>(intPtr3) : null;
		}

		// Token: 0x06001365 RID: 4965 RVA: 0x0000AE04 File Offset: 0x00009004
		public ScriptableObject(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001366 RID: 4966 RVA: 0x0000AE0D File Offset: 0x0000900D
		public void SetDirty()
		{
			ScriptableObject.SetDirtyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06001367 RID: 4967 RVA: 0x0004EDB8 File Offset: 0x0004CFB8
		public static ScriptableObject CreateInstance(string className)
		{
			return ScriptableObject.CreateScriptableObjectInstanceFromName(className);
		}

		// Token: 0x06001368 RID: 4968 RVA: 0x0004EDD0 File Offset: 0x0004CFD0
		public static ScriptableObject CreateScriptableObjectInstanceFromName(string className)
		{
			IntPtr intPtr = ScriptableObject.CreateScriptableObjectInstanceFromNameDelegateField(IL2CPP.ManagedStringToIl2Cpp(className));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScriptableObject>(intPtr2) : null;
		}

		// Token: 0x06001369 RID: 4969 RVA: 0x0000AE1F File Offset: 0x0000901F
		public static void ResetAndApplyDefaultInstances(Object obj)
		{
			ScriptableObject.ResetAndApplyDefaultInstancesDelegateField(IL2CPP.Il2CppObjectBaseToPtr(obj));
		}

		// Token: 0x04000F6E RID: 3950
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000F6F RID: 3951
		private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_Public_Static_ScriptableObject_Type_0;

		// Token: 0x04000F70 RID: 3952
		private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_Public_Static_T_0;

		// Token: 0x04000F71 RID: 3953
		private static readonly IntPtr NativeMethodInfoPtr_CreateScriptableObject_Private_Static_Void_ScriptableObject_0;

		// Token: 0x04000F72 RID: 3954
		private static readonly IntPtr NativeMethodInfoPtr_CreateScriptableObjectInstanceFromType_Internal_Static_ScriptableObject_Type_Boolean_0;

		// Token: 0x04000F73 RID: 3955
		private static readonly ScriptableObject.SetDirtyDelegate SetDirtyDelegateField;

		// Token: 0x04000F74 RID: 3956
		private static readonly ScriptableObject.CreateScriptableObjectInstanceFromNameDelegate CreateScriptableObjectInstanceFromNameDelegateField;

		// Token: 0x04000F75 RID: 3957
		private static readonly ScriptableObject.ResetAndApplyDefaultInstancesDelegate ResetAndApplyDefaultInstancesDelegateField;

		// Token: 0x020007B5 RID: 1973
		private sealed class MethodInfoStoreGeneric_CreateInstance_Public_Static_T_0<T>
		{
			// Token: 0x04001F1E RID: 7966
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ScriptableObject.NativeMethodInfoPtr_CreateInstance_Public_Static_T_0, Il2CppClassPointerStore<ScriptableObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020007B6 RID: 1974
		// (Invoke) Token: 0x06002D65 RID: 11621
		private delegate void SetDirtyDelegate(IntPtr @this);

		// Token: 0x020007B7 RID: 1975
		// (Invoke) Token: 0x06002D67 RID: 11623
		private delegate IntPtr CreateScriptableObjectInstanceFromNameDelegate(IntPtr className);

		// Token: 0x020007B8 RID: 1976
		// (Invoke) Token: 0x06002D69 RID: 11625
		private delegate void ResetAndApplyDefaultInstancesDelegate(IntPtr obj);
	}
}
