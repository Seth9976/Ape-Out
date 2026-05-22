using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Resources
{
	// Token: 0x02000186 RID: 390
	public sealed class ResourceLocator : ValueType
	{
		// Token: 0x06001B30 RID: 6960 RVA: 0x0009F948 File Offset: 0x0009DB48
		// Note: this type is marked as 'beforefieldinit'.
		static ResourceLocator()
		{
			Il2CppClassPointerStore<ResourceLocator>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Resources", "ResourceLocator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResourceLocator>.NativeClassPtr);
			ResourceLocator.NativeFieldInfoPtr__value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceLocator>.NativeClassPtr, "_value");
			ResourceLocator.NativeFieldInfoPtr__dataPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceLocator>.NativeClassPtr, "_dataPos");
			ResourceLocator.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceLocator>.NativeClassPtr, 100667945);
			ResourceLocator.NativeMethodInfoPtr_get_DataPosition_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceLocator>.NativeClassPtr, 100667946);
			ResourceLocator.NativeMethodInfoPtr_get_Value_Internal_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceLocator>.NativeClassPtr, 100667947);
			ResourceLocator.NativeMethodInfoPtr_set_Value_Internal_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceLocator>.NativeClassPtr, 100667948);
			ResourceLocator.NativeMethodInfoPtr_CanCache_Internal_Static_Boolean_ResourceTypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceLocator>.NativeClassPtr, 100667949);
		}

		// Token: 0x06001B31 RID: 6961 RVA: 0x0009FA04 File Offset: 0x0009DC04
		[CallerCount(0)]
		public unsafe ResourceLocator(int dataPos, Object value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResourceLocator>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dataPos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceLocator.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x06001B32 RID: 6962 RVA: 0x0009FA64 File Offset: 0x0009DC64
		public unsafe int DataPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceLocator.NativeMethodInfoPtr_get_DataPosition_Internal_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x06001B33 RID: 6963 RVA: 0x0009FAA8 File Offset: 0x0009DCA8
		// (set) Token: 0x06001B34 RID: 6964 RVA: 0x0009FAEC File Offset: 0x0009DCEC
		public unsafe Object Value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceLocator.NativeMethodInfoPtr_get_Value_Internal_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 99329, RefRangeEnd = 99331, XrefRangeStart = 99329, XrefRangeEnd = 99331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceLocator.NativeMethodInfoPtr_set_Value_Internal_set_Void_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001B35 RID: 6965 RVA: 0x0009FB34 File Offset: 0x0009DD34
		[CallerCount(0)]
		public unsafe static bool CanCache(ResourceTypeCode value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceLocator.NativeMethodInfoPtr_CanCache_Internal_Static_Boolean_ResourceTypeCode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B36 RID: 6966 RVA: 0x00009332 File Offset: 0x00007532
		public ResourceLocator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001B37 RID: 6967 RVA: 0x0000933B File Offset: 0x0000753B
		public ResourceLocator()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResourceLocator>.NativeClassPtr))
		{
		}

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x06001B38 RID: 6968 RVA: 0x0009FB74 File Offset: 0x0009DD74
		// (set) Token: 0x06001B39 RID: 6969 RVA: 0x0000934D File Offset: 0x0000754D
		public unsafe Object _value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceLocator.NativeFieldInfoPtr__value);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceLocator.NativeFieldInfoPtr__value), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x06001B3A RID: 6970 RVA: 0x0009FBA4 File Offset: 0x0009DDA4
		// (set) Token: 0x06001B3B RID: 6971 RVA: 0x0000936C File Offset: 0x0000756C
		public unsafe int _dataPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceLocator.NativeFieldInfoPtr__dataPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceLocator.NativeFieldInfoPtr__dataPos)) = value;
			}
		}

		// Token: 0x040018A8 RID: 6312
		private static readonly IntPtr NativeFieldInfoPtr__value;

		// Token: 0x040018A9 RID: 6313
		private static readonly IntPtr NativeFieldInfoPtr__dataPos;

		// Token: 0x040018AA RID: 6314
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_Object_0;

		// Token: 0x040018AB RID: 6315
		private static readonly IntPtr NativeMethodInfoPtr_get_DataPosition_Internal_get_Int32_0;

		// Token: 0x040018AC RID: 6316
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Internal_get_Object_0;

		// Token: 0x040018AD RID: 6317
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Internal_set_Void_Object_0;

		// Token: 0x040018AE RID: 6318
		private static readonly IntPtr NativeMethodInfoPtr_CanCache_Internal_Static_Boolean_ResourceTypeCode_0;
	}
}
