using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x02000494 RID: 1172
	public class DictionaryHashHelpers : Object
	{
		// Token: 0x060047A0 RID: 18336 RVA: 0x0014A9C8 File Offset: 0x00148BC8
		// Note: this type is marked as 'beforefieldinit'.
		static DictionaryHashHelpers()
		{
			Il2CppClassPointerStore<DictionaryHashHelpers>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections.Generic", "DictionaryHashHelpers");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DictionaryHashHelpers>.NativeClassPtr);
			DictionaryHashHelpers.NativeFieldInfoPtr__SerializationInfoTable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DictionaryHashHelpers>.NativeClassPtr, "<SerializationInfoTable>k__BackingField");
			DictionaryHashHelpers.NativeMethodInfoPtr_get_SerializationInfoTable_Internal_Static_get_ConditionalWeakTable_2_Object_SerializationInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictionaryHashHelpers>.NativeClassPtr, 100674005);
		}

		// Token: 0x17001250 RID: 4688
		// (get) Token: 0x060047A1 RID: 18337 RVA: 0x0014AA20 File Offset: 0x00148C20
		public unsafe static ConditionalWeakTable<Object, SerializationInfo> SerializationInfoTable
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231127, XrefRangeEnd = 231131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictionaryHashHelpers.NativeMethodInfoPtr_get_SerializationInfoTable_Internal_Static_get_ConditionalWeakTable_2_Object_SerializationInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConditionalWeakTable<Object, SerializationInfo>>(intPtr3) : null;
			}
		}

		// Token: 0x060047A2 RID: 18338 RVA: 0x0001AF8F File Offset: 0x0001918F
		public DictionaryHashHelpers(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700124F RID: 4687
		// (get) Token: 0x060047A3 RID: 18339 RVA: 0x0014AA54 File Offset: 0x00148C54
		// (set) Token: 0x060047A4 RID: 18340 RVA: 0x0001AF98 File Offset: 0x00019198
		public unsafe static ConditionalWeakTable<Object, SerializationInfo> _SerializationInfoTable_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DictionaryHashHelpers.NativeFieldInfoPtr__SerializationInfoTable_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConditionalWeakTable<Object, SerializationInfo>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DictionaryHashHelpers.NativeFieldInfoPtr__SerializationInfoTable_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003A35 RID: 14901
		private static readonly IntPtr NativeFieldInfoPtr__SerializationInfoTable_k__BackingField;

		// Token: 0x04003A36 RID: 14902
		private static readonly IntPtr NativeMethodInfoPtr_get_SerializationInfoTable_Internal_Static_get_ConditionalWeakTable_2_Object_SerializationInfo_0;
	}
}
