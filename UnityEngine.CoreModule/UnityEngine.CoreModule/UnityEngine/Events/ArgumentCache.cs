using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Events
{
	// Token: 0x02000120 RID: 288
	[Serializable]
	public class ArgumentCache : Object
	{
		// Token: 0x0600178C RID: 6028 RVA: 0x0005AE20 File Offset: 0x00059020
		// Note: this type is marked as 'beforefieldinit'.
		static ArgumentCache()
		{
			Il2CppClassPointerStore<ArgumentCache>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Events", "ArgumentCache");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArgumentCache>.NativeClassPtr);
			ArgumentCache.NativeFieldInfoPtr_m_ObjectArgument = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArgumentCache>.NativeClassPtr, "m_ObjectArgument");
			ArgumentCache.NativeFieldInfoPtr_m_ObjectArgumentAssemblyTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArgumentCache>.NativeClassPtr, "m_ObjectArgumentAssemblyTypeName");
			ArgumentCache.NativeFieldInfoPtr_m_IntArgument = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArgumentCache>.NativeClassPtr, "m_IntArgument");
			ArgumentCache.NativeFieldInfoPtr_m_FloatArgument = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArgumentCache>.NativeClassPtr, "m_FloatArgument");
			ArgumentCache.NativeFieldInfoPtr_m_StringArgument = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArgumentCache>.NativeClassPtr, "m_StringArgument");
			ArgumentCache.NativeFieldInfoPtr_m_BoolArgument = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArgumentCache>.NativeClassPtr, "m_BoolArgument");
			ArgumentCache.NativeMethodInfoPtr_get_unityObjectArgument_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentCache>.NativeClassPtr, 100665463);
			ArgumentCache.NativeMethodInfoPtr_get_unityObjectArgumentAssemblyTypeName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentCache>.NativeClassPtr, 100665464);
			ArgumentCache.NativeMethodInfoPtr_get_intArgument_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentCache>.NativeClassPtr, 100665465);
			ArgumentCache.NativeMethodInfoPtr_get_floatArgument_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentCache>.NativeClassPtr, 100665466);
			ArgumentCache.NativeMethodInfoPtr_get_stringArgument_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentCache>.NativeClassPtr, 100665467);
			ArgumentCache.NativeMethodInfoPtr_get_boolArgument_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentCache>.NativeClassPtr, 100665468);
			ArgumentCache.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentCache>.NativeClassPtr, 100665469);
			ArgumentCache.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentCache>.NativeClassPtr, 100665470);
			ArgumentCache.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentCache>.NativeClassPtr, 100665471);
		}

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x0600178D RID: 6029 RVA: 0x0005AF7C File Offset: 0x0005917C
		// (set) Token: 0x060017A3 RID: 6051 RVA: 0x0000C9AF File Offset: 0x0000ABAF
		public unsafe Object unityObjectArgument
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgumentCache.NativeMethodInfoPtr_get_unityObjectArgument_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
			set
			{
				this.m_ObjectArgument = value;
				this.m_ObjectArgumentAssemblyTypeName = ((value != null) ? value.GetType().AssemblyQualifiedName : String.Empty);
			}
		}

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x0600178E RID: 6030 RVA: 0x0005AFBC File Offset: 0x000591BC
		public unsafe string unityObjectArgumentAssemblyTypeName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgumentCache.NativeMethodInfoPtr_get_unityObjectArgumentAssemblyTypeName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x0600178F RID: 6031 RVA: 0x0005AFF4 File Offset: 0x000591F4
		// (set) Token: 0x060017A4 RID: 6052 RVA: 0x0000C9DA File Offset: 0x0000ABDA
		public unsafe int intArgument
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgumentCache.NativeMethodInfoPtr_get_intArgument_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_IntArgument = value;
			}
		}

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x06001790 RID: 6032 RVA: 0x0005B030 File Offset: 0x00059230
		// (set) Token: 0x060017A5 RID: 6053 RVA: 0x0000C9E4 File Offset: 0x0000ABE4
		public unsafe float floatArgument
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 500679, RefRangeEnd = 500689, XrefRangeStart = 500679, XrefRangeEnd = 500679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgumentCache.NativeMethodInfoPtr_get_floatArgument_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_FloatArgument = value;
			}
		}

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x06001791 RID: 6033 RVA: 0x0005B06C File Offset: 0x0005926C
		// (set) Token: 0x060017A6 RID: 6054 RVA: 0x0000C9EE File Offset: 0x0000ABEE
		public unsafe string stringArgument
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgumentCache.NativeMethodInfoPtr_get_stringArgument_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				this.m_StringArgument = value;
			}
		}

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x06001792 RID: 6034 RVA: 0x0005B0A4 File Offset: 0x000592A4
		// (set) Token: 0x060017A7 RID: 6055 RVA: 0x0000C9F8 File Offset: 0x0000ABF8
		public unsafe bool boolArgument
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgumentCache.NativeMethodInfoPtr_get_boolArgument_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_BoolArgument = value;
			}
		}

		// Token: 0x06001793 RID: 6035 RVA: 0x0005B0E0 File Offset: 0x000592E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500689, XrefRangeEnd = 500690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnBeforeSerialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgumentCache.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001794 RID: 6036 RVA: 0x0005B114 File Offset: 0x00059314
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnAfterDeserialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgumentCache.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001795 RID: 6037 RVA: 0x0005B148 File Offset: 0x00059348
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArgumentCache()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArgumentCache>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgumentCache.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001796 RID: 6038 RVA: 0x0000C8F8 File Offset: 0x0000AAF8
		public ArgumentCache(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x06001797 RID: 6039 RVA: 0x0005B184 File Offset: 0x00059384
		// (set) Token: 0x06001798 RID: 6040 RVA: 0x0000C901 File Offset: 0x0000AB01
		public unsafe Object m_ObjectArgument
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgumentCache.NativeFieldInfoPtr_m_ObjectArgument);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgumentCache.NativeFieldInfoPtr_m_ObjectArgument), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x06001799 RID: 6041 RVA: 0x0005B1B4 File Offset: 0x000593B4
		// (set) Token: 0x0600179A RID: 6042 RVA: 0x0000C920 File Offset: 0x0000AB20
		public unsafe string m_ObjectArgumentAssemblyTypeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgumentCache.NativeFieldInfoPtr_m_ObjectArgumentAssemblyTypeName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgumentCache.NativeFieldInfoPtr_m_ObjectArgumentAssemblyTypeName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x0600179B RID: 6043 RVA: 0x0005B1DC File Offset: 0x000593DC
		// (set) Token: 0x0600179C RID: 6044 RVA: 0x0000C93F File Offset: 0x0000AB3F
		public unsafe int m_IntArgument
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgumentCache.NativeFieldInfoPtr_m_IntArgument);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgumentCache.NativeFieldInfoPtr_m_IntArgument)) = value;
			}
		}

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x0600179D RID: 6045 RVA: 0x0005B204 File Offset: 0x00059404
		// (set) Token: 0x0600179E RID: 6046 RVA: 0x0000C95A File Offset: 0x0000AB5A
		public unsafe float m_FloatArgument
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgumentCache.NativeFieldInfoPtr_m_FloatArgument);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgumentCache.NativeFieldInfoPtr_m_FloatArgument)) = value;
			}
		}

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x0600179F RID: 6047 RVA: 0x0005B22C File Offset: 0x0005942C
		// (set) Token: 0x060017A0 RID: 6048 RVA: 0x0000C975 File Offset: 0x0000AB75
		public unsafe string m_StringArgument
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgumentCache.NativeFieldInfoPtr_m_StringArgument);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgumentCache.NativeFieldInfoPtr_m_StringArgument), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x060017A1 RID: 6049 RVA: 0x0005B254 File Offset: 0x00059454
		// (set) Token: 0x060017A2 RID: 6050 RVA: 0x0000C994 File Offset: 0x0000AB94
		public unsafe bool m_BoolArgument
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgumentCache.NativeFieldInfoPtr_m_BoolArgument);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgumentCache.NativeFieldInfoPtr_m_BoolArgument)) = value;
			}
		}

		// Token: 0x04001277 RID: 4727
		private static readonly IntPtr NativeFieldInfoPtr_m_ObjectArgument;

		// Token: 0x04001278 RID: 4728
		private static readonly IntPtr NativeFieldInfoPtr_m_ObjectArgumentAssemblyTypeName;

		// Token: 0x04001279 RID: 4729
		private static readonly IntPtr NativeFieldInfoPtr_m_IntArgument;

		// Token: 0x0400127A RID: 4730
		private static readonly IntPtr NativeFieldInfoPtr_m_FloatArgument;

		// Token: 0x0400127B RID: 4731
		private static readonly IntPtr NativeFieldInfoPtr_m_StringArgument;

		// Token: 0x0400127C RID: 4732
		private static readonly IntPtr NativeFieldInfoPtr_m_BoolArgument;

		// Token: 0x0400127D RID: 4733
		private static readonly IntPtr NativeMethodInfoPtr_get_unityObjectArgument_Public_get_Object_0;

		// Token: 0x0400127E RID: 4734
		private static readonly IntPtr NativeMethodInfoPtr_get_unityObjectArgumentAssemblyTypeName_Public_get_String_0;

		// Token: 0x0400127F RID: 4735
		private static readonly IntPtr NativeMethodInfoPtr_get_intArgument_Public_get_Int32_0;

		// Token: 0x04001280 RID: 4736
		private static readonly IntPtr NativeMethodInfoPtr_get_floatArgument_Public_get_Single_0;

		// Token: 0x04001281 RID: 4737
		private static readonly IntPtr NativeMethodInfoPtr_get_stringArgument_Public_get_String_0;

		// Token: 0x04001282 RID: 4738
		private static readonly IntPtr NativeMethodInfoPtr_get_boolArgument_Public_get_Boolean_0;

		// Token: 0x04001283 RID: 4739
		private static readonly IntPtr NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0;

		// Token: 0x04001284 RID: 4740
		private static readonly IntPtr NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0;

		// Token: 0x04001285 RID: 4741
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
