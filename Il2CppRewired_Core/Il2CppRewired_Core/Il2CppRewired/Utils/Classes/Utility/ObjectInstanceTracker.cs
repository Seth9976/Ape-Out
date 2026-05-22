using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Il2CppRewired.Utils.Classes.Utility
{
	// Token: 0x02000204 RID: 516
	public class ObjectInstanceTracker : Object
	{
		// Token: 0x060035DB RID: 13787 RVA: 0x0010B4F8 File Offset: 0x001096F8
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectInstanceTracker()
		{
			Il2CppClassPointerStore<ObjectInstanceTracker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Utils.Classes.Utility", "ObjectInstanceTracker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectInstanceTracker>.NativeClassPtr);
			ObjectInstanceTracker.NativeFieldInfoPtr_uosTDNMCuodpKVbExRdngcDMBdu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectInstanceTracker>.NativeClassPtr, "uosTDNMCuodpKVbExRdngcDMBdu");
			ObjectInstanceTracker.NativeFieldInfoPtr_wnGuTlGOqIFYAoxZkUgdjJayskG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectInstanceTracker>.NativeClassPtr, "wnGuTlGOqIFYAoxZkUgdjJayskG");
			ObjectInstanceTracker.NativeFieldInfoPtr_dDZACoecPJSvlJLQowwrDUVzZyf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectInstanceTracker>.NativeClassPtr, "dDZACoecPJSvlJLQowwrDUVzZyf");
			ObjectInstanceTracker.NativeFieldInfoPtr_azIGRWzeEsGilfiqIVHlIkLlyhnw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectInstanceTracker>.NativeClassPtr, "azIGRWzeEsGilfiqIVHlIkLlyhnw");
			ObjectInstanceTracker.NativeFieldInfoPtr_MMpmgMlCJDAnHJjLOhQlrlwLWAa = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectInstanceTracker>.NativeClassPtr, "MMpmgMlCJDAnHJjLOhQlrlwLWAa");
			ObjectInstanceTracker.NativeFieldInfoPtr_DZaGfagjUPpXNumTtVEkcrPCUYo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectInstanceTracker>.NativeClassPtr, "DZaGfagjUPpXNumTtVEkcrPCUYo");
			ObjectInstanceTracker.NativeMethodInfoPtr_get_Default_Public_Static_get_ObjectInstanceTracker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectInstanceTracker>.NativeClassPtr, 100676653);
			ObjectInstanceTracker.NativeMethodInfoPtr_Register_Public_UInt32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectInstanceTracker>.NativeClassPtr, 100676654);
			ObjectInstanceTracker.NativeMethodInfoPtr_Unregister_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectInstanceTracker>.NativeClassPtr, 100676655);
			ObjectInstanceTracker.NativeMethodInfoPtr_TryGetInstance_Public_Boolean_UInt32_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectInstanceTracker>.NativeClassPtr, 100676656);
			ObjectInstanceTracker.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectInstanceTracker>.NativeClassPtr, 100676657);
			ObjectInstanceTracker.NativeMethodInfoPtr_oVDGrSAxKrDXHIrLCgtBQsySCAh_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectInstanceTracker>.NativeClassPtr, 100676658);
			ObjectInstanceTracker.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectInstanceTracker>.NativeClassPtr, 100676659);
			ObjectInstanceTracker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectInstanceTracker>.NativeClassPtr, 100676660);
		}

		// Token: 0x17001012 RID: 4114
		// (get) Token: 0x060035DC RID: 13788 RVA: 0x0010B640 File Offset: 0x00109840
		public unsafe static ObjectInstanceTracker Default
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 346417, RefRangeEnd = 346428, XrefRangeStart = 346405, XrefRangeEnd = 346417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectInstanceTracker.NativeMethodInfoPtr_get_Default_Public_Static_get_ObjectInstanceTracker_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectInstanceTracker>(intPtr3) : null;
			}
		}

		// Token: 0x060035DD RID: 13789 RVA: 0x0010B674 File Offset: 0x00109874
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 346430, RefRangeEnd = 346433, XrefRangeStart = 346428, XrefRangeEnd = 346430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint Register(Object instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectInstanceTracker.NativeMethodInfoPtr_Register_Public_UInt32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060035DE RID: 13790 RVA: 0x0010B6C4 File Offset: 0x001098C4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 346440, RefRangeEnd = 346443, XrefRangeStart = 346433, XrefRangeEnd = 346440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Unregister(uint instanceId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref instanceId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectInstanceTracker.NativeMethodInfoPtr_Unregister_Public_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060035DF RID: 13791 RVA: 0x0010B704 File Offset: 0x00109904
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 346465, RefRangeEnd = 346469, XrefRangeStart = 346443, XrefRangeEnd = 346465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetInstance<T>(uint instanceId, out T instance) where T : class
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref instanceId;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			IntPtr intPtr2;
			if (!typeof(T).IsValueType)
			{
				intPtr = 0;
				intPtr2 = &intPtr;
			}
			else
			{
				intPtr2 = ref instance;
			}
			ptr2 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ObjectInstanceTracker.MethodInfoStoreGeneric_TryGetInstance_Public_Boolean_UInt32_byref_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(T).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				instance = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x060035E0 RID: 13792 RVA: 0x0010B79C File Offset: 0x0010999C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346469, XrefRangeEnd = 346476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectInstanceTracker.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035E1 RID: 13793 RVA: 0x0010B7D0 File Offset: 0x001099D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346476, XrefRangeEnd = 346479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void oVDGrSAxKrDXHIrLCgtBQsySCAh(bool A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectInstanceTracker.NativeMethodInfoPtr_oVDGrSAxKrDXHIrLCgtBQsySCAh_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060035E2 RID: 13794 RVA: 0x0010B810 File Offset: 0x00109A10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346479, XrefRangeEnd = 346483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjectInstanceTracker.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035E3 RID: 13795 RVA: 0x0010B84C File Offset: 0x00109A4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346483, XrefRangeEnd = 346491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectInstanceTracker()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectInstanceTracker>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectInstanceTracker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035E4 RID: 13796 RVA: 0x000128F3 File Offset: 0x00010AF3
		public ObjectInstanceTracker(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700100C RID: 4108
		// (get) Token: 0x060035E5 RID: 13797 RVA: 0x0010B888 File Offset: 0x00109A88
		// (set) Token: 0x060035E6 RID: 13798 RVA: 0x000128FC File Offset: 0x00010AFC
		public unsafe static ObjectInstanceTracker uosTDNMCuodpKVbExRdngcDMBdu
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ObjectInstanceTracker.NativeFieldInfoPtr_uosTDNMCuodpKVbExRdngcDMBdu, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectInstanceTracker>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ObjectInstanceTracker.NativeFieldInfoPtr_uosTDNMCuodpKVbExRdngcDMBdu, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700100D RID: 4109
		// (get) Token: 0x060035E7 RID: 13799 RVA: 0x0010B8B0 File Offset: 0x00109AB0
		// (set) Token: 0x060035E8 RID: 13800 RVA: 0x0001290E File Offset: 0x00010B0E
		public unsafe Dictionary<uint, Object> wnGuTlGOqIFYAoxZkUgdjJayskG
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectInstanceTracker.NativeFieldInfoPtr_wnGuTlGOqIFYAoxZkUgdjJayskG);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<uint, Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectInstanceTracker.NativeFieldInfoPtr_wnGuTlGOqIFYAoxZkUgdjJayskG), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700100E RID: 4110
		// (get) Token: 0x060035E9 RID: 13801 RVA: 0x0010B8E0 File Offset: 0x00109AE0
		// (set) Token: 0x060035EA RID: 13802 RVA: 0x0001292D File Offset: 0x00010B2D
		public unsafe Object dDZACoecPJSvlJLQowwrDUVzZyf
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectInstanceTracker.NativeFieldInfoPtr_dDZACoecPJSvlJLQowwrDUVzZyf);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectInstanceTracker.NativeFieldInfoPtr_dDZACoecPJSvlJLQowwrDUVzZyf), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700100F RID: 4111
		// (get) Token: 0x060035EB RID: 13803 RVA: 0x0010B910 File Offset: 0x00109B10
		// (set) Token: 0x060035EC RID: 13804 RVA: 0x0001294C File Offset: 0x00010B4C
		public unsafe uint azIGRWzeEsGilfiqIVHlIkLlyhnw
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectInstanceTracker.NativeFieldInfoPtr_azIGRWzeEsGilfiqIVHlIkLlyhnw);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectInstanceTracker.NativeFieldInfoPtr_azIGRWzeEsGilfiqIVHlIkLlyhnw)) = value;
			}
		}

		// Token: 0x17001010 RID: 4112
		// (get) Token: 0x060035ED RID: 13805 RVA: 0x0010B938 File Offset: 0x00109B38
		// (set) Token: 0x060035EE RID: 13806 RVA: 0x00012967 File Offset: 0x00010B67
		public unsafe int MMpmgMlCJDAnHJjLOhQlrlwLWAa
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectInstanceTracker.NativeFieldInfoPtr_MMpmgMlCJDAnHJjLOhQlrlwLWAa);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectInstanceTracker.NativeFieldInfoPtr_MMpmgMlCJDAnHJjLOhQlrlwLWAa)) = value;
			}
		}

		// Token: 0x17001011 RID: 4113
		// (get) Token: 0x060035EF RID: 13807 RVA: 0x0010B960 File Offset: 0x00109B60
		// (set) Token: 0x060035F0 RID: 13808 RVA: 0x00012982 File Offset: 0x00010B82
		public unsafe bool DZaGfagjUPpXNumTtVEkcrPCUYo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectInstanceTracker.NativeFieldInfoPtr_DZaGfagjUPpXNumTtVEkcrPCUYo);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectInstanceTracker.NativeFieldInfoPtr_DZaGfagjUPpXNumTtVEkcrPCUYo)) = value;
			}
		}

		// Token: 0x04002DC4 RID: 11716
		private static readonly IntPtr NativeFieldInfoPtr_uosTDNMCuodpKVbExRdngcDMBdu;

		// Token: 0x04002DC5 RID: 11717
		private static readonly IntPtr NativeFieldInfoPtr_wnGuTlGOqIFYAoxZkUgdjJayskG;

		// Token: 0x04002DC6 RID: 11718
		private static readonly IntPtr NativeFieldInfoPtr_dDZACoecPJSvlJLQowwrDUVzZyf;

		// Token: 0x04002DC7 RID: 11719
		private static readonly IntPtr NativeFieldInfoPtr_azIGRWzeEsGilfiqIVHlIkLlyhnw;

		// Token: 0x04002DC8 RID: 11720
		private static readonly IntPtr NativeFieldInfoPtr_MMpmgMlCJDAnHJjLOhQlrlwLWAa;

		// Token: 0x04002DC9 RID: 11721
		private static readonly IntPtr NativeFieldInfoPtr_DZaGfagjUPpXNumTtVEkcrPCUYo;

		// Token: 0x04002DCA RID: 11722
		private static readonly IntPtr NativeMethodInfoPtr_get_Default_Public_Static_get_ObjectInstanceTracker_0;

		// Token: 0x04002DCB RID: 11723
		private static readonly IntPtr NativeMethodInfoPtr_Register_Public_UInt32_Object_0;

		// Token: 0x04002DCC RID: 11724
		private static readonly IntPtr NativeMethodInfoPtr_Unregister_Public_Void_UInt32_0;

		// Token: 0x04002DCD RID: 11725
		private static readonly IntPtr NativeMethodInfoPtr_TryGetInstance_Public_Boolean_UInt32_byref_T_0;

		// Token: 0x04002DCE RID: 11726
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04002DCF RID: 11727
		private static readonly IntPtr NativeMethodInfoPtr_oVDGrSAxKrDXHIrLCgtBQsySCAh_Private_Void_Boolean_0;

		// Token: 0x04002DD0 RID: 11728
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04002DD1 RID: 11729
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020004A7 RID: 1191
		public class Wrapper<T> : Object where T : class
		{
			// Token: 0x0600518A RID: 20874 RVA: 0x00172EC8 File Offset: 0x001710C8
			// Note: this type is marked as 'beforefieldinit'.
			static Wrapper()
			{
				Il2CppClassPointerStore<ObjectInstanceTracker.Wrapper<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ObjectInstanceTracker>.NativeClassPtr, "Wrapper`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectInstanceTracker.Wrapper<T>>.NativeClassPtr);
				ObjectInstanceTracker.Wrapper<T>.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectInstanceTracker.Wrapper<T>>.NativeClassPtr, "instance");
				ObjectInstanceTracker.Wrapper<T>.NativeFieldInfoPtr_instanceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectInstanceTracker.Wrapper<T>>.NativeClassPtr, "instanceId");
				ObjectInstanceTracker.Wrapper<T>.NativeFieldInfoPtr_dtfVFIuKQJAdfaDYTCSvRbwFRVjL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectInstanceTracker.Wrapper<T>>.NativeClassPtr, "dtfVFIuKQJAdfaDYTCSvRbwFRVjL");
				ObjectInstanceTracker.Wrapper<T>.NativeFieldInfoPtr_OGPdMfJpwRsSVAGxJGrPBlthhPYj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectInstanceTracker.Wrapper<T>>.NativeClassPtr, "OGPdMfJpwRsSVAGxJGrPBlthhPYj");
				ObjectInstanceTracker.Wrapper<T>.NativeMethodInfoPtr__ctor_Public_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectInstanceTracker.Wrapper<T>>.NativeClassPtr, 100676661);
				ObjectInstanceTracker.Wrapper<T>.NativeMethodInfoPtr__ctor_Public_Void_T_ObjectInstanceTracker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectInstanceTracker.Wrapper<T>>.NativeClassPtr, 100676662);
				ObjectInstanceTracker.Wrapper<T>.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectInstanceTracker.Wrapper<T>>.NativeClassPtr, 100676663);
				ObjectInstanceTracker.Wrapper<T>.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectInstanceTracker.Wrapper<T>>.NativeClassPtr, 100676664);
				ObjectInstanceTracker.Wrapper<T>.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectInstanceTracker.Wrapper<T>>.NativeClassPtr, 100676665);
			}

			// Token: 0x0600518B RID: 20875 RVA: 0x00172FE4 File Offset: 0x001711E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346395, XrefRangeEnd = 346397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Wrapper(T instance)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectInstanceTracker.Wrapper<T>>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					IntPtr* ptr2 = ptr;
					ref T ptr4;
					if (!typeof(T).IsValueType)
					{
						T t = instance;
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
						ptr4 = ref instance;
					}
					*ptr2 = ref ptr4;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectInstanceTracker.Wrapper<T>.NativeMethodInfoPtr__ctor_Public_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600518C RID: 20876 RVA: 0x0017307C File Offset: 0x0017127C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346397, XrefRangeEnd = 346398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Wrapper(T instance, ObjectInstanceTracker tracker)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectInstanceTracker.Wrapper<T>>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					IntPtr* ptr2 = ptr;
					ref T ptr4;
					if (!typeof(T).IsValueType)
					{
						T t = instance;
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
						ptr4 = ref instance;
					}
					*ptr2 = ref ptr4;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tracker);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectInstanceTracker.Wrapper<T>.NativeMethodInfoPtr__ctor_Public_Void_T_ObjectInstanceTracker_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600518D RID: 20877 RVA: 0x00173124 File Offset: 0x00171324
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346398, XrefRangeEnd = 346403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectInstanceTracker.Wrapper<T>.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600518E RID: 20878 RVA: 0x00173158 File Offset: 0x00171358
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346403, XrefRangeEnd = 346404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public new unsafe void Finalize()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjectInstanceTracker.Wrapper<T>.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600518F RID: 20879 RVA: 0x00173194 File Offset: 0x00171394
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346404, XrefRangeEnd = 346405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void Dispose(bool disposing)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref disposing;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjectInstanceTracker.Wrapper<T>.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005190 RID: 20880 RVA: 0x0001D6D6 File Offset: 0x0001B8D6
			public Wrapper(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001908 RID: 6408
			// (get) Token: 0x06005191 RID: 20881 RVA: 0x001731E0 File Offset: 0x001713E0
			// (set) Token: 0x06005192 RID: 20882 RVA: 0x00173208 File Offset: 0x00171408
			public unsafe T instance
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectInstanceTracker.Wrapper<T>.NativeFieldInfoPtr_instance);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectInstanceTracker.Wrapper<T>.NativeFieldInfoPtr_instance);
					Type typeFromHandle = typeof(T);
					if (!typeFromHandle.IsValueType)
					{
						if (!string.Equals(typeFromHandle.FullName, "System.String"))
						{
							IntPtr intPtr4;
							IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
							if (intPtr3 != 0)
							{
								intPtr4 = intPtr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
								{
									IntPtr intPtr5 = intPtr3;
									cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
									return;
								}
							}
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
						}
					}
					else
					{
						*intPtr2 = value;
					}
				}
			}

			// Token: 0x17001909 RID: 6409
			// (get) Token: 0x06005193 RID: 20883 RVA: 0x001732B0 File Offset: 0x001714B0
			// (set) Token: 0x06005194 RID: 20884 RVA: 0x0001D6DF File Offset: 0x0001B8DF
			public unsafe uint instanceId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectInstanceTracker.Wrapper<T>.NativeFieldInfoPtr_instanceId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectInstanceTracker.Wrapper<T>.NativeFieldInfoPtr_instanceId)) = value;
				}
			}

			// Token: 0x1700190A RID: 6410
			// (get) Token: 0x06005195 RID: 20885 RVA: 0x001732D8 File Offset: 0x001714D8
			// (set) Token: 0x06005196 RID: 20886 RVA: 0x0001D6FA File Offset: 0x0001B8FA
			public unsafe ObjectInstanceTracker dtfVFIuKQJAdfaDYTCSvRbwFRVjL
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectInstanceTracker.Wrapper<T>.NativeFieldInfoPtr_dtfVFIuKQJAdfaDYTCSvRbwFRVjL);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectInstanceTracker>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectInstanceTracker.Wrapper<T>.NativeFieldInfoPtr_dtfVFIuKQJAdfaDYTCSvRbwFRVjL), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700190B RID: 6411
			// (get) Token: 0x06005197 RID: 20887 RVA: 0x00173308 File Offset: 0x00171508
			// (set) Token: 0x06005198 RID: 20888 RVA: 0x0001D719 File Offset: 0x0001B919
			public unsafe bool OGPdMfJpwRsSVAGxJGrPBlthhPYj
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectInstanceTracker.Wrapper<T>.NativeFieldInfoPtr_OGPdMfJpwRsSVAGxJGrPBlthhPYj);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectInstanceTracker.Wrapper<T>.NativeFieldInfoPtr_OGPdMfJpwRsSVAGxJGrPBlthhPYj)) = value;
				}
			}

			// Token: 0x04004494 RID: 17556
			private static readonly IntPtr NativeFieldInfoPtr_instance;

			// Token: 0x04004495 RID: 17557
			private static readonly IntPtr NativeFieldInfoPtr_instanceId;

			// Token: 0x04004496 RID: 17558
			private static readonly IntPtr NativeFieldInfoPtr_dtfVFIuKQJAdfaDYTCSvRbwFRVjL;

			// Token: 0x04004497 RID: 17559
			private static readonly IntPtr NativeFieldInfoPtr_OGPdMfJpwRsSVAGxJGrPBlthhPYj;

			// Token: 0x04004498 RID: 17560
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_T_0;

			// Token: 0x04004499 RID: 17561
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_T_ObjectInstanceTracker_0;

			// Token: 0x0400449A RID: 17562
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

			// Token: 0x0400449B RID: 17563
			private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

			// Token: 0x0400449C RID: 17564
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;
		}

		// Token: 0x020004A8 RID: 1192
		private sealed class MethodInfoStoreGeneric_TryGetInstance_Public_Boolean_UInt32_byref_T_0<T>
		{
			// Token: 0x0400449D RID: 17565
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ObjectInstanceTracker.NativeMethodInfoPtr_TryGetInstance_Public_Boolean_UInt32_byref_T_0, Il2CppClassPointerStore<ObjectInstanceTracker>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
