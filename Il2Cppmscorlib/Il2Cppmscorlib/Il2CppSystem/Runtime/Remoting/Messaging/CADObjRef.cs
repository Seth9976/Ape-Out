using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x020003E7 RID: 999
	public class CADObjRef : Object
	{
		// Token: 0x0600405D RID: 16477 RVA: 0x0012D300 File Offset: 0x0012B500
		// Note: this type is marked as 'beforefieldinit'.
		static CADObjRef()
		{
			Il2CppClassPointerStore<CADObjRef>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "CADObjRef");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CADObjRef>.NativeClassPtr);
			CADObjRef.NativeFieldInfoPtr_objref = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CADObjRef>.NativeClassPtr, "objref");
			CADObjRef.NativeFieldInfoPtr_SourceDomain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CADObjRef>.NativeClassPtr, "SourceDomain");
			CADObjRef.NativeFieldInfoPtr_TypeInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CADObjRef>.NativeClassPtr, "TypeInfo");
			CADObjRef.NativeMethodInfoPtr__ctor_Public_Void_ObjRef_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADObjRef>.NativeClassPtr, 100672765);
		}

		// Token: 0x0600405E RID: 16478 RVA: 0x0012D380 File Offset: 0x0012B580
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223985, XrefRangeEnd = 223986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CADObjRef(ObjRef o, int sourceDomain)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CADObjRef>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sourceDomain;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CADObjRef.NativeMethodInfoPtr__ctor_Public_Void_ObjRef_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600405F RID: 16479 RVA: 0x000182DA File Offset: 0x000164DA
		public CADObjRef(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700103C RID: 4156
		// (get) Token: 0x06004060 RID: 16480 RVA: 0x0012D3DC File Offset: 0x0012B5DC
		// (set) Token: 0x06004061 RID: 16481 RVA: 0x000182E3 File Offset: 0x000164E3
		public unsafe ObjRef objref
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADObjRef.NativeFieldInfoPtr_objref);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjRef>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADObjRef.NativeFieldInfoPtr_objref), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700103D RID: 4157
		// (get) Token: 0x06004062 RID: 16482 RVA: 0x0012D40C File Offset: 0x0012B60C
		// (set) Token: 0x06004063 RID: 16483 RVA: 0x00018302 File Offset: 0x00016502
		public unsafe int SourceDomain
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADObjRef.NativeFieldInfoPtr_SourceDomain);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADObjRef.NativeFieldInfoPtr_SourceDomain)) = value;
			}
		}

		// Token: 0x1700103E RID: 4158
		// (get) Token: 0x06004064 RID: 16484 RVA: 0x0012D434 File Offset: 0x0012B634
		// (set) Token: 0x06004065 RID: 16485 RVA: 0x0001831D File Offset: 0x0001651D
		public unsafe Il2CppStructArray<byte> TypeInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADObjRef.NativeFieldInfoPtr_TypeInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADObjRef.NativeFieldInfoPtr_TypeInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040034CE RID: 13518
		private static readonly IntPtr NativeFieldInfoPtr_objref;

		// Token: 0x040034CF RID: 13519
		private static readonly IntPtr NativeFieldInfoPtr_SourceDomain;

		// Token: 0x040034D0 RID: 13520
		private static readonly IntPtr NativeFieldInfoPtr_TypeInfo;

		// Token: 0x040034D1 RID: 13521
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ObjRef_Int32_0;
	}
}
