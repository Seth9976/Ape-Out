using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020000FE RID: 254
	public class ChameleonKey : Object
	{
		// Token: 0x0600154D RID: 5453 RVA: 0x0006E6A0 File Offset: 0x0006C8A0
		// Note: this type is marked as 'beforefieldinit'.
		static ChameleonKey()
		{
			Il2CppClassPointerStore<ChameleonKey>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "ChameleonKey");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChameleonKey>.NativeClassPtr);
			ChameleonKey.NativeFieldInfoPtr_targetNS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChameleonKey>.NativeClassPtr, "targetNS");
			ChameleonKey.NativeFieldInfoPtr_chameleonLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChameleonKey>.NativeClassPtr, "chameleonLocation");
			ChameleonKey.NativeFieldInfoPtr_originalSchema = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChameleonKey>.NativeClassPtr, "originalSchema");
			ChameleonKey.NativeFieldInfoPtr_hashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChameleonKey>.NativeClassPtr, "hashCode");
			ChameleonKey.NativeMethodInfoPtr__ctor_Public_Void_String_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChameleonKey>.NativeClassPtr, 100666548);
			ChameleonKey.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChameleonKey>.NativeClassPtr, 100666549);
			ChameleonKey.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChameleonKey>.NativeClassPtr, 100666550);
		}

		// Token: 0x0600154E RID: 5454 RVA: 0x0006E75C File Offset: 0x0006C95C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 408996, RefRangeEnd = 408998, XrefRangeStart = 408994, XrefRangeEnd = 408996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChameleonKey(string ns, XmlSchema originalSchema)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChameleonKey>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(ns);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(originalSchema);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChameleonKey.NativeMethodInfoPtr__ctor_Public_Void_String_XmlSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600154F RID: 5455 RVA: 0x0006E7BC File Offset: 0x0006C9BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 408998, XrefRangeEnd = 408999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChameleonKey.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001550 RID: 5456 RVA: 0x0006E804 File Offset: 0x0006CA04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 408999, XrefRangeEnd = 409001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChameleonKey.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001551 RID: 5457 RVA: 0x00009795 File Offset: 0x00007995
		public ChameleonKey(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700071F RID: 1823
		// (get) Token: 0x06001552 RID: 5458 RVA: 0x0006E85C File Offset: 0x0006CA5C
		// (set) Token: 0x06001553 RID: 5459 RVA: 0x0000979E File Offset: 0x0000799E
		public unsafe string targetNS
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChameleonKey.NativeFieldInfoPtr_targetNS);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChameleonKey.NativeFieldInfoPtr_targetNS), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000720 RID: 1824
		// (get) Token: 0x06001554 RID: 5460 RVA: 0x0006E884 File Offset: 0x0006CA84
		// (set) Token: 0x06001555 RID: 5461 RVA: 0x000097BD File Offset: 0x000079BD
		public unsafe Uri chameleonLocation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChameleonKey.NativeFieldInfoPtr_chameleonLocation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChameleonKey.NativeFieldInfoPtr_chameleonLocation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000721 RID: 1825
		// (get) Token: 0x06001556 RID: 5462 RVA: 0x0006E8B4 File Offset: 0x0006CAB4
		// (set) Token: 0x06001557 RID: 5463 RVA: 0x000097DC File Offset: 0x000079DC
		public unsafe XmlSchema originalSchema
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChameleonKey.NativeFieldInfoPtr_originalSchema);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchema>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChameleonKey.NativeFieldInfoPtr_originalSchema), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000722 RID: 1826
		// (get) Token: 0x06001558 RID: 5464 RVA: 0x0006E8E4 File Offset: 0x0006CAE4
		// (set) Token: 0x06001559 RID: 5465 RVA: 0x000097FB File Offset: 0x000079FB
		public unsafe int hashCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChameleonKey.NativeFieldInfoPtr_hashCode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChameleonKey.NativeFieldInfoPtr_hashCode)) = value;
			}
		}

		// Token: 0x0400105A RID: 4186
		private static readonly IntPtr NativeFieldInfoPtr_targetNS;

		// Token: 0x0400105B RID: 4187
		private static readonly IntPtr NativeFieldInfoPtr_chameleonLocation;

		// Token: 0x0400105C RID: 4188
		private static readonly IntPtr NativeFieldInfoPtr_originalSchema;

		// Token: 0x0400105D RID: 4189
		private static readonly IntPtr NativeFieldInfoPtr_hashCode;

		// Token: 0x0400105E RID: 4190
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_XmlSchema_0;

		// Token: 0x0400105F RID: 4191
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001060 RID: 4192
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
	}
}
