using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x0200034B RID: 843
	public sealed class SerializationInfoEnumerator : Object
	{
		// Token: 0x06003722 RID: 14114 RVA: 0x0010DD68 File Offset: 0x0010BF68
		// Note: this type is marked as 'beforefieldinit'.
		static SerializationInfoEnumerator()
		{
			Il2CppClassPointerStore<SerializationInfoEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "SerializationInfoEnumerator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializationInfoEnumerator>.NativeClassPtr);
			SerializationInfoEnumerator.NativeFieldInfoPtr_m_members = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationInfoEnumerator>.NativeClassPtr, "m_members");
			SerializationInfoEnumerator.NativeFieldInfoPtr_m_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationInfoEnumerator>.NativeClassPtr, "m_data");
			SerializationInfoEnumerator.NativeFieldInfoPtr_m_types = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationInfoEnumerator>.NativeClassPtr, "m_types");
			SerializationInfoEnumerator.NativeFieldInfoPtr_m_numItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationInfoEnumerator>.NativeClassPtr, "m_numItems");
			SerializationInfoEnumerator.NativeFieldInfoPtr_m_currItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationInfoEnumerator>.NativeClassPtr, "m_currItem");
			SerializationInfoEnumerator.NativeFieldInfoPtr_m_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationInfoEnumerator>.NativeClassPtr, "m_current");
			SerializationInfoEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_Il2CppStringArray_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_Type_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfoEnumerator>.NativeClassPtr, 100671847);
			SerializationInfoEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfoEnumerator>.NativeClassPtr, 100671848);
			SerializationInfoEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfoEnumerator>.NativeClassPtr, 100671849);
			SerializationInfoEnumerator.NativeMethodInfoPtr_get_Current_Public_get_SerializationEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfoEnumerator>.NativeClassPtr, 100671850);
			SerializationInfoEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfoEnumerator>.NativeClassPtr, 100671851);
			SerializationInfoEnumerator.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfoEnumerator>.NativeClassPtr, 100671852);
			SerializationInfoEnumerator.NativeMethodInfoPtr_get_Value_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfoEnumerator>.NativeClassPtr, 100671853);
			SerializationInfoEnumerator.NativeMethodInfoPtr_get_ObjectType_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfoEnumerator>.NativeClassPtr, 100671854);
		}

		// Token: 0x06003723 RID: 14115 RVA: 0x0010DEB0 File Offset: 0x0010C0B0
		[CallerCount(0)]
		public unsafe SerializationInfoEnumerator(Il2CppStringArray members, Il2CppReferenceArray<Object> info, Il2CppReferenceArray<Type> types, int numItems)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializationInfoEnumerator>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(members);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(types);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numItems;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfoEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_Il2CppStringArray_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_Type_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003724 RID: 14116 RVA: 0x0010DF30 File Offset: 0x0010C130
		[CallerCount(0)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfoEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000D52 RID: 3410
		// (get) Token: 0x06003725 RID: 14117 RVA: 0x0010DF6C File Offset: 0x0010C16C
		public unsafe Object System.Collections.IEnumerator.Current
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215599, XrefRangeEnd = 215603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfoEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17000D53 RID: 3411
		// (get) Token: 0x06003726 RID: 14118 RVA: 0x0010DFAC File Offset: 0x0010C1AC
		public unsafe SerializationEntry Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 215604, RefRangeEnd = 215611, XrefRangeStart = 215603, XrefRangeEnd = 215604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfoEnumerator.NativeMethodInfoPtr_get_Current_Public_get_SerializationEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new SerializationEntry(intPtr);
			}
		}

		// Token: 0x06003727 RID: 14119 RVA: 0x0010DFE4 File Offset: 0x0010C1E4
		[CallerCount(0)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfoEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000D54 RID: 3412
		// (get) Token: 0x06003728 RID: 14120 RVA: 0x0010E018 File Offset: 0x0010C218
		public unsafe string Name
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 215611, RefRangeEnd = 215625, XrefRangeStart = 215611, XrefRangeEnd = 215611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfoEnumerator.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000D55 RID: 3413
		// (get) Token: 0x06003729 RID: 14121 RVA: 0x0010E050 File Offset: 0x0010C250
		public unsafe Object Value
		{
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 215625, RefRangeEnd = 215641, XrefRangeStart = 215625, XrefRangeEnd = 215625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfoEnumerator.NativeMethodInfoPtr_get_Value_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17000D56 RID: 3414
		// (get) Token: 0x0600372A RID: 14122 RVA: 0x0010E090 File Offset: 0x0010C290
		public unsafe Type ObjectType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfoEnumerator.NativeMethodInfoPtr_get_ObjectType_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x0600372B RID: 14123 RVA: 0x00013999 File Offset: 0x00011B99
		public SerializationInfoEnumerator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D4C RID: 3404
		// (get) Token: 0x0600372C RID: 14124 RVA: 0x0010E0D0 File Offset: 0x0010C2D0
		// (set) Token: 0x0600372D RID: 14125 RVA: 0x000139A2 File Offset: 0x00011BA2
		public unsafe Il2CppStringArray m_members
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfoEnumerator.NativeFieldInfoPtr_m_members);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfoEnumerator.NativeFieldInfoPtr_m_members), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D4D RID: 3405
		// (get) Token: 0x0600372E RID: 14126 RVA: 0x0010E100 File Offset: 0x0010C300
		// (set) Token: 0x0600372F RID: 14127 RVA: 0x000139C1 File Offset: 0x00011BC1
		public unsafe Il2CppReferenceArray<Object> m_data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfoEnumerator.NativeFieldInfoPtr_m_data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfoEnumerator.NativeFieldInfoPtr_m_data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D4E RID: 3406
		// (get) Token: 0x06003730 RID: 14128 RVA: 0x0010E130 File Offset: 0x0010C330
		// (set) Token: 0x06003731 RID: 14129 RVA: 0x000139E0 File Offset: 0x00011BE0
		public unsafe Il2CppReferenceArray<Type> m_types
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfoEnumerator.NativeFieldInfoPtr_m_types);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfoEnumerator.NativeFieldInfoPtr_m_types), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D4F RID: 3407
		// (get) Token: 0x06003732 RID: 14130 RVA: 0x0010E160 File Offset: 0x0010C360
		// (set) Token: 0x06003733 RID: 14131 RVA: 0x000139FF File Offset: 0x00011BFF
		public unsafe int m_numItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfoEnumerator.NativeFieldInfoPtr_m_numItems);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfoEnumerator.NativeFieldInfoPtr_m_numItems)) = value;
			}
		}

		// Token: 0x17000D50 RID: 3408
		// (get) Token: 0x06003734 RID: 14132 RVA: 0x0010E188 File Offset: 0x0010C388
		// (set) Token: 0x06003735 RID: 14133 RVA: 0x00013A1A File Offset: 0x00011C1A
		public unsafe int m_currItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfoEnumerator.NativeFieldInfoPtr_m_currItem);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfoEnumerator.NativeFieldInfoPtr_m_currItem)) = value;
			}
		}

		// Token: 0x17000D51 RID: 3409
		// (get) Token: 0x06003736 RID: 14134 RVA: 0x0010E1B0 File Offset: 0x0010C3B0
		// (set) Token: 0x06003737 RID: 14135 RVA: 0x00013A35 File Offset: 0x00011C35
		public unsafe bool m_current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfoEnumerator.NativeFieldInfoPtr_m_current);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfoEnumerator.NativeFieldInfoPtr_m_current)) = value;
			}
		}

		// Token: 0x04002E67 RID: 11879
		private static readonly IntPtr NativeFieldInfoPtr_m_members;

		// Token: 0x04002E68 RID: 11880
		private static readonly IntPtr NativeFieldInfoPtr_m_data;

		// Token: 0x04002E69 RID: 11881
		private static readonly IntPtr NativeFieldInfoPtr_m_types;

		// Token: 0x04002E6A RID: 11882
		private static readonly IntPtr NativeFieldInfoPtr_m_numItems;

		// Token: 0x04002E6B RID: 11883
		private static readonly IntPtr NativeFieldInfoPtr_m_currItem;

		// Token: 0x04002E6C RID: 11884
		private static readonly IntPtr NativeFieldInfoPtr_m_current;

		// Token: 0x04002E6D RID: 11885
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Il2CppStringArray_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_Type_Int32_0;

		// Token: 0x04002E6E RID: 11886
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x04002E6F RID: 11887
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04002E70 RID: 11888
		private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_get_SerializationEntry_0;

		// Token: 0x04002E71 RID: 11889
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;

		// Token: 0x04002E72 RID: 11890
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x04002E73 RID: 11891
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_Object_0;

		// Token: 0x04002E74 RID: 11892
		private static readonly IntPtr NativeMethodInfoPtr_get_ObjectType_Public_get_Type_0;
	}
}
