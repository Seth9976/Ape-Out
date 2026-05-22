using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x020003E8 RID: 1000
	[Serializable]
	public class CADMethodRef : Object
	{
		// Token: 0x06004066 RID: 16486 RVA: 0x0012D464 File Offset: 0x0012B664
		// Note: this type is marked as 'beforefieldinit'.
		static CADMethodRef()
		{
			Il2CppClassPointerStore<CADMethodRef>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "CADMethodRef");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CADMethodRef>.NativeClassPtr);
			CADMethodRef.NativeFieldInfoPtr_ctor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CADMethodRef>.NativeClassPtr, "ctor");
			CADMethodRef.NativeFieldInfoPtr_typeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CADMethodRef>.NativeClassPtr, "typeName");
			CADMethodRef.NativeFieldInfoPtr_methodName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CADMethodRef>.NativeClassPtr, "methodName");
			CADMethodRef.NativeFieldInfoPtr_param_names = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CADMethodRef>.NativeClassPtr, "param_names");
			CADMethodRef.NativeFieldInfoPtr_generic_arg_names = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CADMethodRef>.NativeClassPtr, "generic_arg_names");
			CADMethodRef.NativeMethodInfoPtr_GetTypes_Private_Il2CppReferenceArray_1_Type_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMethodRef>.NativeClassPtr, 100672766);
			CADMethodRef.NativeMethodInfoPtr_Resolve_Public_MethodBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMethodRef>.NativeClassPtr, 100672767);
			CADMethodRef.NativeMethodInfoPtr__ctor_Public_Void_IMethodMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMethodRef>.NativeClassPtr, 100672768);
		}

		// Token: 0x06004067 RID: 16487 RVA: 0x0012D534 File Offset: 0x0012B734
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 223999, RefRangeEnd = 224002, XrefRangeStart = 223986, XrefRangeEnd = 223999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<Type> GetTypes(Il2CppStringArray typeArray)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(typeArray);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CADMethodRef.NativeMethodInfoPtr_GetTypes_Private_Il2CppReferenceArray_1_Type_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr3) : null;
			}
		}

		// Token: 0x06004068 RID: 16488 RVA: 0x0012D584 File Offset: 0x0012B784
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 224030, RefRangeEnd = 224031, XrefRangeStart = 224002, XrefRangeEnd = 224030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MethodBase Resolve()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CADMethodRef.NativeMethodInfoPtr_Resolve_Public_MethodBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodBase>(intPtr3) : null;
		}

		// Token: 0x06004069 RID: 16489 RVA: 0x0012D5C4 File Offset: 0x0012B7C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 224047, RefRangeEnd = 224048, XrefRangeStart = 224031, XrefRangeEnd = 224047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CADMethodRef(IMethodMessage msg)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CADMethodRef>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CADMethodRef.NativeMethodInfoPtr__ctor_Public_Void_IMethodMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600406A RID: 16490 RVA: 0x0001833C File Offset: 0x0001653C
		public CADMethodRef(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700103F RID: 4159
		// (get) Token: 0x0600406B RID: 16491 RVA: 0x0012D610 File Offset: 0x0012B810
		// (set) Token: 0x0600406C RID: 16492 RVA: 0x00018345 File Offset: 0x00016545
		public unsafe bool ctor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADMethodRef.NativeFieldInfoPtr_ctor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADMethodRef.NativeFieldInfoPtr_ctor)) = value;
			}
		}

		// Token: 0x17001040 RID: 4160
		// (get) Token: 0x0600406D RID: 16493 RVA: 0x0012D638 File Offset: 0x0012B838
		// (set) Token: 0x0600406E RID: 16494 RVA: 0x00018360 File Offset: 0x00016560
		public unsafe string typeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADMethodRef.NativeFieldInfoPtr_typeName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADMethodRef.NativeFieldInfoPtr_typeName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001041 RID: 4161
		// (get) Token: 0x0600406F RID: 16495 RVA: 0x0012D660 File Offset: 0x0012B860
		// (set) Token: 0x06004070 RID: 16496 RVA: 0x0001837F File Offset: 0x0001657F
		public unsafe string methodName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADMethodRef.NativeFieldInfoPtr_methodName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADMethodRef.NativeFieldInfoPtr_methodName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001042 RID: 4162
		// (get) Token: 0x06004071 RID: 16497 RVA: 0x0012D688 File Offset: 0x0012B888
		// (set) Token: 0x06004072 RID: 16498 RVA: 0x0001839E File Offset: 0x0001659E
		public unsafe Il2CppStringArray param_names
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADMethodRef.NativeFieldInfoPtr_param_names);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADMethodRef.NativeFieldInfoPtr_param_names), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001043 RID: 4163
		// (get) Token: 0x06004073 RID: 16499 RVA: 0x0012D6B8 File Offset: 0x0012B8B8
		// (set) Token: 0x06004074 RID: 16500 RVA: 0x000183BD File Offset: 0x000165BD
		public unsafe Il2CppStringArray generic_arg_names
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADMethodRef.NativeFieldInfoPtr_generic_arg_names);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADMethodRef.NativeFieldInfoPtr_generic_arg_names), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040034D2 RID: 13522
		private static readonly IntPtr NativeFieldInfoPtr_ctor;

		// Token: 0x040034D3 RID: 13523
		private static readonly IntPtr NativeFieldInfoPtr_typeName;

		// Token: 0x040034D4 RID: 13524
		private static readonly IntPtr NativeFieldInfoPtr_methodName;

		// Token: 0x040034D5 RID: 13525
		private static readonly IntPtr NativeFieldInfoPtr_param_names;

		// Token: 0x040034D6 RID: 13526
		private static readonly IntPtr NativeFieldInfoPtr_generic_arg_names;

		// Token: 0x040034D7 RID: 13527
		private static readonly IntPtr NativeMethodInfoPtr_GetTypes_Private_Il2CppReferenceArray_1_Type_Il2CppStringArray_0;

		// Token: 0x040034D8 RID: 13528
		private static readonly IntPtr NativeMethodInfoPtr_Resolve_Public_MethodBase_0;

		// Token: 0x040034D9 RID: 13529
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IMethodMessage_0;
	}
}
