using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Globalization;
using Il2CppSystem.Reflection;
using Il2CppSystem.Text;
using Il2CppSystem.Xml;

namespace Il2CppRewired.Utils.Classes.Data
{
	// Token: 0x020001BC RID: 444
	public sealed class SerializedObject : Object
	{
		// Token: 0x06002E49 RID: 11849 RVA: 0x000E67D0 File Offset: 0x000E49D0
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedObject()
		{
			Il2CppClassPointerStore<SerializedObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Utils.Classes.Data", "SerializedObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedObject>.NativeClassPtr);
			SerializedObject.NativeFieldInfoPtr_FiIKcyXkfWzcUzCVQFMTpdMlBPw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedObject>.NativeClassPtr, "FiIKcyXkfWzcUzCVQFMTpdMlBPw");
			SerializedObject.NativeFieldInfoPtr_JMsyokbFdjEdXVperCSdkbmARhag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedObject>.NativeClassPtr, "JMsyokbFdjEdXVperCSdkbmARhag");
			SerializedObject.NativeFieldInfoPtr_HLmDmUQWoPLmPsyHTHuhoXXcGIu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedObject>.NativeClassPtr, "HLmDmUQWoPLmPsyHTHuhoXXcGIu");
			SerializedObject.NativeFieldInfoPtr_GikxJncSATqBihSQYheLeudpKBe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedObject>.NativeClassPtr, "GikxJncSATqBihSQYheLeudpKBe");
			SerializedObject.NativeFieldInfoPtr_NMTVJtrJoYumHwXWPbrJysMwPVR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedObject>.NativeClassPtr, "NMTVJtrJoYumHwXWPbrJysMwPVR");
			SerializedObject.NativeFieldInfoPtr_pAGfnheFMaBVdmJCJXDfGEBrDpI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedObject>.NativeClassPtr, "pAGfnheFMaBVdmJCJXDfGEBrDpI");
			SerializedObject.NativeFieldInfoPtr_YtejDiqaLAxxRnmscggDavQFcLz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedObject>.NativeClassPtr, "YtejDiqaLAxxRnmscggDavQFcLz");
			SerializedObject.NativeFieldInfoPtr_ikzytTXFFDqNPkVCCmeRclgjukz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedObject>.NativeClassPtr, "ikzytTXFFDqNPkVCCmeRclgjukz");
			SerializedObject.NativeFieldInfoPtr_LSUfbRdNVkGYkofhpojegAuXaApi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedObject>.NativeClassPtr, "LSUfbRdNVkGYkofhpojegAuXaApi");
			SerializedObject.NativeFieldInfoPtr_xKHIFFzxxSCqQovYtTvauauWzuS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedObject>.NativeClassPtr, "xKHIFFzxxSCqQovYtTvauauWzuS");
			SerializedObject.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedObject>.NativeClassPtr, 100675241);
			SerializedObject.NativeMethodInfoPtr__ctor_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedObject>.NativeClassPtr, 100675242);
			SerializedObject.NativeMethodInfoPtr__ctor_Public_Void_Type_ObjectType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedObject>.NativeClassPtr, 100675243);
			SerializedObject.NativeMethodInfoPtr__ctor_Public_Void_Type_ObjectType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedObject>.NativeClassPtr, 100675244);
			SerializedObject.NativeMethodInfoPtr__ctor_Public_Void_Type_IDictionary_2_String_Object_ObjectType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedObject>.NativeClassPtr, 100675245);
			SerializedObject.NativeMethodInfoPtr_get_allowDuplicateKeys_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedObject>.NativeClassPtr, 100675246);
			SerializedObject.NativeMethodInfoPtr_get_objectType_Public_get_ObjectType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedObject>.NativeClassPtr, 100675247);
			SerializedObject.NativeMethodInfoPtr_set_objectType_Public_set_Void_ObjectType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedObject>.NativeClassPtr, 100675248);
			SerializedObject.NativeMethodInfoPtr_get_type_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedObject>.NativeClassPtr, 100675249);
			SerializedObject.NativeMethodInfoPtr_get_xmlInfo_Public_get_XmlInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedObject>.NativeClassPtr, 100675250);
			SerializedObject.NativeMethodInfoPtr_set_xmlInfo_Public_set_Void_XmlInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedObject>.NativeClassPtr, 100675251);
			SerializedObject.NativeMethodInfoPtr_get_count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedObject>.NativeClassPtr, 100675252);
			SerializedObject.NativeMethodInfoPtr_get_Item_Public_get_Field_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedObject>.NativeClassPtr, 100675253);
			SerializedObject.NativeMethodInfoPtr_Add_Public_Void_String_T_FieldOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedObject>.NativeClassPtr, 100675254);
			SerializedObject.NativeMethodInfoPtr_Add_Public_Void_Type_String_Object_FieldOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedObject>.NativeClassPtr, 100675255);
			SerializedObject.NativeMethodInfoPtr_Add_Public_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedObject>.NativeClassPtr, 100675256);
			SerializedObject.NativeMethodInfoPtr_Remove_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedObject>.NativeClassPtr, 100675257);
			SerializedObject.NativeMethodInfoPtr_Contains_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedObject>.NativeClassPtr, 100675258);
			SerializedObject.NativeMethodInfoPtr_GetDataType_Public_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedObject>.NativeClassPtr, 100675259);
			SerializedObject.NativeMethodInfoPtr_TryGetOriginalValue_Public_Boolean_String_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedObject>.NativeClassPtr, 100675260);
			SerializedObject.NativeMethodInfoPtr_GetEntry_Public_Field_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedObject>.NativeClassPtr, 100675261);
			SerializedObject.NativeMethodInfoPtr_GetOriginalValue_Public_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedObject>.NativeClassPtr, 100675262);
			SerializedObject.NativeMethodInfoPtr_GetOriginalValue_Public_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedObject>.NativeClassPtr, 100675263);
			SerializedObject.NativeMethodInfoPtr_GetOriginalValue_Public_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedObject>.NativeClassPtr, 100675264);
			SerializedObject.NativeMethodInfoPtr_GetOriginalValue_Public_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedObject>.NativeClassPtr, 100675265);
			SerializedObject.NativeMethodInfoPtr_TryGetDeserializedValue_Public_Boolean_String_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedObject>.NativeClassPtr, 100675266);
			SerializedObject.NativeMethodInfoPtr_TryGetDeserializedValue_Public_Boolean_Int32_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedObject>.NativeClassPtr, 100675267);
			SerializedObject.NativeMethodInfoPtr_TryGetDeserializedValueByRef_Public_Boolean_String_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedObject>.NativeClassPtr, 100675268);
			SerializedObject.NativeMethodInfoPtr_TryGetDeserializedValueByRef_Public_Boolean_Int32_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedObject>.NativeClassPtr, 100675269);
			SerializedObject.NativeMethodInfoPtr_ToXmlString_Public_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedObject>.NativeClassPtr, 100675270);
			SerializedObject.NativeMethodInfoPtr_ToJsonString_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedObject>.NativeClassPtr, 100675271);
			SerializedObject.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedObject>.NativeClassPtr, 100675272);
			SerializedObject.NativeMethodInfoPtr_mUyZVRMMkRvKKYwVqhvyPdbbQmp_Private_Void_XmlWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedObject>.NativeClassPtr, 100675273);
			SerializedObject.NativeMethodInfoPtr_GiKkONyoOShEkeVMhBQRCYIdsIdF_Private_Void_XmlWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedObject>.NativeClassPtr, 100675274);
			SerializedObject.NativeMethodInfoPtr_Rewired_Utils_Interfaces_IExportToXml_get_writesOwnElementTag_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedObject>.NativeClassPtr, 100675275);
			SerializedObject.NativeMethodInfoPtr_yqFnyTPlTcsxOpNfczpQbhAGOAc_Private_Virtual_Final_New_Void_XmlWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedObject>.NativeClassPtr, 100675276);
			SerializedObject.NativeMethodInfoPtr_yBPNZoQHfsSXPAzZGancBhILnSl_Private_Virtual_Final_New_Void_StringBuilder_Action_2_StringBuilder_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedObject>.NativeClassPtr, 100675277);
			SerializedObject.NativeMethodInfoPtr_OqwrzEkoFwfSZbXYvPlBdFfeBSB_Private_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedObject>.NativeClassPtr, 100675278);
			SerializedObject.NativeMethodInfoPtr_yXFgwxHoGfVMjddPOGaNCbAoRiGf_Private_Virtual_Final_New_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedObject>.NativeClassPtr, 100675279);
			SerializedObject.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Rewired_Utils_Classes_Data_SerializedObject_Field__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Field_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedObject>.NativeClassPtr, 100675280);
			SerializedObject.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedObject>.NativeClassPtr, 100675281);
			SerializedObject.NativeMethodInfoPtr_XQmfXzeOBltQMFMaZowhIixSicuJ_Private_Static_Boolean_Object_byref_T_NumberStyles_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedObject>.NativeClassPtr, 100675282);
			SerializedObject.NativeMethodInfoPtr_XQmfXzeOBltQMFMaZowhIixSicuJ_Private_Static_Boolean_Type_Object_byref_Object_NumberStyles_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedObject>.NativeClassPtr, 100675283);
			SerializedObject.NativeMethodInfoPtr_wiCpEoQDqhfPGaPLCVdwHhUxzjmB_Private_Static_Boolean_Type_SerializedObject_byref_Object_NumberStyles_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedObject>.NativeClassPtr, 100675284);
			SerializedObject.NativeMethodInfoPtr_FromJson_Public_Static_SerializedObject_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedObject>.NativeClassPtr, 100675285);
			SerializedObject.NativeMethodInfoPtr_FromXml_Public_Static_SerializedObject_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedObject>.NativeClassPtr, 100675286);
			SerializedObject.NativeMethodInfoPtr_YMgNUXMQRociSwYYiprrbkRuoWF_Private_Static_Boolean_FieldInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedObject>.NativeClassPtr, 100675287);
			SerializedObject.NativeMethodInfoPtr_tzgeCLoobRplMnfXcAIhCfElUaw_Private_Static_String_FieldInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedObject>.NativeClassPtr, 100675288);
			SerializedObject.NativeMethodInfoPtr_SHBEMVHHpBKLLAiktYymvTBFrQG_Private_Static_Boolean_PropertyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedObject>.NativeClassPtr, 100675289);
			SerializedObject.NativeMethodInfoPtr_VhkNaormzRtGDCjQbFblKAxLgoyd_Private_Static_String_PropertyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedObject>.NativeClassPtr, 100675290);
		}

		// Token: 0x06002E4A RID: 11850 RVA: 0x000E6CB0 File Offset: 0x000E4EB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331777, XrefRangeEnd = 331778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedObject()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedObject>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedObject.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E4B RID: 11851 RVA: 0x000E6CEC File Offset: 0x000E4EEC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 331784, RefRangeEnd = 331787, XrefRangeStart = 331778, XrefRangeEnd = 331784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedObject(int capacity)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedObject>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedObject.NativeMethodInfoPtr__ctor_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002E4C RID: 11852 RVA: 0x000E6D34 File Offset: 0x000E4F34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331787, XrefRangeEnd = 331788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedObject(Type type, SerializedObject.ObjectType objectType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedObject>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref objectType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedObject.NativeMethodInfoPtr__ctor_Public_Void_Type_ObjectType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E4D RID: 11853 RVA: 0x000E6D90 File Offset: 0x000E4F90
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 331791, RefRangeEnd = 331803, XrefRangeStart = 331788, XrefRangeEnd = 331791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedObject(Type type, SerializedObject.ObjectType objectType, int capacity)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedObject>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref objectType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref capacity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedObject.NativeMethodInfoPtr__ctor_Public_Void_Type_ObjectType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E4E RID: 11854 RVA: 0x000E6DF8 File Offset: 0x000E4FF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331803, XrefRangeEnd = 331831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedObject(Type type, IDictionary<string, Object> dictionary, SerializedObject.ObjectType objectType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedObject>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dictionary);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref objectType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedObject.NativeMethodInfoPtr__ctor_Public_Void_Type_IDictionary_2_String_Object_ObjectType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000EB8 RID: 3768
		// (get) Token: 0x06002E4F RID: 11855 RVA: 0x000E6E64 File Offset: 0x000E5064
		public unsafe bool allowDuplicateKeys
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedObject.NativeMethodInfoPtr_get_allowDuplicateKeys_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000EB9 RID: 3769
		// (get) Token: 0x06002E50 RID: 11856 RVA: 0x000E6EA0 File Offset: 0x000E50A0
		// (set) Token: 0x06002E51 RID: 11857 RVA: 0x000E6EDC File Offset: 0x000E50DC
		public unsafe SerializedObject.ObjectType objectType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedObject.NativeMethodInfoPtr_get_objectType_Public_get_ObjectType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331831, XrefRangeEnd = 331833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedObject.NativeMethodInfoPtr_set_objectType_Public_set_Void_ObjectType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000EBA RID: 3770
		// (get) Token: 0x06002E52 RID: 11858 RVA: 0x000E6F1C File Offset: 0x000E511C
		public unsafe Type type
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedObject.NativeMethodInfoPtr_get_type_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x17000EBB RID: 3771
		// (get) Token: 0x06002E53 RID: 11859 RVA: 0x000E6F5C File Offset: 0x000E515C
		// (set) Token: 0x06002E54 RID: 11860 RVA: 0x000E6F9C File Offset: 0x000E519C
		public unsafe SerializedObject.XmlInfo xmlInfo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedObject.NativeMethodInfoPtr_get_xmlInfo_Public_get_XmlInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedObject.XmlInfo>(intPtr3) : null;
			}
			[CallerCount(58)]
			[CachedScanResults(RefRangeStart = 18562, RefRangeEnd = 18620, XrefRangeStart = 18562, XrefRangeEnd = 18620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedObject.NativeMethodInfoPtr_set_xmlInfo_Public_set_Void_XmlInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000EBC RID: 3772
		// (get) Token: 0x06002E55 RID: 11861 RVA: 0x000E6FE0 File Offset: 0x000E51E0
		public unsafe int count
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 331834, RefRangeEnd = 331839, XrefRangeStart = 331833, XrefRangeEnd = 331834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedObject.NativeMethodInfoPtr_get_count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000EBD RID: 3773
		public unsafe SerializedObject.Field this[int index]
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 331844, RefRangeEnd = 331847, XrefRangeStart = 331839, XrefRangeEnd = 331844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedObject.NativeMethodInfoPtr_get_Item_Public_get_Field_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new SerializedObject.Field(intPtr);
				}
			}
		}

		// Token: 0x06002E57 RID: 11863 RVA: 0x000E7060 File Offset: 0x000E5260
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 331852, RefRangeEnd = 331861, XrefRangeStart = 331847, XrefRangeEnd = 331852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add<T>(string fieldName, T value, SerializedObject.FieldOptions options = SerializedObject.FieldOptions.None)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fieldName);
			}
			IntPtr* ptr2 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			ref T ptr4;
			if (!typeof(T).IsValueType)
			{
				T t = value;
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
				ptr4 = ref value;
			}
			*ptr2 = ref ptr4;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedObject.MethodInfoStoreGeneric_Add_Public_Void_String_T_FieldOptions_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E58 RID: 11864 RVA: 0x000E7110 File Offset: 0x000E5310
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 331870, RefRangeEnd = 331876, XrefRangeStart = 331861, XrefRangeEnd = 331870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(Type type, string fieldName, Object value, SerializedObject.FieldOptions options = SerializedObject.FieldOptions.None)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(fieldName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedObject.NativeMethodInfoPtr_Add_Public_Void_Type_String_Object_FieldOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E59 RID: 11865 RVA: 0x000E7184 File Offset: 0x000E5384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331876, XrefRangeEnd = 331879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(string fieldName, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fieldName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedObject.NativeMethodInfoPtr_Add_Public_Void_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E5A RID: 11866 RVA: 0x000E71D8 File Offset: 0x000E53D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331879, XrefRangeEnd = 331882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Remove(string fieldName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fieldName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedObject.NativeMethodInfoPtr_Remove_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002E5B RID: 11867 RVA: 0x000E7228 File Offset: 0x000E5428
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331882, XrefRangeEnd = 331884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Contains(string fieldName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fieldName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedObject.NativeMethodInfoPtr_Contains_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002E5C RID: 11868 RVA: 0x000E7278 File Offset: 0x000E5478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331884, XrefRangeEnd = 331886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Type GetDataType(string fieldName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fieldName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedObject.NativeMethodInfoPtr_GetDataType_Public_Type_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06002E5D RID: 11869 RVA: 0x000E72C8 File Offset: 0x000E54C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331886, XrefRangeEnd = 331889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetOriginalValue(string fieldName, out Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fieldName);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SerializedObject.NativeMethodInfoPtr_TryGetOriginalValue_Public_Boolean_String_byref_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			value = ((intPtr4 == 0) ? null : new Object(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06002E5E RID: 11870 RVA: 0x000E7338 File Offset: 0x000E5538
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331889, XrefRangeEnd = 331894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedObject.Field GetEntry(string fieldName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fieldName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedObject.NativeMethodInfoPtr_GetEntry_Public_Field_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new SerializedObject.Field(intPtr);
			}
		}

		// Token: 0x06002E5F RID: 11871 RVA: 0x000E7380 File Offset: 0x000E5580
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331894, XrefRangeEnd = 331897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetOriginalValue(string fieldName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fieldName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedObject.NativeMethodInfoPtr_GetOriginalValue_Public_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002E60 RID: 11872 RVA: 0x000E73D0 File Offset: 0x000E55D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331897, XrefRangeEnd = 331899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetOriginalValue(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedObject.NativeMethodInfoPtr_GetOriginalValue_Public_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002E61 RID: 11873 RVA: 0x000E741C File Offset: 0x000E561C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331899, XrefRangeEnd = 331903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetOriginalValue<T>(string fieldName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fieldName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedObject.MethodInfoStoreGeneric_GetOriginalValue_Public_T_String_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06002E62 RID: 11874 RVA: 0x000E7468 File Offset: 0x000E5668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331903, XrefRangeEnd = 331906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetOriginalValue<T>(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedObject.MethodInfoStoreGeneric_GetOriginalValue_Public_T_Int32_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06002E63 RID: 11875 RVA: 0x000E74B0 File Offset: 0x000E56B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331906, XrefRangeEnd = 331916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetDeserializedValue<T>(string fieldName, out T value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fieldName);
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
				intPtr2 = ref value;
			}
			ptr2 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(SerializedObject.MethodInfoStoreGeneric_TryGetDeserializedValue_Public_Boolean_String_byref_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(T).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				value = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06002E64 RID: 11876 RVA: 0x000E754C File Offset: 0x000E574C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 331928, RefRangeEnd = 331931, XrefRangeStart = 331916, XrefRangeEnd = 331928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetDeserializedValue<T>(int index, out T value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
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
				intPtr2 = ref value;
			}
			ptr2 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(SerializedObject.MethodInfoStoreGeneric_TryGetDeserializedValue_Public_Boolean_Int32_byref_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(T).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				value = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06002E65 RID: 11877 RVA: 0x000E75E4 File Offset: 0x000E57E4
		[CallerCount(0)]
		public unsafe bool TryGetDeserializedValueByRef<T>(string fieldName, ref T value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fieldName);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SerializedObject.MethodInfoStoreGeneric_TryGetDeserializedValueByRef_Public_Boolean_String_byref_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			value = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06002E66 RID: 11878 RVA: 0x000E765C File Offset: 0x000E585C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331931, XrefRangeEnd = 331932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetDeserializedValueByRef<T>(int index, ref T value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SerializedObject.MethodInfoStoreGeneric_TryGetDeserializedValueByRef_Public_Boolean_Int32_byref_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			value = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06002E67 RID: 11879 RVA: 0x000E76D0 File Offset: 0x000E58D0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 331951, RefRangeEnd = 331957, XrefRangeStart = 331932, XrefRangeEnd = 331951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToXmlString(bool writeDocumentTag)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref writeDocumentTag;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedObject.NativeMethodInfoPtr_ToXmlString_Public_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002E68 RID: 11880 RVA: 0x000E7714 File Offset: 0x000E5914
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331957, XrefRangeEnd = 331958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToJsonString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedObject.NativeMethodInfoPtr_ToJsonString_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002E69 RID: 11881 RVA: 0x000E774C File Offset: 0x000E594C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331958, XrefRangeEnd = 332025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedObject.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002E6A RID: 11882 RVA: 0x000E7784 File Offset: 0x000E5984
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 332035, RefRangeEnd = 332037, XrefRangeStart = 332025, XrefRangeEnd = 332035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void mUyZVRMMkRvKKYwVqhvyPdbbQmp(XmlWriter A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedObject.NativeMethodInfoPtr_mUyZVRMMkRvKKYwVqhvyPdbbQmp_Private_Void_XmlWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002E6B RID: 11883 RVA: 0x000E77C8 File Offset: 0x000E59C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 332064, RefRangeEnd = 332065, XrefRangeStart = 332037, XrefRangeEnd = 332064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GiKkONyoOShEkeVMhBQRCYIdsIdF(XmlWriter A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedObject.NativeMethodInfoPtr_GiKkONyoOShEkeVMhBQRCYIdsIdF_Private_Void_XmlWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000EBE RID: 3774
		// (get) Token: 0x06002E6C RID: 11884 RVA: 0x000E780C File Offset: 0x000E5A0C
		public unsafe bool Rewired.Utils.Interfaces.IExportToXml.writesOwnElementTag
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedObject.NativeMethodInfoPtr_Rewired_Utils_Interfaces_IExportToXml_get_writesOwnElementTag_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002E6D RID: 11885 RVA: 0x000E7848 File Offset: 0x000E5A48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332065, XrefRangeEnd = 332066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void yqFnyTPlTcsxOpNfczpQbhAGOAc(XmlWriter A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedObject.NativeMethodInfoPtr_yqFnyTPlTcsxOpNfczpQbhAGOAc_Private_Virtual_Final_New_Void_XmlWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002E6E RID: 11886 RVA: 0x000E788C File Offset: 0x000E5A8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332066, XrefRangeEnd = 332106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void yBPNZoQHfsSXPAzZGancBhILnSl(StringBuilder A_1, Action<StringBuilder, Object> A_2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedObject.NativeMethodInfoPtr_yBPNZoQHfsSXPAzZGancBhILnSl_Private_Virtual_Final_New_Void_StringBuilder_Action_2_StringBuilder_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E6F RID: 11887 RVA: 0x000E78E0 File Offset: 0x000E5AE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332106, XrefRangeEnd = 332109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OqwrzEkoFwfSZbXYvPlBdFfeBSB(Object A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedObject.NativeMethodInfoPtr_OqwrzEkoFwfSZbXYvPlBdFfeBSB_Private_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002E70 RID: 11888 RVA: 0x000E7924 File Offset: 0x000E5B24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void yXFgwxHoGfVMjddPOGaNCbAoRiGf(string A_1, Object A_2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(A_1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedObject.NativeMethodInfoPtr_yXFgwxHoGfVMjddPOGaNCbAoRiGf_Private_Virtual_Final_New_Void_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E71 RID: 11889 RVA: 0x000E7978 File Offset: 0x000E5B78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332109, XrefRangeEnd = 332113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator<SerializedObject.Field> System_Collections_Generic_IEnumerable_Rewired_Utils_Classes_Data_SerializedObject_Field__GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedObject.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Rewired_Utils_Classes_Data_SerializedObject_Field__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Field_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<SerializedObject.Field>>(intPtr3) : null;
		}

		// Token: 0x06002E72 RID: 11890 RVA: 0x000E79B8 File Offset: 0x000E5BB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332113, XrefRangeEnd = 332117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedObject.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06002E73 RID: 11891 RVA: 0x000E79F8 File Offset: 0x000E5BF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332117, XrefRangeEnd = 332127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool XQmfXzeOBltQMFMaZowhIixSicuJ<T>(Object A_0, out T A_1, NumberStyles A_2 = NumberStyles.Any, CultureInfo A_3 = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
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
				intPtr2 = ref A_1;
			}
			ptr2 = intPtr2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_3);
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(SerializedObject.MethodInfoStoreGeneric_XQmfXzeOBltQMFMaZowhIixSicuJ_Private_Static_Boolean_Object_byref_T_NumberStyles_CultureInfo_0<T>.Pointer, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(T).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				A_1 = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06002E74 RID: 11892 RVA: 0x000E7AA8 File Offset: 0x000E5CA8
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 334097, RefRangeEnd = 334115, XrefRangeStart = 332127, XrefRangeEnd = 334097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool XQmfXzeOBltQMFMaZowhIixSicuJ(Type A_0, Object A_1, out Object A_2, NumberStyles A_3 = NumberStyles.Any, CultureInfo A_4 = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_1);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_3;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_4);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SerializedObject.NativeMethodInfoPtr_XQmfXzeOBltQMFMaZowhIixSicuJ_Private_Static_Boolean_Type_Object_byref_Object_NumberStyles_CultureInfo_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			A_2 = ((intPtr4 == 0) ? null : new Object(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06002E75 RID: 11893 RVA: 0x000E7B40 File Offset: 0x000E5D40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 334242, RefRangeEnd = 334243, XrefRangeStart = 334115, XrefRangeEnd = 334242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool wiCpEoQDqhfPGaPLCVdwHhUxzjmB(Type A_0, SerializedObject A_1, out Object A_2, NumberStyles A_3 = NumberStyles.Any, CultureInfo A_4 = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_1);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_3;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_4);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SerializedObject.NativeMethodInfoPtr_wiCpEoQDqhfPGaPLCVdwHhUxzjmB_Private_Static_Boolean_Type_SerializedObject_byref_Object_NumberStyles_CultureInfo_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			A_2 = ((intPtr4 == 0) ? null : new Object(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06002E76 RID: 11894 RVA: 0x000E7BD8 File Offset: 0x000E5DD8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 334256, RefRangeEnd = 334262, XrefRangeStart = 334243, XrefRangeEnd = 334256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SerializedObject FromJson(Type type, string jsonString)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(jsonString);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedObject.NativeMethodInfoPtr_FromJson_Public_Static_SerializedObject_Type_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedObject>(intPtr3) : null;
		}

		// Token: 0x06002E77 RID: 11895 RVA: 0x000E7C30 File Offset: 0x000E5E30
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 334272, RefRangeEnd = 334278, XrefRangeStart = 334262, XrefRangeEnd = 334272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SerializedObject FromXml(Type type, string xmlString)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(xmlString);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedObject.NativeMethodInfoPtr_FromXml_Public_Static_SerializedObject_Type_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedObject>(intPtr3) : null;
		}

		// Token: 0x06002E78 RID: 11896 RVA: 0x000E7C88 File Offset: 0x000E5E88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334278, XrefRangeEnd = 334295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool YMgNUXMQRociSwYYiprrbkRuoWF(FieldInfo A_0)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedObject.NativeMethodInfoPtr_YMgNUXMQRociSwYYiprrbkRuoWF_Private_Static_Boolean_FieldInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002E79 RID: 11897 RVA: 0x000E7CCC File Offset: 0x000E5ECC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334295, XrefRangeEnd = 334309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string tzgeCLoobRplMnfXcAIhCfElUaw(FieldInfo A_0)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedObject.NativeMethodInfoPtr_tzgeCLoobRplMnfXcAIhCfElUaw_Private_Static_String_FieldInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002E7A RID: 11898 RVA: 0x000E7D08 File Offset: 0x000E5F08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334309, XrefRangeEnd = 334320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SHBEMVHHpBKLLAiktYymvTBFrQG(PropertyInfo A_0)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedObject.NativeMethodInfoPtr_SHBEMVHHpBKLLAiktYymvTBFrQG_Private_Static_Boolean_PropertyInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002E7B RID: 11899 RVA: 0x000E7D4C File Offset: 0x000E5F4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334320, XrefRangeEnd = 334334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string VhkNaormzRtGDCjQbFblKAxLgoyd(PropertyInfo A_0)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedObject.NativeMethodInfoPtr_VhkNaormzRtGDCjQbFblKAxLgoyd_Private_Static_String_PropertyInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002E7C RID: 11900 RVA: 0x000110B4 File Offset: 0x0000F2B4
		public SerializedObject(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000EAE RID: 3758
		// (get) Token: 0x06002E7D RID: 11901 RVA: 0x000E7D88 File Offset: 0x000E5F88
		// (set) Token: 0x06002E7E RID: 11902 RVA: 0x000110BD File Offset: 0x0000F2BD
		public unsafe IndexedDictionary<string, SerializedObject.OJtbadKtZgCsFAuYmKmIFGcrWza> FiIKcyXkfWzcUzCVQFMTpdMlBPw
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedObject.NativeFieldInfoPtr_FiIKcyXkfWzcUzCVQFMTpdMlBPw);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IndexedDictionary<string, SerializedObject.OJtbadKtZgCsFAuYmKmIFGcrWza>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedObject.NativeFieldInfoPtr_FiIKcyXkfWzcUzCVQFMTpdMlBPw), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EAF RID: 3759
		// (get) Token: 0x06002E7F RID: 11903 RVA: 0x000E7DB8 File Offset: 0x000E5FB8
		// (set) Token: 0x06002E80 RID: 11904 RVA: 0x000110DC File Offset: 0x0000F2DC
		public unsafe SerializedObject.XmlInfo JMsyokbFdjEdXVperCSdkbmARhag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedObject.NativeFieldInfoPtr_JMsyokbFdjEdXVperCSdkbmARhag);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializedObject.XmlInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedObject.NativeFieldInfoPtr_JMsyokbFdjEdXVperCSdkbmARhag), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EB0 RID: 3760
		// (get) Token: 0x06002E81 RID: 11905 RVA: 0x000E7DE8 File Offset: 0x000E5FE8
		// (set) Token: 0x06002E82 RID: 11906 RVA: 0x000110FB File Offset: 0x0000F2FB
		public unsafe Type HLmDmUQWoPLmPsyHTHuhoXXcGIu
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedObject.NativeFieldInfoPtr_HLmDmUQWoPLmPsyHTHuhoXXcGIu);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedObject.NativeFieldInfoPtr_HLmDmUQWoPLmPsyHTHuhoXXcGIu), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EB1 RID: 3761
		// (get) Token: 0x06002E83 RID: 11907 RVA: 0x000E7E18 File Offset: 0x000E6018
		// (set) Token: 0x06002E84 RID: 11908 RVA: 0x0001111A File Offset: 0x0000F31A
		public unsafe SerializedObject.ObjectType GikxJncSATqBihSQYheLeudpKBe
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedObject.NativeFieldInfoPtr_GikxJncSATqBihSQYheLeudpKBe);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedObject.NativeFieldInfoPtr_GikxJncSATqBihSQYheLeudpKBe)) = value;
			}
		}

		// Token: 0x17000EB2 RID: 3762
		// (get) Token: 0x06002E85 RID: 11909 RVA: 0x000E7E40 File Offset: 0x000E6040
		// (set) Token: 0x06002E86 RID: 11910 RVA: 0x00011135 File Offset: 0x0000F335
		public unsafe static Dictionary<Type, Dictionary<string, FieldInfo>> NMTVJtrJoYumHwXWPbrJysMwPVR
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SerializedObject.NativeFieldInfoPtr_NMTVJtrJoYumHwXWPbrJysMwPVR, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Type, Dictionary<string, FieldInfo>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SerializedObject.NativeFieldInfoPtr_NMTVJtrJoYumHwXWPbrJysMwPVR, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EB3 RID: 3763
		// (get) Token: 0x06002E87 RID: 11911 RVA: 0x000E7E68 File Offset: 0x000E6068
		// (set) Token: 0x06002E88 RID: 11912 RVA: 0x00011147 File Offset: 0x0000F347
		public unsafe static Dictionary<Type, Dictionary<string, PropertyInfo>> pAGfnheFMaBVdmJCJXDfGEBrDpI
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SerializedObject.NativeFieldInfoPtr_pAGfnheFMaBVdmJCJXDfGEBrDpI, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Type, Dictionary<string, PropertyInfo>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SerializedObject.NativeFieldInfoPtr_pAGfnheFMaBVdmJCJXDfGEBrDpI, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EB4 RID: 3764
		// (get) Token: 0x06002E89 RID: 11913 RVA: 0x000E7E90 File Offset: 0x000E6090
		// (set) Token: 0x06002E8A RID: 11914 RVA: 0x00011159 File Offset: 0x0000F359
		public unsafe static Func<FieldInfo, bool> YtejDiqaLAxxRnmscggDavQFcLz
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SerializedObject.NativeFieldInfoPtr_YtejDiqaLAxxRnmscggDavQFcLz, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<FieldInfo, bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SerializedObject.NativeFieldInfoPtr_YtejDiqaLAxxRnmscggDavQFcLz, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EB5 RID: 3765
		// (get) Token: 0x06002E8B RID: 11915 RVA: 0x000E7EB8 File Offset: 0x000E60B8
		// (set) Token: 0x06002E8C RID: 11916 RVA: 0x0001116B File Offset: 0x0000F36B
		public unsafe static Func<FieldInfo, string> ikzytTXFFDqNPkVCCmeRclgjukz
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SerializedObject.NativeFieldInfoPtr_ikzytTXFFDqNPkVCCmeRclgjukz, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<FieldInfo, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SerializedObject.NativeFieldInfoPtr_ikzytTXFFDqNPkVCCmeRclgjukz, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EB6 RID: 3766
		// (get) Token: 0x06002E8D RID: 11917 RVA: 0x000E7EE0 File Offset: 0x000E60E0
		// (set) Token: 0x06002E8E RID: 11918 RVA: 0x0001117D File Offset: 0x0000F37D
		public unsafe static Func<PropertyInfo, bool> LSUfbRdNVkGYkofhpojegAuXaApi
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SerializedObject.NativeFieldInfoPtr_LSUfbRdNVkGYkofhpojegAuXaApi, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PropertyInfo, bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SerializedObject.NativeFieldInfoPtr_LSUfbRdNVkGYkofhpojegAuXaApi, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EB7 RID: 3767
		// (get) Token: 0x06002E8F RID: 11919 RVA: 0x000E7F08 File Offset: 0x000E6108
		// (set) Token: 0x06002E90 RID: 11920 RVA: 0x0001118F File Offset: 0x0000F38F
		public unsafe static Func<PropertyInfo, string> xKHIFFzxxSCqQovYtTvauauWzuS
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SerializedObject.NativeFieldInfoPtr_xKHIFFzxxSCqQovYtTvauauWzuS, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PropertyInfo, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SerializedObject.NativeFieldInfoPtr_xKHIFFzxxSCqQovYtTvauauWzuS, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002735 RID: 10037
		private static readonly IntPtr NativeFieldInfoPtr_FiIKcyXkfWzcUzCVQFMTpdMlBPw;

		// Token: 0x04002736 RID: 10038
		private static readonly IntPtr NativeFieldInfoPtr_JMsyokbFdjEdXVperCSdkbmARhag;

		// Token: 0x04002737 RID: 10039
		private static readonly IntPtr NativeFieldInfoPtr_HLmDmUQWoPLmPsyHTHuhoXXcGIu;

		// Token: 0x04002738 RID: 10040
		private static readonly IntPtr NativeFieldInfoPtr_GikxJncSATqBihSQYheLeudpKBe;

		// Token: 0x04002739 RID: 10041
		private static readonly IntPtr NativeFieldInfoPtr_NMTVJtrJoYumHwXWPbrJysMwPVR;

		// Token: 0x0400273A RID: 10042
		private static readonly IntPtr NativeFieldInfoPtr_pAGfnheFMaBVdmJCJXDfGEBrDpI;

		// Token: 0x0400273B RID: 10043
		private static readonly IntPtr NativeFieldInfoPtr_YtejDiqaLAxxRnmscggDavQFcLz;

		// Token: 0x0400273C RID: 10044
		private static readonly IntPtr NativeFieldInfoPtr_ikzytTXFFDqNPkVCCmeRclgjukz;

		// Token: 0x0400273D RID: 10045
		private static readonly IntPtr NativeFieldInfoPtr_LSUfbRdNVkGYkofhpojegAuXaApi;

		// Token: 0x0400273E RID: 10046
		private static readonly IntPtr NativeFieldInfoPtr_xKHIFFzxxSCqQovYtTvauauWzuS;

		// Token: 0x0400273F RID: 10047
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04002740 RID: 10048
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Int32_0;

		// Token: 0x04002741 RID: 10049
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_ObjectType_0;

		// Token: 0x04002742 RID: 10050
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_ObjectType_Int32_0;

		// Token: 0x04002743 RID: 10051
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_IDictionary_2_String_Object_ObjectType_0;

		// Token: 0x04002744 RID: 10052
		private static readonly IntPtr NativeMethodInfoPtr_get_allowDuplicateKeys_Private_get_Boolean_0;

		// Token: 0x04002745 RID: 10053
		private static readonly IntPtr NativeMethodInfoPtr_get_objectType_Public_get_ObjectType_0;

		// Token: 0x04002746 RID: 10054
		private static readonly IntPtr NativeMethodInfoPtr_set_objectType_Public_set_Void_ObjectType_0;

		// Token: 0x04002747 RID: 10055
		private static readonly IntPtr NativeMethodInfoPtr_get_type_Public_get_Type_0;

		// Token: 0x04002748 RID: 10056
		private static readonly IntPtr NativeMethodInfoPtr_get_xmlInfo_Public_get_XmlInfo_0;

		// Token: 0x04002749 RID: 10057
		private static readonly IntPtr NativeMethodInfoPtr_set_xmlInfo_Public_set_Void_XmlInfo_0;

		// Token: 0x0400274A RID: 10058
		private static readonly IntPtr NativeMethodInfoPtr_get_count_Public_get_Int32_0;

		// Token: 0x0400274B RID: 10059
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Field_Int32_0;

		// Token: 0x0400274C RID: 10060
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_String_T_FieldOptions_0;

		// Token: 0x0400274D RID: 10061
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_Type_String_Object_FieldOptions_0;

		// Token: 0x0400274E RID: 10062
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_String_Object_0;

		// Token: 0x0400274F RID: 10063
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Boolean_String_0;

		// Token: 0x04002750 RID: 10064
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_String_0;

		// Token: 0x04002751 RID: 10065
		private static readonly IntPtr NativeMethodInfoPtr_GetDataType_Public_Type_String_0;

		// Token: 0x04002752 RID: 10066
		private static readonly IntPtr NativeMethodInfoPtr_TryGetOriginalValue_Public_Boolean_String_byref_Object_0;

		// Token: 0x04002753 RID: 10067
		private static readonly IntPtr NativeMethodInfoPtr_GetEntry_Public_Field_String_0;

		// Token: 0x04002754 RID: 10068
		private static readonly IntPtr NativeMethodInfoPtr_GetOriginalValue_Public_Object_String_0;

		// Token: 0x04002755 RID: 10069
		private static readonly IntPtr NativeMethodInfoPtr_GetOriginalValue_Public_Object_Int32_0;

		// Token: 0x04002756 RID: 10070
		private static readonly IntPtr NativeMethodInfoPtr_GetOriginalValue_Public_T_String_0;

		// Token: 0x04002757 RID: 10071
		private static readonly IntPtr NativeMethodInfoPtr_GetOriginalValue_Public_T_Int32_0;

		// Token: 0x04002758 RID: 10072
		private static readonly IntPtr NativeMethodInfoPtr_TryGetDeserializedValue_Public_Boolean_String_byref_T_0;

		// Token: 0x04002759 RID: 10073
		private static readonly IntPtr NativeMethodInfoPtr_TryGetDeserializedValue_Public_Boolean_Int32_byref_T_0;

		// Token: 0x0400275A RID: 10074
		private static readonly IntPtr NativeMethodInfoPtr_TryGetDeserializedValueByRef_Public_Boolean_String_byref_T_0;

		// Token: 0x0400275B RID: 10075
		private static readonly IntPtr NativeMethodInfoPtr_TryGetDeserializedValueByRef_Public_Boolean_Int32_byref_T_0;

		// Token: 0x0400275C RID: 10076
		private static readonly IntPtr NativeMethodInfoPtr_ToXmlString_Public_String_Boolean_0;

		// Token: 0x0400275D RID: 10077
		private static readonly IntPtr NativeMethodInfoPtr_ToJsonString_Public_String_0;

		// Token: 0x0400275E RID: 10078
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400275F RID: 10079
		private static readonly IntPtr NativeMethodInfoPtr_mUyZVRMMkRvKKYwVqhvyPdbbQmp_Private_Void_XmlWriter_0;

		// Token: 0x04002760 RID: 10080
		private static readonly IntPtr NativeMethodInfoPtr_GiKkONyoOShEkeVMhBQRCYIdsIdF_Private_Void_XmlWriter_0;

		// Token: 0x04002761 RID: 10081
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_Utils_Interfaces_IExportToXml_get_writesOwnElementTag_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04002762 RID: 10082
		private static readonly IntPtr NativeMethodInfoPtr_yqFnyTPlTcsxOpNfczpQbhAGOAc_Private_Virtual_Final_New_Void_XmlWriter_0;

		// Token: 0x04002763 RID: 10083
		private static readonly IntPtr NativeMethodInfoPtr_yBPNZoQHfsSXPAzZGancBhILnSl_Private_Virtual_Final_New_Void_StringBuilder_Action_2_StringBuilder_Object_0;

		// Token: 0x04002764 RID: 10084
		private static readonly IntPtr NativeMethodInfoPtr_OqwrzEkoFwfSZbXYvPlBdFfeBSB_Private_Virtual_Final_New_Void_Object_0;

		// Token: 0x04002765 RID: 10085
		private static readonly IntPtr NativeMethodInfoPtr_yXFgwxHoGfVMjddPOGaNCbAoRiGf_Private_Virtual_Final_New_Void_String_Object_0;

		// Token: 0x04002766 RID: 10086
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Rewired_Utils_Classes_Data_SerializedObject_Field__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Field_0;

		// Token: 0x04002767 RID: 10087
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x04002768 RID: 10088
		private static readonly IntPtr NativeMethodInfoPtr_XQmfXzeOBltQMFMaZowhIixSicuJ_Private_Static_Boolean_Object_byref_T_NumberStyles_CultureInfo_0;

		// Token: 0x04002769 RID: 10089
		private static readonly IntPtr NativeMethodInfoPtr_XQmfXzeOBltQMFMaZowhIixSicuJ_Private_Static_Boolean_Type_Object_byref_Object_NumberStyles_CultureInfo_0;

		// Token: 0x0400276A RID: 10090
		private static readonly IntPtr NativeMethodInfoPtr_wiCpEoQDqhfPGaPLCVdwHhUxzjmB_Private_Static_Boolean_Type_SerializedObject_byref_Object_NumberStyles_CultureInfo_0;

		// Token: 0x0400276B RID: 10091
		private static readonly IntPtr NativeMethodInfoPtr_FromJson_Public_Static_SerializedObject_Type_String_0;

		// Token: 0x0400276C RID: 10092
		private static readonly IntPtr NativeMethodInfoPtr_FromXml_Public_Static_SerializedObject_Type_String_0;

		// Token: 0x0400276D RID: 10093
		private static readonly IntPtr NativeMethodInfoPtr_YMgNUXMQRociSwYYiprrbkRuoWF_Private_Static_Boolean_FieldInfo_0;

		// Token: 0x0400276E RID: 10094
		private static readonly IntPtr NativeMethodInfoPtr_tzgeCLoobRplMnfXcAIhCfElUaw_Private_Static_String_FieldInfo_0;

		// Token: 0x0400276F RID: 10095
		private static readonly IntPtr NativeMethodInfoPtr_SHBEMVHHpBKLLAiktYymvTBFrQG_Private_Static_Boolean_PropertyInfo_0;

		// Token: 0x04002770 RID: 10096
		private static readonly IntPtr NativeMethodInfoPtr_VhkNaormzRtGDCjQbFblKAxLgoyd_Private_Static_String_PropertyInfo_0;

		// Token: 0x020003D9 RID: 985
		[OriginalName("Rewired_Core.dll", "", "ObjectType")]
		public enum ObjectType
		{
			// Token: 0x040042D8 RID: 17112
			Object,
			// Token: 0x040042D9 RID: 17113
			List
		}

		// Token: 0x020003DA RID: 986
		[OriginalName("Rewired_Core.dll", "", "FieldOptions")]
		[Flags]
		public enum FieldOptions
		{
			// Token: 0x040042DB RID: 17115
			None = 0,
			// Token: 0x040042DC RID: 17116
			ExculdeFromXml = 1
		}

		// Token: 0x020003DB RID: 987
		public sealed class OJtbadKtZgCsFAuYmKmIFGcrWza : ValueType
		{
			// Token: 0x06005040 RID: 20544 RVA: 0x0016CF38 File Offset: 0x0016B138
			// Note: this type is marked as 'beforefieldinit'.
			static OJtbadKtZgCsFAuYmKmIFGcrWza()
			{
				Il2CppClassPointerStore<SerializedObject.OJtbadKtZgCsFAuYmKmIFGcrWza>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SerializedObject>.NativeClassPtr, "OJtbadKtZgCsFAuYmKmIFGcrWza");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedObject.OJtbadKtZgCsFAuYmKmIFGcrWza>.NativeClassPtr);
				SerializedObject.OJtbadKtZgCsFAuYmKmIFGcrWza.NativeFieldInfoPtr_crFuiBooxxTCRjzsdbdXzBFLXPj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedObject.OJtbadKtZgCsFAuYmKmIFGcrWza>.NativeClassPtr, "crFuiBooxxTCRjzsdbdXzBFLXPj");
				SerializedObject.OJtbadKtZgCsFAuYmKmIFGcrWza.NativeFieldInfoPtr_wvNaDPcNUyHJKWogdKCZCqbNISpy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedObject.OJtbadKtZgCsFAuYmKmIFGcrWza>.NativeClassPtr, "wvNaDPcNUyHJKWogdKCZCqbNISpy");
				SerializedObject.OJtbadKtZgCsFAuYmKmIFGcrWza.NativeFieldInfoPtr_oMOOeiZtkdpUPluQucHpRGIZeQc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedObject.OJtbadKtZgCsFAuYmKmIFGcrWza>.NativeClassPtr, "oMOOeiZtkdpUPluQucHpRGIZeQc");
				SerializedObject.OJtbadKtZgCsFAuYmKmIFGcrWza.NativeMethodInfoPtr__ctor_Public_Void_Type_Object_FieldOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedObject.OJtbadKtZgCsFAuYmKmIFGcrWza>.NativeClassPtr, 100675292);
				SerializedObject.OJtbadKtZgCsFAuYmKmIFGcrWza.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedObject.OJtbadKtZgCsFAuYmKmIFGcrWza>.NativeClassPtr, 100675293);
			}

			// Token: 0x06005041 RID: 20545 RVA: 0x0016CFC8 File Offset: 0x0016B1C8
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 138962, RefRangeEnd = 138965, XrefRangeStart = 138962, XrefRangeEnd = 138965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OJtbadKtZgCsFAuYmKmIFGcrWza(Type type, Object value, SerializedObject.FieldOptions options)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedObject.OJtbadKtZgCsFAuYmKmIFGcrWza>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedObject.OJtbadKtZgCsFAuYmKmIFGcrWza.NativeMethodInfoPtr__ctor_Public_Void_Type_Object_FieldOptions_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005042 RID: 20546 RVA: 0x0016D038 File Offset: 0x0016B238
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 331392, RefRangeEnd = 331393, XrefRangeStart = 331347, XrefRangeEnd = 331392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string ToString()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedObject.OJtbadKtZgCsFAuYmKmIFGcrWza.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06005043 RID: 20547 RVA: 0x0001D2FA File Offset: 0x0001B4FA
			public OJtbadKtZgCsFAuYmKmIFGcrWza(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06005044 RID: 20548 RVA: 0x0001D303 File Offset: 0x0001B503
			public OJtbadKtZgCsFAuYmKmIFGcrWza()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedObject.OJtbadKtZgCsFAuYmKmIFGcrWza>.NativeClassPtr))
			{
			}

			// Token: 0x170018E6 RID: 6374
			// (get) Token: 0x06005045 RID: 20549 RVA: 0x0016D074 File Offset: 0x0016B274
			// (set) Token: 0x06005046 RID: 20550 RVA: 0x0001D315 File Offset: 0x0001B515
			public unsafe Type crFuiBooxxTCRjzsdbdXzBFLXPj
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedObject.OJtbadKtZgCsFAuYmKmIFGcrWza.NativeFieldInfoPtr_crFuiBooxxTCRjzsdbdXzBFLXPj);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedObject.OJtbadKtZgCsFAuYmKmIFGcrWza.NativeFieldInfoPtr_crFuiBooxxTCRjzsdbdXzBFLXPj), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170018E7 RID: 6375
			// (get) Token: 0x06005047 RID: 20551 RVA: 0x0016D0A4 File Offset: 0x0016B2A4
			// (set) Token: 0x06005048 RID: 20552 RVA: 0x0001D334 File Offset: 0x0001B534
			public unsafe Object wvNaDPcNUyHJKWogdKCZCqbNISpy
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedObject.OJtbadKtZgCsFAuYmKmIFGcrWza.NativeFieldInfoPtr_wvNaDPcNUyHJKWogdKCZCqbNISpy);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedObject.OJtbadKtZgCsFAuYmKmIFGcrWza.NativeFieldInfoPtr_wvNaDPcNUyHJKWogdKCZCqbNISpy), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170018E8 RID: 6376
			// (get) Token: 0x06005049 RID: 20553 RVA: 0x0016D0D4 File Offset: 0x0016B2D4
			// (set) Token: 0x0600504A RID: 20554 RVA: 0x0001D353 File Offset: 0x0001B553
			public unsafe SerializedObject.FieldOptions oMOOeiZtkdpUPluQucHpRGIZeQc
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedObject.OJtbadKtZgCsFAuYmKmIFGcrWza.NativeFieldInfoPtr_oMOOeiZtkdpUPluQucHpRGIZeQc);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedObject.OJtbadKtZgCsFAuYmKmIFGcrWza.NativeFieldInfoPtr_oMOOeiZtkdpUPluQucHpRGIZeQc)) = value;
				}
			}

			// Token: 0x040042DD RID: 17117
			private static readonly IntPtr NativeFieldInfoPtr_crFuiBooxxTCRjzsdbdXzBFLXPj;

			// Token: 0x040042DE RID: 17118
			private static readonly IntPtr NativeFieldInfoPtr_wvNaDPcNUyHJKWogdKCZCqbNISpy;

			// Token: 0x040042DF RID: 17119
			private static readonly IntPtr NativeFieldInfoPtr_oMOOeiZtkdpUPluQucHpRGIZeQc;

			// Token: 0x040042E0 RID: 17120
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_Object_FieldOptions_0;

			// Token: 0x040042E1 RID: 17121
			private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
		}

		// Token: 0x020003DC RID: 988
		public sealed class Field : ValueType
		{
			// Token: 0x0600504B RID: 20555 RVA: 0x0016D0FC File Offset: 0x0016B2FC
			// Note: this type is marked as 'beforefieldinit'.
			static Field()
			{
				Il2CppClassPointerStore<SerializedObject.Field>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SerializedObject>.NativeClassPtr, "Field");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedObject.Field>.NativeClassPtr);
				SerializedObject.Field.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedObject.Field>.NativeClassPtr, "name");
				SerializedObject.Field.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedObject.Field>.NativeClassPtr, "value");
				SerializedObject.Field.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedObject.Field>.NativeClassPtr, "type");
				SerializedObject.Field.NativeFieldInfoPtr_options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedObject.Field>.NativeClassPtr, "options");
				SerializedObject.Field.NativeMethodInfoPtr__ctor_Public_Void_String_Object_Type_FieldOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedObject.Field>.NativeClassPtr, 100675294);
				SerializedObject.Field.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedObject.Field>.NativeClassPtr, 100675295);
			}

			// Token: 0x0600504C RID: 20556 RVA: 0x0016D1A0 File Offset: 0x0016B3A0
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 331393, RefRangeEnd = 331397, XrefRangeStart = 331393, XrefRangeEnd = 331393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Field(string name, Object value, Type type, SerializedObject.FieldOptions options)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedObject.Field>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedObject.Field.NativeMethodInfoPtr__ctor_Public_Void_String_Object_Type_FieldOptions_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600504D RID: 20557 RVA: 0x0016D224 File Offset: 0x0016B424
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331397, XrefRangeEnd = 331445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string ToString()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedObject.Field.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600504E RID: 20558 RVA: 0x0001D36E File Offset: 0x0001B56E
			public Field(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600504F RID: 20559 RVA: 0x0001D377 File Offset: 0x0001B577
			public Field()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedObject.Field>.NativeClassPtr))
			{
			}

			// Token: 0x170018E9 RID: 6377
			// (get) Token: 0x06005050 RID: 20560 RVA: 0x0016D260 File Offset: 0x0016B460
			// (set) Token: 0x06005051 RID: 20561 RVA: 0x0001D389 File Offset: 0x0001B589
			public unsafe string name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedObject.Field.NativeFieldInfoPtr_name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedObject.Field.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170018EA RID: 6378
			// (get) Token: 0x06005052 RID: 20562 RVA: 0x0016D288 File Offset: 0x0016B488
			// (set) Token: 0x06005053 RID: 20563 RVA: 0x0001D3A8 File Offset: 0x0001B5A8
			public unsafe Object value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedObject.Field.NativeFieldInfoPtr_value);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedObject.Field.NativeFieldInfoPtr_value), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170018EB RID: 6379
			// (get) Token: 0x06005054 RID: 20564 RVA: 0x0016D2B8 File Offset: 0x0016B4B8
			// (set) Token: 0x06005055 RID: 20565 RVA: 0x0001D3C7 File Offset: 0x0001B5C7
			public unsafe Type type
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedObject.Field.NativeFieldInfoPtr_type);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedObject.Field.NativeFieldInfoPtr_type), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170018EC RID: 6380
			// (get) Token: 0x06005056 RID: 20566 RVA: 0x0016D2E8 File Offset: 0x0016B4E8
			// (set) Token: 0x06005057 RID: 20567 RVA: 0x0001D3E6 File Offset: 0x0001B5E6
			public unsafe SerializedObject.FieldOptions options
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedObject.Field.NativeFieldInfoPtr_options);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedObject.Field.NativeFieldInfoPtr_options)) = value;
				}
			}

			// Token: 0x040042E2 RID: 17122
			private static readonly IntPtr NativeFieldInfoPtr_name;

			// Token: 0x040042E3 RID: 17123
			private static readonly IntPtr NativeFieldInfoPtr_value;

			// Token: 0x040042E4 RID: 17124
			private static readonly IntPtr NativeFieldInfoPtr_type;

			// Token: 0x040042E5 RID: 17125
			private static readonly IntPtr NativeFieldInfoPtr_options;

			// Token: 0x040042E6 RID: 17126
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Object_Type_FieldOptions_0;

			// Token: 0x040042E7 RID: 17127
			private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
		}

		// Token: 0x020003DD RID: 989
		public class XmlInfo : Object
		{
			// Token: 0x06005058 RID: 20568 RVA: 0x0016D310 File Offset: 0x0016B510
			// Note: this type is marked as 'beforefieldinit'.
			static XmlInfo()
			{
				Il2CppClassPointerStore<SerializedObject.XmlInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SerializedObject>.NativeClassPtr, "XmlInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedObject.XmlInfo>.NativeClassPtr);
				SerializedObject.XmlInfo.NativeFieldInfoPtr_lVotueCPXaNmItggpKWuMnxqSjF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedObject.XmlInfo>.NativeClassPtr, "lVotueCPXaNmItggpKWuMnxqSjF");
				SerializedObject.XmlInfo.NativeMethodInfoPtr_get_attributes_Public_get_List_1_UFIbcKLLJsVhDdXRvboBwzsjJIH_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedObject.XmlInfo>.NativeClassPtr, 100675296);
				SerializedObject.XmlInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedObject.XmlInfo>.NativeClassPtr, 100675297);
				SerializedObject.XmlInfo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedObject.XmlInfo>.NativeClassPtr, 100675298);
			}

			// Token: 0x170018EE RID: 6382
			// (get) Token: 0x06005059 RID: 20569 RVA: 0x0016D38C File Offset: 0x0016B58C
			public unsafe List<SerializedObject.XmlInfo.UFIbcKLLJsVhDdXRvboBwzsjJIH> attributes
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 331470, RefRangeEnd = 331494, XrefRangeStart = 331464, XrefRangeEnd = 331470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedObject.XmlInfo.NativeMethodInfoPtr_get_attributes_Public_get_List_1_UFIbcKLLJsVhDdXRvboBwzsjJIH_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<SerializedObject.XmlInfo.UFIbcKLLJsVhDdXRvboBwzsjJIH>>(intPtr3) : null;
				}
			}

			// Token: 0x0600505A RID: 20570 RVA: 0x0016D3CC File Offset: 0x0016B5CC
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe XmlInfo()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedObject.XmlInfo>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedObject.XmlInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600505B RID: 20571 RVA: 0x0016D408 File Offset: 0x0016B608
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331494, XrefRangeEnd = 331502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string ToString()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedObject.XmlInfo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600505C RID: 20572 RVA: 0x0001D401 File Offset: 0x0001B601
			public XmlInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170018ED RID: 6381
			// (get) Token: 0x0600505D RID: 20573 RVA: 0x0016D44C File Offset: 0x0016B64C
			// (set) Token: 0x0600505E RID: 20574 RVA: 0x0001D40A File Offset: 0x0001B60A
			public unsafe List<SerializedObject.XmlInfo.UFIbcKLLJsVhDdXRvboBwzsjJIH> lVotueCPXaNmItggpKWuMnxqSjF
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedObject.XmlInfo.NativeFieldInfoPtr_lVotueCPXaNmItggpKWuMnxqSjF);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SerializedObject.XmlInfo.UFIbcKLLJsVhDdXRvboBwzsjJIH>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedObject.XmlInfo.NativeFieldInfoPtr_lVotueCPXaNmItggpKWuMnxqSjF), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040042E8 RID: 17128
			private static readonly IntPtr NativeFieldInfoPtr_lVotueCPXaNmItggpKWuMnxqSjF;

			// Token: 0x040042E9 RID: 17129
			private static readonly IntPtr NativeMethodInfoPtr_get_attributes_Public_get_List_1_UFIbcKLLJsVhDdXRvboBwzsjJIH_0;

			// Token: 0x040042EA RID: 17130
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040042EB RID: 17131
			private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

			// Token: 0x020005AA RID: 1450
			public class UFIbcKLLJsVhDdXRvboBwzsjJIH : Object
			{
				// Token: 0x060060EA RID: 24810 RVA: 0x00023C0C File Offset: 0x00021E0C
				// Note: this type is marked as 'beforefieldinit'.
				static UFIbcKLLJsVhDdXRvboBwzsjJIH()
				{
					Il2CppClassPointerStore<SerializedObject.XmlInfo.UFIbcKLLJsVhDdXRvboBwzsjJIH>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SerializedObject.XmlInfo>.NativeClassPtr, "UFIbcKLLJsVhDdXRvboBwzsjJIH");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedObject.XmlInfo.UFIbcKLLJsVhDdXRvboBwzsjJIH>.NativeClassPtr);
					SerializedObject.XmlInfo.UFIbcKLLJsVhDdXRvboBwzsjJIH.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedObject.XmlInfo.UFIbcKLLJsVhDdXRvboBwzsjJIH>.NativeClassPtr, 100675299);
				}

				// Token: 0x060060EB RID: 24811 RVA: 0x001AF164 File Offset: 0x001AD364
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe UFIbcKLLJsVhDdXRvboBwzsjJIH()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedObject.XmlInfo.UFIbcKLLJsVhDdXRvboBwzsjJIH>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedObject.XmlInfo.UFIbcKLLJsVhDdXRvboBwzsjJIH.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060060EC RID: 24812 RVA: 0x00023C40 File Offset: 0x00021E40
				public UFIbcKLLJsVhDdXRvboBwzsjJIH(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04004F73 RID: 20339
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
			}

			// Token: 0x020005AB RID: 1451
			public class bHnfviCFkJmVllLPxCjZCZOFqcsT : SerializedObject.XmlInfo.UFIbcKLLJsVhDdXRvboBwzsjJIH
			{
				// Token: 0x060060ED RID: 24813 RVA: 0x001AF1A0 File Offset: 0x001AD3A0
				// Note: this type is marked as 'beforefieldinit'.
				static bHnfviCFkJmVllLPxCjZCZOFqcsT()
				{
					Il2CppClassPointerStore<SerializedObject.XmlInfo.bHnfviCFkJmVllLPxCjZCZOFqcsT>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SerializedObject.XmlInfo>.NativeClassPtr, "bHnfviCFkJmVllLPxCjZCZOFqcsT");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedObject.XmlInfo.bHnfviCFkJmVllLPxCjZCZOFqcsT>.NativeClassPtr);
					SerializedObject.XmlInfo.bHnfviCFkJmVllLPxCjZCZOFqcsT.NativeFieldInfoPtr_yGzmiWnUoBucSngOEtaSYuzhjjl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedObject.XmlInfo.bHnfviCFkJmVllLPxCjZCZOFqcsT>.NativeClassPtr, "yGzmiWnUoBucSngOEtaSYuzhjjl");
					SerializedObject.XmlInfo.bHnfviCFkJmVllLPxCjZCZOFqcsT.NativeFieldInfoPtr_MXQFrdbsQRykDavPeacCkiTFzjN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedObject.XmlInfo.bHnfviCFkJmVllLPxCjZCZOFqcsT>.NativeClassPtr, "MXQFrdbsQRykDavPeacCkiTFzjN");
					SerializedObject.XmlInfo.bHnfviCFkJmVllLPxCjZCZOFqcsT.NativeFieldInfoPtr_XsYLJsyUOjKcXsIJXflfPDHbjkK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedObject.XmlInfo.bHnfviCFkJmVllLPxCjZCZOFqcsT>.NativeClassPtr, "XsYLJsyUOjKcXsIJXflfPDHbjkK");
					SerializedObject.XmlInfo.bHnfviCFkJmVllLPxCjZCZOFqcsT.NativeFieldInfoPtr_wvNaDPcNUyHJKWogdKCZCqbNISpy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedObject.XmlInfo.bHnfviCFkJmVllLPxCjZCZOFqcsT>.NativeClassPtr, "wvNaDPcNUyHJKWogdKCZCqbNISpy");
					SerializedObject.XmlInfo.bHnfviCFkJmVllLPxCjZCZOFqcsT.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedObject.XmlInfo.bHnfviCFkJmVllLPxCjZCZOFqcsT>.NativeClassPtr, 100675300);
					SerializedObject.XmlInfo.bHnfviCFkJmVllLPxCjZCZOFqcsT.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedObject.XmlInfo.bHnfviCFkJmVllLPxCjZCZOFqcsT>.NativeClassPtr, 100675301);
				}

				// Token: 0x060060EE RID: 24814 RVA: 0x001AF244 File Offset: 0x001AD444
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331445, XrefRangeEnd = 331464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe override string ToString()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedObject.XmlInfo.bHnfviCFkJmVllLPxCjZCZOFqcsT.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}

				// Token: 0x060060EF RID: 24815 RVA: 0x001AF288 File Offset: 0x001AD488
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bHnfviCFkJmVllLPxCjZCZOFqcsT()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedObject.XmlInfo.bHnfviCFkJmVllLPxCjZCZOFqcsT>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedObject.XmlInfo.bHnfviCFkJmVllLPxCjZCZOFqcsT.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060060F0 RID: 24816 RVA: 0x00023C49 File Offset: 0x00021E49
				public bHnfviCFkJmVllLPxCjZCZOFqcsT(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17001D58 RID: 7512
				// (get) Token: 0x060060F1 RID: 24817 RVA: 0x001AF2C4 File Offset: 0x001AD4C4
				// (set) Token: 0x060060F2 RID: 24818 RVA: 0x00023C52 File Offset: 0x00021E52
				public unsafe string yGzmiWnUoBucSngOEtaSYuzhjjl
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedObject.XmlInfo.bHnfviCFkJmVllLPxCjZCZOFqcsT.NativeFieldInfoPtr_yGzmiWnUoBucSngOEtaSYuzhjjl);
						return IL2CPP.Il2CppStringToManaged(*intPtr);
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedObject.XmlInfo.bHnfviCFkJmVllLPxCjZCZOFqcsT.NativeFieldInfoPtr_yGzmiWnUoBucSngOEtaSYuzhjjl), IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x17001D59 RID: 7513
				// (get) Token: 0x060060F3 RID: 24819 RVA: 0x001AF2EC File Offset: 0x001AD4EC
				// (set) Token: 0x060060F4 RID: 24820 RVA: 0x00023C71 File Offset: 0x00021E71
				public unsafe string MXQFrdbsQRykDavPeacCkiTFzjN
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedObject.XmlInfo.bHnfviCFkJmVllLPxCjZCZOFqcsT.NativeFieldInfoPtr_MXQFrdbsQRykDavPeacCkiTFzjN);
						return IL2CPP.Il2CppStringToManaged(*intPtr);
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedObject.XmlInfo.bHnfviCFkJmVllLPxCjZCZOFqcsT.NativeFieldInfoPtr_MXQFrdbsQRykDavPeacCkiTFzjN), IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x17001D5A RID: 7514
				// (get) Token: 0x060060F5 RID: 24821 RVA: 0x001AF314 File Offset: 0x001AD514
				// (set) Token: 0x060060F6 RID: 24822 RVA: 0x00023C90 File Offset: 0x00021E90
				public unsafe string XsYLJsyUOjKcXsIJXflfPDHbjkK
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedObject.XmlInfo.bHnfviCFkJmVllLPxCjZCZOFqcsT.NativeFieldInfoPtr_XsYLJsyUOjKcXsIJXflfPDHbjkK);
						return IL2CPP.Il2CppStringToManaged(*intPtr);
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedObject.XmlInfo.bHnfviCFkJmVllLPxCjZCZOFqcsT.NativeFieldInfoPtr_XsYLJsyUOjKcXsIJXflfPDHbjkK), IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x17001D5B RID: 7515
				// (get) Token: 0x060060F7 RID: 24823 RVA: 0x001AF33C File Offset: 0x001AD53C
				// (set) Token: 0x060060F8 RID: 24824 RVA: 0x00023CAF File Offset: 0x00021EAF
				public unsafe string wvNaDPcNUyHJKWogdKCZCqbNISpy
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedObject.XmlInfo.bHnfviCFkJmVllLPxCjZCZOFqcsT.NativeFieldInfoPtr_wvNaDPcNUyHJKWogdKCZCqbNISpy);
						return IL2CPP.Il2CppStringToManaged(*intPtr);
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedObject.XmlInfo.bHnfviCFkJmVllLPxCjZCZOFqcsT.NativeFieldInfoPtr_wvNaDPcNUyHJKWogdKCZCqbNISpy), IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x04004F74 RID: 20340
				private static readonly IntPtr NativeFieldInfoPtr_yGzmiWnUoBucSngOEtaSYuzhjjl;

				// Token: 0x04004F75 RID: 20341
				private static readonly IntPtr NativeFieldInfoPtr_MXQFrdbsQRykDavPeacCkiTFzjN;

				// Token: 0x04004F76 RID: 20342
				private static readonly IntPtr NativeFieldInfoPtr_XsYLJsyUOjKcXsIJXflfPDHbjkK;

				// Token: 0x04004F77 RID: 20343
				private static readonly IntPtr NativeFieldInfoPtr_wvNaDPcNUyHJKWogdKCZCqbNISpy;

				// Token: 0x04004F78 RID: 20344
				private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

				// Token: 0x04004F79 RID: 20345
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
			}
		}

		// Token: 0x020003DE RID: 990
		public sealed class Enumerator : ValueType
		{
			// Token: 0x0600505F RID: 20575 RVA: 0x0016D47C File Offset: 0x0016B67C
			// Note: this type is marked as 'beforefieldinit'.
			static Enumerator()
			{
				Il2CppClassPointerStore<SerializedObject.Enumerator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SerializedObject>.NativeClassPtr, "Enumerator");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedObject.Enumerator>.NativeClassPtr);
				SerializedObject.Enumerator.NativeFieldInfoPtr_ePPbmHJRexSdoExlntQpBSQjqgIV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedObject.Enumerator>.NativeClassPtr, "ePPbmHJRexSdoExlntQpBSQjqgIV");
				SerializedObject.Enumerator.NativeFieldInfoPtr_EDWjCkozGqmyQyquicPQVDMTCVq = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedObject.Enumerator>.NativeClassPtr, "EDWjCkozGqmyQyquicPQVDMTCVq");
				SerializedObject.Enumerator.NativeFieldInfoPtr_hVswKwPIRbWLEXwXjLTIZKKEsaw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedObject.Enumerator>.NativeClassPtr, "hVswKwPIRbWLEXwXjLTIZKKEsaw");
				SerializedObject.Enumerator.NativeMethodInfoPtr__ctor_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedObject.Enumerator>.NativeClassPtr, 100675302);
				SerializedObject.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedObject.Enumerator>.NativeClassPtr, 100675303);
				SerializedObject.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Field_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedObject.Enumerator>.NativeClassPtr, 100675304);
				SerializedObject.Enumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedObject.Enumerator>.NativeClassPtr, 100675305);
				SerializedObject.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedObject.Enumerator>.NativeClassPtr, 100675306);
				SerializedObject.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedObject.Enumerator>.NativeClassPtr, 100675307);
			}

			// Token: 0x06005060 RID: 20576 RVA: 0x0016D55C File Offset: 0x0016B75C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 331506, RefRangeEnd = 331508, XrefRangeStart = 331502, XrefRangeEnd = 331506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Enumerator(Object dictionary)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedObject.Enumerator>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(dictionary);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedObject.Enumerator.NativeMethodInfoPtr__ctor_Internal_Void_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005061 RID: 20577 RVA: 0x0016D5AC File Offset: 0x0016B7AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331508, XrefRangeEnd = 331517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedObject.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170018F2 RID: 6386
			// (get) Token: 0x06005062 RID: 20578 RVA: 0x0016D5F0 File Offset: 0x0016B7F0
			public unsafe SerializedObject.Field Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedObject.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Field_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new SerializedObject.Field(intPtr);
				}
			}

			// Token: 0x06005063 RID: 20579 RVA: 0x0016D62C File Offset: 0x0016B82C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedObject.Enumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170018F3 RID: 6387
			// (get) Token: 0x06005064 RID: 20580 RVA: 0x0016D664 File Offset: 0x0016B864
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331517, XrefRangeEnd = 331520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedObject.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005065 RID: 20581 RVA: 0x0016D6A8 File Offset: 0x0016B8A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331520, XrefRangeEnd = 331522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedObject.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005066 RID: 20582 RVA: 0x0001D429 File Offset: 0x0001B629
			public Enumerator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06005067 RID: 20583 RVA: 0x0001D432 File Offset: 0x0001B632
			public Enumerator()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedObject.Enumerator>.NativeClassPtr))
			{
			}

			// Token: 0x170018EF RID: 6383
			// (get) Token: 0x06005068 RID: 20584 RVA: 0x0016D6E0 File Offset: 0x0016B8E0
			// (set) Token: 0x06005069 RID: 20585 RVA: 0x0001D444 File Offset: 0x0001B644
			public unsafe IndexedDictionary<string, SerializedObject.OJtbadKtZgCsFAuYmKmIFGcrWza> ePPbmHJRexSdoExlntQpBSQjqgIV
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedObject.Enumerator.NativeFieldInfoPtr_ePPbmHJRexSdoExlntQpBSQjqgIV);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IndexedDictionary<string, SerializedObject.OJtbadKtZgCsFAuYmKmIFGcrWza>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedObject.Enumerator.NativeFieldInfoPtr_ePPbmHJRexSdoExlntQpBSQjqgIV), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170018F0 RID: 6384
			// (get) Token: 0x0600506A RID: 20586 RVA: 0x0016D710 File Offset: 0x0016B910
			// (set) Token: 0x0600506B RID: 20587 RVA: 0x0001D463 File Offset: 0x0001B663
			public SerializedObject.Field EDWjCkozGqmyQyquicPQVDMTCVq
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedObject.Enumerator.NativeFieldInfoPtr_EDWjCkozGqmyQyquicPQVDMTCVq);
					return new SerializedObject.Field(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SerializedObject.Field>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedObject.Enumerator.NativeFieldInfoPtr_EDWjCkozGqmyQyquicPQVDMTCVq), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SerializedObject.Field>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170018F1 RID: 6385
			// (get) Token: 0x0600506C RID: 20588 RVA: 0x0016D740 File Offset: 0x0016B940
			// (set) Token: 0x0600506D RID: 20589 RVA: 0x0001D491 File Offset: 0x0001B691
			public unsafe IEnumerator<KeyValuePair<string, SerializedObject.OJtbadKtZgCsFAuYmKmIFGcrWza>> hVswKwPIRbWLEXwXjLTIZKKEsaw
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedObject.Enumerator.NativeFieldInfoPtr_hVswKwPIRbWLEXwXjLTIZKKEsaw);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<KeyValuePair<string, SerializedObject.OJtbadKtZgCsFAuYmKmIFGcrWza>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedObject.Enumerator.NativeFieldInfoPtr_hVswKwPIRbWLEXwXjLTIZKKEsaw), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040042EC RID: 17132
			private static readonly IntPtr NativeFieldInfoPtr_ePPbmHJRexSdoExlntQpBSQjqgIV;

			// Token: 0x040042ED RID: 17133
			private static readonly IntPtr NativeFieldInfoPtr_EDWjCkozGqmyQyquicPQVDMTCVq;

			// Token: 0x040042EE RID: 17134
			private static readonly IntPtr NativeFieldInfoPtr_hVswKwPIRbWLEXwXjLTIZKKEsaw;

			// Token: 0x040042EF RID: 17135
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Object_0;

			// Token: 0x040042F0 RID: 17136
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

			// Token: 0x040042F1 RID: 17137
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Field_0;

			// Token: 0x040042F2 RID: 17138
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

			// Token: 0x040042F3 RID: 17139
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040042F4 RID: 17140
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
		}

		// Token: 0x020003DF RID: 991
		public class tVzBeTABhIliJzriaeJwwWYfoEc : Object
		{
			// Token: 0x0600506E RID: 20590 RVA: 0x0016D770 File Offset: 0x0016B970
			// Note: this type is marked as 'beforefieldinit'.
			static tVzBeTABhIliJzriaeJwwWYfoEc()
			{
				Il2CppClassPointerStore<SerializedObject.tVzBeTABhIliJzriaeJwwWYfoEc>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SerializedObject>.NativeClassPtr, "tVzBeTABhIliJzriaeJwwWYfoEc");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedObject.tVzBeTABhIliJzriaeJwwWYfoEc>.NativeClassPtr);
				SerializedObject.tVzBeTABhIliJzriaeJwwWYfoEc.NativeFieldInfoPtr_cqRXKbabWMjtoJgeBvXIQdFYoRy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedObject.tVzBeTABhIliJzriaeJwwWYfoEc>.NativeClassPtr, "cqRXKbabWMjtoJgeBvXIQdFYoRy");
				SerializedObject.tVzBeTABhIliJzriaeJwwWYfoEc.NativeMethodInfoPtr_get_root_Public_get_BgILaQjYTkgDPIJBhclnEXnQiMs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedObject.tVzBeTABhIliJzriaeJwwWYfoEc>.NativeClassPtr, 100675308);
				SerializedObject.tVzBeTABhIliJzriaeJwwWYfoEc.NativeMethodInfoPtr_get_isValid_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedObject.tVzBeTABhIliJzriaeJwwWYfoEc>.NativeClassPtr, 100675309);
				SerializedObject.tVzBeTABhIliJzriaeJwwWYfoEc.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedObject.tVzBeTABhIliJzriaeJwwWYfoEc>.NativeClassPtr, 100675310);
				SerializedObject.tVzBeTABhIliJzriaeJwwWYfoEc.NativeMethodInfoPtr_cSTiULeYUIoAuJzHcgRFdJnTybT_Private_Void_XmlReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedObject.tVzBeTABhIliJzriaeJwwWYfoEc>.NativeClassPtr, 100675311);
				SerializedObject.tVzBeTABhIliJzriaeJwwWYfoEc.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedObject.tVzBeTABhIliJzriaeJwwWYfoEc>.NativeClassPtr, 100675312);
			}

			// Token: 0x170018F5 RID: 6389
			// (get) Token: 0x0600506F RID: 20591 RVA: 0x0016D814 File Offset: 0x0016BA14
			public unsafe SerializedObject.tVzBeTABhIliJzriaeJwwWYfoEc.BgILaQjYTkgDPIJBhclnEXnQiMs SCAWeGqMYuMccBEHxSPChKJVGDbB
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedObject.tVzBeTABhIliJzriaeJwwWYfoEc.NativeMethodInfoPtr_get_root_Public_get_BgILaQjYTkgDPIJBhclnEXnQiMs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedObject.tVzBeTABhIliJzriaeJwwWYfoEc.BgILaQjYTkgDPIJBhclnEXnQiMs>(intPtr3) : null;
				}
			}

			// Token: 0x170018F6 RID: 6390
			// (get) Token: 0x06005070 RID: 20592 RVA: 0x0016D854 File Offset: 0x0016BA54
			public unsafe bool HrbCibDTvZnSiwpXqnKohFgEKpJl
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedObject.tVzBeTABhIliJzriaeJwwWYfoEc.NativeMethodInfoPtr_get_isValid_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005071 RID: 20593 RVA: 0x0016D890 File Offset: 0x0016BA90
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 331763, RefRangeEnd = 331764, XrefRangeStart = 331735, XrefRangeEnd = 331763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe tVzBeTABhIliJzriaeJwwWYfoEc(string xml)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedObject.tVzBeTABhIliJzriaeJwwWYfoEc>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(xml);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedObject.tVzBeTABhIliJzriaeJwwWYfoEc.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005072 RID: 20594 RVA: 0x0016D8DC File Offset: 0x0016BADC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 331773, RefRangeEnd = 331774, XrefRangeStart = 331764, XrefRangeEnd = 331773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void cSTiULeYUIoAuJzHcgRFdJnTybT(XmlReader A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedObject.tVzBeTABhIliJzriaeJwwWYfoEc.NativeMethodInfoPtr_cSTiULeYUIoAuJzHcgRFdJnTybT_Private_Void_XmlReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005073 RID: 20595 RVA: 0x0016D920 File Offset: 0x0016BB20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331774, XrefRangeEnd = 331777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string ToString()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedObject.tVzBeTABhIliJzriaeJwwWYfoEc.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06005074 RID: 20596 RVA: 0x0001D4B0 File Offset: 0x0001B6B0
			public tVzBeTABhIliJzriaeJwwWYfoEc(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170018F4 RID: 6388
			// (get) Token: 0x06005075 RID: 20597 RVA: 0x0016D964 File Offset: 0x0016BB64
			// (set) Token: 0x06005076 RID: 20598 RVA: 0x0001D4B9 File Offset: 0x0001B6B9
			public unsafe SerializedObject.tVzBeTABhIliJzriaeJwwWYfoEc.BgILaQjYTkgDPIJBhclnEXnQiMs cqRXKbabWMjtoJgeBvXIQdFYoRy
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedObject.tVzBeTABhIliJzriaeJwwWYfoEc.NativeFieldInfoPtr_cqRXKbabWMjtoJgeBvXIQdFYoRy);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializedObject.tVzBeTABhIliJzriaeJwwWYfoEc.BgILaQjYTkgDPIJBhclnEXnQiMs>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedObject.tVzBeTABhIliJzriaeJwwWYfoEc.NativeFieldInfoPtr_cqRXKbabWMjtoJgeBvXIQdFYoRy), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040042F5 RID: 17141
			private static readonly IntPtr NativeFieldInfoPtr_cqRXKbabWMjtoJgeBvXIQdFYoRy;

			// Token: 0x040042F6 RID: 17142
			private static readonly IntPtr NativeMethodInfoPtr_get_root_Public_get_BgILaQjYTkgDPIJBhclnEXnQiMs_0;

			// Token: 0x040042F7 RID: 17143
			private static readonly IntPtr NativeMethodInfoPtr_get_isValid_Public_get_Boolean_0;

			// Token: 0x040042F8 RID: 17144
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

			// Token: 0x040042F9 RID: 17145
			private static readonly IntPtr NativeMethodInfoPtr_cSTiULeYUIoAuJzHcgRFdJnTybT_Private_Void_XmlReader_0;

			// Token: 0x040042FA RID: 17146
			private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

			// Token: 0x020005AC RID: 1452
			public class BgILaQjYTkgDPIJBhclnEXnQiMs : Object
			{
				// Token: 0x060060F9 RID: 24825 RVA: 0x001AF364 File Offset: 0x001AD564
				// Note: this type is marked as 'beforefieldinit'.
				static BgILaQjYTkgDPIJBhclnEXnQiMs()
				{
					Il2CppClassPointerStore<SerializedObject.tVzBeTABhIliJzriaeJwwWYfoEc.BgILaQjYTkgDPIJBhclnEXnQiMs>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SerializedObject.tVzBeTABhIliJzriaeJwwWYfoEc>.NativeClassPtr, "BgILaQjYTkgDPIJBhclnEXnQiMs");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedObject.tVzBeTABhIliJzriaeJwwWYfoEc.BgILaQjYTkgDPIJBhclnEXnQiMs>.NativeClassPtr);
					SerializedObject.tVzBeTABhIliJzriaeJwwWYfoEc.BgILaQjYTkgDPIJBhclnEXnQiMs.NativeFieldInfoPtr_pbWfYXGBdYdKqiCIvDjvzTYoqSFB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedObject.tVzBeTABhIliJzriaeJwwWYfoEc.BgILaQjYTkgDPIJBhclnEXnQiMs>.NativeClassPtr, "pbWfYXGBdYdKqiCIvDjvzTYoqSFB");
					SerializedObject.tVzBeTABhIliJzriaeJwwWYfoEc.BgILaQjYTkgDPIJBhclnEXnQiMs.NativeFieldInfoPtr_vlMVohUwhuEZRkFNHvZjgQXyRap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedObject.tVzBeTABhIliJzriaeJwwWYfoEc.BgILaQjYTkgDPIJBhclnEXnQiMs>.NativeClassPtr, "vlMVohUwhuEZRkFNHvZjgQXyRap");
					SerializedObject.tVzBeTABhIliJzriaeJwwWYfoEc.BgILaQjYTkgDPIJBhclnEXnQiMs.NativeFieldInfoPtr_urrWdAyKRagZkoxELFbIGyHGsDR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedObject.tVzBeTABhIliJzriaeJwwWYfoEc.BgILaQjYTkgDPIJBhclnEXnQiMs>.NativeClassPtr, "urrWdAyKRagZkoxELFbIGyHGsDR");
					SerializedObject.tVzBeTABhIliJzriaeJwwWYfoEc.BgILaQjYTkgDPIJBhclnEXnQiMs.NativeFieldInfoPtr_UkjSAetaVsVWZQtmtbeHIqejELd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedObject.tVzBeTABhIliJzriaeJwwWYfoEc.BgILaQjYTkgDPIJBhclnEXnQiMs>.NativeClassPtr, "UkjSAetaVsVWZQtmtbeHIqejELd");
					SerializedObject.tVzBeTABhIliJzriaeJwwWYfoEc.BgILaQjYTkgDPIJBhclnEXnQiMs.NativeFieldInfoPtr_DiLWtDAOrubgbiexaelUHbDepIR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedObject.tVzBeTABhIliJzriaeJwwWYfoEc.BgILaQjYTkgDPIJBhclnEXnQiMs>.NativeClassPtr, "DiLWtDAOrubgbiexaelUHbDepIR");
					SerializedObject.tVzBeTABhIliJzriaeJwwWYfoEc.BgILaQjYTkgDPIJBhclnEXnQiMs.NativeMethodInfoPtr_get_childCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedObject.tVzBeTABhIliJzriaeJwwWYfoEc.BgILaQjYTkgDPIJBhclnEXnQiMs>.NativeClassPtr, 100675313);
					SerializedObject.tVzBeTABhIliJzriaeJwwWYfoEc.BgILaQjYTkgDPIJBhclnEXnQiMs.NativeMethodInfoPtr_get_attributeCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedObject.tVzBeTABhIliJzriaeJwwWYfoEc.BgILaQjYTkgDPIJBhclnEXnQiMs>.NativeClassPtr, 100675314);
					SerializedObject.tVzBeTABhIliJzriaeJwwWYfoEc.BgILaQjYTkgDPIJBhclnEXnQiMs.NativeMethodInfoPtr__ctor_Public_Void_String_BgILaQjYTkgDPIJBhclnEXnQiMs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedObject.tVzBeTABhIliJzriaeJwwWYfoEc.BgILaQjYTkgDPIJBhclnEXnQiMs>.NativeClassPtr, 100675315);
					SerializedObject.tVzBeTABhIliJzriaeJwwWYfoEc.BgILaQjYTkgDPIJBhclnEXnQiMs.NativeMethodInfoPtr_TQvDGVJLKCzlDWWtkoKAgAVjOmv_Public_Void_BgILaQjYTkgDPIJBhclnEXnQiMs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedObject.tVzBeTABhIliJzriaeJwwWYfoEc.BgILaQjYTkgDPIJBhclnEXnQiMs>.NativeClassPtr, 100675316);
					SerializedObject.tVzBeTABhIliJzriaeJwwWYfoEc.BgILaQjYTkgDPIJBhclnEXnQiMs.NativeMethodInfoPtr_XpKXlfhChCLQdkFcxmFvplJgkyA_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedObject.tVzBeTABhIliJzriaeJwwWYfoEc.BgILaQjYTkgDPIJBhclnEXnQiMs>.NativeClassPtr, 100675317);
					SerializedObject.tVzBeTABhIliJzriaeJwwWYfoEc.BgILaQjYTkgDPIJBhclnEXnQiMs.NativeMethodInfoPtr_sDgmRqeBSIlcBETyEQycUizkgNE_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedObject.tVzBeTABhIliJzriaeJwwWYfoEc.BgILaQjYTkgDPIJBhclnEXnQiMs>.NativeClassPtr, 100675318);
					SerializedObject.tVzBeTABhIliJzriaeJwwWYfoEc.BgILaQjYTkgDPIJBhclnEXnQiMs.NativeMethodInfoPtr_AdLocuqrGxKWXLMKLtyxoaOmvPy_Public_BgILaQjYTkgDPIJBhclnEXnQiMs_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedObject.tVzBeTABhIliJzriaeJwwWYfoEc.BgILaQjYTkgDPIJBhclnEXnQiMs>.NativeClassPtr, 100675319);
					SerializedObject.tVzBeTABhIliJzriaeJwwWYfoEc.BgILaQjYTkgDPIJBhclnEXnQiMs.NativeMethodInfoPtr_ilSlsOwhinGLnJHuXfFPXlmrPDzj_Public_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedObject.tVzBeTABhIliJzriaeJwwWYfoEc.BgILaQjYTkgDPIJBhclnEXnQiMs>.NativeClassPtr, 100675320);
					SerializedObject.tVzBeTABhIliJzriaeJwwWYfoEc.BgILaQjYTkgDPIJBhclnEXnQiMs.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedObject.tVzBeTABhIliJzriaeJwwWYfoEc.BgILaQjYTkgDPIJBhclnEXnQiMs>.NativeClassPtr, 100675321);
					SerializedObject.tVzBeTABhIliJzriaeJwwWYfoEc.BgILaQjYTkgDPIJBhclnEXnQiMs.NativeMethodInfoPtr_TXsURIDxzCEUWgmesVERJuSnYbZ_Private_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedObject.tVzBeTABhIliJzriaeJwwWYfoEc.BgILaQjYTkgDPIJBhclnEXnQiMs>.NativeClassPtr, 100675322);
				}

				// Token: 0x17001D61 RID: 7521
				// (get) Token: 0x060060FA RID: 24826 RVA: 0x001AF4BC File Offset: 0x001AD6BC
				public unsafe int PnJiedYHRqabyETXnvWnkMFJfXy
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331522, XrefRangeEnd = 331523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedObject.tVzBeTABhIliJzriaeJwwWYfoEc.BgILaQjYTkgDPIJBhclnEXnQiMs.NativeMethodInfoPtr_get_childCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x17001D62 RID: 7522
				// (get) Token: 0x060060FB RID: 24827 RVA: 0x001AF4F8 File Offset: 0x001AD6F8
				public unsafe int WhPGDYHhDRXKZnbOpfCdOqyxHjk
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331523, XrefRangeEnd = 331524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedObject.tVzBeTABhIliJzriaeJwwWYfoEc.BgILaQjYTkgDPIJBhclnEXnQiMs.NativeMethodInfoPtr_get_attributeCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x060060FC RID: 24828 RVA: 0x001AF534 File Offset: 0x001AD734
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 331533, RefRangeEnd = 331535, XrefRangeStart = 331524, XrefRangeEnd = 331533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe BgILaQjYTkgDPIJBhclnEXnQiMs(string name, SerializedObject.tVzBeTABhIliJzriaeJwwWYfoEc.BgILaQjYTkgDPIJBhclnEXnQiMs parent)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedObject.tVzBeTABhIliJzriaeJwwWYfoEc.BgILaQjYTkgDPIJBhclnEXnQiMs>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedObject.tVzBeTABhIliJzriaeJwwWYfoEc.BgILaQjYTkgDPIJBhclnEXnQiMs.NativeMethodInfoPtr__ctor_Public_Void_String_BgILaQjYTkgDPIJBhclnEXnQiMs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060060FD RID: 24829 RVA: 0x001AF594 File Offset: 0x001AD794
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331535, XrefRangeEnd = 331544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void TQvDGVJLKCzlDWWtkoKAgAVjOmv(SerializedObject.tVzBeTABhIliJzriaeJwwWYfoEc.BgILaQjYTkgDPIJBhclnEXnQiMs A_1)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedObject.tVzBeTABhIliJzriaeJwwWYfoEc.BgILaQjYTkgDPIJBhclnEXnQiMs.NativeMethodInfoPtr_TQvDGVJLKCzlDWWtkoKAgAVjOmv_Public_Void_BgILaQjYTkgDPIJBhclnEXnQiMs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x060060FE RID: 24830 RVA: 0x001AF5D8 File Offset: 0x001AD7D8
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 331554, RefRangeEnd = 331555, XrefRangeStart = 331544, XrefRangeEnd = 331554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void XpKXlfhChCLQdkFcxmFvplJgkyA(string A_1, string A_2)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.ManagedStringToIl2Cpp(A_1);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(A_2);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedObject.tVzBeTABhIliJzriaeJwwWYfoEc.BgILaQjYTkgDPIJBhclnEXnQiMs.NativeMethodInfoPtr_XpKXlfhChCLQdkFcxmFvplJgkyA_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060060FF RID: 24831 RVA: 0x001AF62C File Offset: 0x001AD82C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331555, XrefRangeEnd = 331556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool sDgmRqeBSIlcBETyEQycUizkgNE(string A_1)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.ManagedStringToIl2Cpp(A_1);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedObject.tVzBeTABhIliJzriaeJwwWYfoEc.BgILaQjYTkgDPIJBhclnEXnQiMs.NativeMethodInfoPtr_sDgmRqeBSIlcBETyEQycUizkgNE_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x06006100 RID: 24832 RVA: 0x001AF67C File Offset: 0x001AD87C
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 331563, RefRangeEnd = 331565, XrefRangeStart = 331556, XrefRangeEnd = 331563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe SerializedObject.tVzBeTABhIliJzriaeJwwWYfoEc.BgILaQjYTkgDPIJBhclnEXnQiMs AdLocuqrGxKWXLMKLtyxoaOmvPy(string A_1)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.ManagedStringToIl2Cpp(A_1);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedObject.tVzBeTABhIliJzriaeJwwWYfoEc.BgILaQjYTkgDPIJBhclnEXnQiMs.NativeMethodInfoPtr_AdLocuqrGxKWXLMKLtyxoaOmvPy_Public_BgILaQjYTkgDPIJBhclnEXnQiMs_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedObject.tVzBeTABhIliJzriaeJwwWYfoEc.BgILaQjYTkgDPIJBhclnEXnQiMs>(intPtr3) : null;
					}
				}

				// Token: 0x06006101 RID: 24833 RVA: 0x001AF6CC File Offset: 0x001AD8CC
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 331579, RefRangeEnd = 331581, XrefRangeStart = 331565, XrefRangeEnd = 331579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Object ilSlsOwhinGLnJHuXfFPXlmrPDzj()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedObject.tVzBeTABhIliJzriaeJwwWYfoEc.BgILaQjYTkgDPIJBhclnEXnQiMs.NativeMethodInfoPtr_ilSlsOwhinGLnJHuXfFPXlmrPDzj_Public_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}

				// Token: 0x06006102 RID: 24834 RVA: 0x001AF70C File Offset: 0x001AD90C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331581, XrefRangeEnd = 331584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe override string ToString()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedObject.tVzBeTABhIliJzriaeJwwWYfoEc.BgILaQjYTkgDPIJBhclnEXnQiMs.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}

				// Token: 0x06006103 RID: 24835 RVA: 0x001AF750 File Offset: 0x001AD950
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 331733, RefRangeEnd = 331735, XrefRangeStart = 331584, XrefRangeEnd = 331733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe string TXsURIDxzCEUWgmesVERJuSnYbZ(string A_1, int A_2)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.ManagedStringToIl2Cpp(A_1);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedObject.tVzBeTABhIliJzriaeJwwWYfoEc.BgILaQjYTkgDPIJBhclnEXnQiMs.NativeMethodInfoPtr_TXsURIDxzCEUWgmesVERJuSnYbZ_Private_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}

				// Token: 0x06006104 RID: 24836 RVA: 0x00023CCE File Offset: 0x00021ECE
				public BgILaQjYTkgDPIJBhclnEXnQiMs(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17001D5C RID: 7516
				// (get) Token: 0x06006105 RID: 24837 RVA: 0x001AF7A8 File Offset: 0x001AD9A8
				// (set) Token: 0x06006106 RID: 24838 RVA: 0x00023CD7 File Offset: 0x00021ED7
				public unsafe string pbWfYXGBdYdKqiCIvDjvzTYoqSFB
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedObject.tVzBeTABhIliJzriaeJwwWYfoEc.BgILaQjYTkgDPIJBhclnEXnQiMs.NativeFieldInfoPtr_pbWfYXGBdYdKqiCIvDjvzTYoqSFB);
						return IL2CPP.Il2CppStringToManaged(*intPtr);
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedObject.tVzBeTABhIliJzriaeJwwWYfoEc.BgILaQjYTkgDPIJBhclnEXnQiMs.NativeFieldInfoPtr_pbWfYXGBdYdKqiCIvDjvzTYoqSFB), IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x17001D5D RID: 7517
				// (get) Token: 0x06006107 RID: 24839 RVA: 0x001AF7D0 File Offset: 0x001AD9D0
				// (set) Token: 0x06006108 RID: 24840 RVA: 0x00023CF6 File Offset: 0x00021EF6
				public unsafe SerializedObject.tVzBeTABhIliJzriaeJwwWYfoEc.BgILaQjYTkgDPIJBhclnEXnQiMs vlMVohUwhuEZRkFNHvZjgQXyRap
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedObject.tVzBeTABhIliJzriaeJwwWYfoEc.BgILaQjYTkgDPIJBhclnEXnQiMs.NativeFieldInfoPtr_vlMVohUwhuEZRkFNHvZjgQXyRap);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializedObject.tVzBeTABhIliJzriaeJwwWYfoEc.BgILaQjYTkgDPIJBhclnEXnQiMs>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedObject.tVzBeTABhIliJzriaeJwwWYfoEc.BgILaQjYTkgDPIJBhclnEXnQiMs.NativeFieldInfoPtr_vlMVohUwhuEZRkFNHvZjgQXyRap), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17001D5E RID: 7518
				// (get) Token: 0x06006109 RID: 24841 RVA: 0x001AF800 File Offset: 0x001ADA00
				// (set) Token: 0x0600610A RID: 24842 RVA: 0x00023D15 File Offset: 0x00021F15
				public unsafe string urrWdAyKRagZkoxELFbIGyHGsDR
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedObject.tVzBeTABhIliJzriaeJwwWYfoEc.BgILaQjYTkgDPIJBhclnEXnQiMs.NativeFieldInfoPtr_urrWdAyKRagZkoxELFbIGyHGsDR);
						return IL2CPP.Il2CppStringToManaged(*intPtr);
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedObject.tVzBeTABhIliJzriaeJwwWYfoEc.BgILaQjYTkgDPIJBhclnEXnQiMs.NativeFieldInfoPtr_urrWdAyKRagZkoxELFbIGyHGsDR), IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x17001D5F RID: 7519
				// (get) Token: 0x0600610B RID: 24843 RVA: 0x001AF828 File Offset: 0x001ADA28
				// (set) Token: 0x0600610C RID: 24844 RVA: 0x00023D34 File Offset: 0x00021F34
				public unsafe Dictionary<string, string> UkjSAetaVsVWZQtmtbeHIqejELd
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedObject.tVzBeTABhIliJzriaeJwwWYfoEc.BgILaQjYTkgDPIJBhclnEXnQiMs.NativeFieldInfoPtr_UkjSAetaVsVWZQtmtbeHIqejELd);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedObject.tVzBeTABhIliJzriaeJwwWYfoEc.BgILaQjYTkgDPIJBhclnEXnQiMs.NativeFieldInfoPtr_UkjSAetaVsVWZQtmtbeHIqejELd), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17001D60 RID: 7520
				// (get) Token: 0x0600610D RID: 24845 RVA: 0x001AF858 File Offset: 0x001ADA58
				// (set) Token: 0x0600610E RID: 24846 RVA: 0x00023D53 File Offset: 0x00021F53
				public unsafe List<SerializedObject.tVzBeTABhIliJzriaeJwwWYfoEc.BgILaQjYTkgDPIJBhclnEXnQiMs> DiLWtDAOrubgbiexaelUHbDepIR
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedObject.tVzBeTABhIliJzriaeJwwWYfoEc.BgILaQjYTkgDPIJBhclnEXnQiMs.NativeFieldInfoPtr_DiLWtDAOrubgbiexaelUHbDepIR);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SerializedObject.tVzBeTABhIliJzriaeJwwWYfoEc.BgILaQjYTkgDPIJBhclnEXnQiMs>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedObject.tVzBeTABhIliJzriaeJwwWYfoEc.BgILaQjYTkgDPIJBhclnEXnQiMs.NativeFieldInfoPtr_DiLWtDAOrubgbiexaelUHbDepIR), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04004F7A RID: 20346
				private static readonly IntPtr NativeFieldInfoPtr_pbWfYXGBdYdKqiCIvDjvzTYoqSFB;

				// Token: 0x04004F7B RID: 20347
				private static readonly IntPtr NativeFieldInfoPtr_vlMVohUwhuEZRkFNHvZjgQXyRap;

				// Token: 0x04004F7C RID: 20348
				private static readonly IntPtr NativeFieldInfoPtr_urrWdAyKRagZkoxELFbIGyHGsDR;

				// Token: 0x04004F7D RID: 20349
				private static readonly IntPtr NativeFieldInfoPtr_UkjSAetaVsVWZQtmtbeHIqejELd;

				// Token: 0x04004F7E RID: 20350
				private static readonly IntPtr NativeFieldInfoPtr_DiLWtDAOrubgbiexaelUHbDepIR;

				// Token: 0x04004F7F RID: 20351
				private static readonly IntPtr NativeMethodInfoPtr_get_childCount_Public_get_Int32_0;

				// Token: 0x04004F80 RID: 20352
				private static readonly IntPtr NativeMethodInfoPtr_get_attributeCount_Public_get_Int32_0;

				// Token: 0x04004F81 RID: 20353
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_BgILaQjYTkgDPIJBhclnEXnQiMs_0;

				// Token: 0x04004F82 RID: 20354
				private static readonly IntPtr NativeMethodInfoPtr_TQvDGVJLKCzlDWWtkoKAgAVjOmv_Public_Void_BgILaQjYTkgDPIJBhclnEXnQiMs_0;

				// Token: 0x04004F83 RID: 20355
				private static readonly IntPtr NativeMethodInfoPtr_XpKXlfhChCLQdkFcxmFvplJgkyA_Public_Void_String_String_0;

				// Token: 0x04004F84 RID: 20356
				private static readonly IntPtr NativeMethodInfoPtr_sDgmRqeBSIlcBETyEQycUizkgNE_Public_Boolean_String_0;

				// Token: 0x04004F85 RID: 20357
				private static readonly IntPtr NativeMethodInfoPtr_AdLocuqrGxKWXLMKLtyxoaOmvPy_Public_BgILaQjYTkgDPIJBhclnEXnQiMs_String_0;

				// Token: 0x04004F86 RID: 20358
				private static readonly IntPtr NativeMethodInfoPtr_ilSlsOwhinGLnJHuXfFPXlmrPDzj_Public_Object_0;

				// Token: 0x04004F87 RID: 20359
				private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

				// Token: 0x04004F88 RID: 20360
				private static readonly IntPtr NativeMethodInfoPtr_TXsURIDxzCEUWgmesVERJuSnYbZ_Private_String_String_Int32_0;
			}
		}

		// Token: 0x020003E0 RID: 992
		private sealed class MethodInfoStoreGeneric_Add_Public_Void_String_T_FieldOptions_0<T>
		{
			// Token: 0x040042FB RID: 17147
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SerializedObject.NativeMethodInfoPtr_Add_Public_Void_String_T_FieldOptions_0, Il2CppClassPointerStore<SerializedObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020003E1 RID: 993
		private sealed class MethodInfoStoreGeneric_GetOriginalValue_Public_T_String_0<T>
		{
			// Token: 0x040042FC RID: 17148
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SerializedObject.NativeMethodInfoPtr_GetOriginalValue_Public_T_String_0, Il2CppClassPointerStore<SerializedObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020003E2 RID: 994
		private sealed class MethodInfoStoreGeneric_GetOriginalValue_Public_T_Int32_0<T>
		{
			// Token: 0x040042FD RID: 17149
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SerializedObject.NativeMethodInfoPtr_GetOriginalValue_Public_T_Int32_0, Il2CppClassPointerStore<SerializedObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020003E3 RID: 995
		private sealed class MethodInfoStoreGeneric_TryGetDeserializedValue_Public_Boolean_String_byref_T_0<T>
		{
			// Token: 0x040042FE RID: 17150
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SerializedObject.NativeMethodInfoPtr_TryGetDeserializedValue_Public_Boolean_String_byref_T_0, Il2CppClassPointerStore<SerializedObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020003E4 RID: 996
		private sealed class MethodInfoStoreGeneric_TryGetDeserializedValue_Public_Boolean_Int32_byref_T_0<T>
		{
			// Token: 0x040042FF RID: 17151
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SerializedObject.NativeMethodInfoPtr_TryGetDeserializedValue_Public_Boolean_Int32_byref_T_0, Il2CppClassPointerStore<SerializedObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020003E5 RID: 997
		private sealed class MethodInfoStoreGeneric_TryGetDeserializedValueByRef_Public_Boolean_String_byref_T_0<T>
		{
			// Token: 0x04004300 RID: 17152
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SerializedObject.NativeMethodInfoPtr_TryGetDeserializedValueByRef_Public_Boolean_String_byref_T_0, Il2CppClassPointerStore<SerializedObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020003E6 RID: 998
		private sealed class MethodInfoStoreGeneric_TryGetDeserializedValueByRef_Public_Boolean_Int32_byref_T_0<T>
		{
			// Token: 0x04004301 RID: 17153
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SerializedObject.NativeMethodInfoPtr_TryGetDeserializedValueByRef_Public_Boolean_Int32_byref_T_0, Il2CppClassPointerStore<SerializedObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020003E7 RID: 999
		private sealed class MethodInfoStoreGeneric_XQmfXzeOBltQMFMaZowhIixSicuJ_Private_Static_Boolean_Object_byref_T_NumberStyles_CultureInfo_0<T>
		{
			// Token: 0x04004302 RID: 17154
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SerializedObject.NativeMethodInfoPtr_XQmfXzeOBltQMFMaZowhIixSicuJ_Private_Static_Boolean_Object_byref_T_NumberStyles_CultureInfo_0, Il2CppClassPointerStore<SerializedObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
