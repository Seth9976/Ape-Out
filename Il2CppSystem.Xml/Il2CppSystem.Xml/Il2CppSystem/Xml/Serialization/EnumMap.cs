using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000F3 RID: 243
	public class EnumMap : ObjectMap
	{
		// Token: 0x0600145D RID: 5213 RVA: 0x0006A910 File Offset: 0x00068B10
		// Note: this type is marked as 'beforefieldinit'.
		static EnumMap()
		{
			Il2CppClassPointerStore<EnumMap>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "EnumMap");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnumMap>.NativeClassPtr);
			EnumMap.NativeFieldInfoPtr__members = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumMap>.NativeClassPtr, "_members");
			EnumMap.NativeFieldInfoPtr__isFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumMap>.NativeClassPtr, "_isFlags");
			EnumMap.NativeFieldInfoPtr__enumNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumMap>.NativeClassPtr, "_enumNames");
			EnumMap.NativeFieldInfoPtr__xmlNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumMap>.NativeClassPtr, "_xmlNames");
			EnumMap.NativeFieldInfoPtr__values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumMap>.NativeClassPtr, "_values");
			EnumMap.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_EnumMapMember_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumMap>.NativeClassPtr, 100666424);
			EnumMap.NativeMethodInfoPtr_get_IsFlags_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumMap>.NativeClassPtr, 100666425);
			EnumMap.NativeMethodInfoPtr_get_EnumNames_Public_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumMap>.NativeClassPtr, 100666426);
			EnumMap.NativeMethodInfoPtr_get_XmlNames_Public_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumMap>.NativeClassPtr, 100666427);
			EnumMap.NativeMethodInfoPtr_get_Values_Public_get_Il2CppStructArray_1_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumMap>.NativeClassPtr, 100666428);
			EnumMap.NativeMethodInfoPtr_GetXmlName_Public_String_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumMap>.NativeClassPtr, 100666429);
			EnumMap.NativeMethodInfoPtr_GetEnumName_Public_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumMap>.NativeClassPtr, 100666430);
		}

		// Token: 0x0600145E RID: 5214 RVA: 0x0006AA30 File Offset: 0x00068C30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 407854, RefRangeEnd = 407855, XrefRangeStart = 407841, XrefRangeEnd = 407854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EnumMap(Il2CppReferenceArray<EnumMap.EnumMapMember> members, bool isFlags)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnumMap>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(members);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isFlags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumMap.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_EnumMapMember_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170006D0 RID: 1744
		// (get) Token: 0x0600145F RID: 5215 RVA: 0x0006AA8C File Offset: 0x00068C8C
		public unsafe bool IsFlags
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumMap.NativeMethodInfoPtr_get_IsFlags_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006D1 RID: 1745
		// (get) Token: 0x06001460 RID: 5216 RVA: 0x0006AAC8 File Offset: 0x00068CC8
		public unsafe Il2CppStringArray EnumNames
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumMap.NativeMethodInfoPtr_get_EnumNames_Public_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x170006D2 RID: 1746
		// (get) Token: 0x06001461 RID: 5217 RVA: 0x0006AB08 File Offset: 0x00068D08
		public unsafe Il2CppStringArray XmlNames
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 13519, RefRangeEnd = 13522, XrefRangeStart = 13519, XrefRangeEnd = 13522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumMap.NativeMethodInfoPtr_get_XmlNames_Public_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x170006D3 RID: 1747
		// (get) Token: 0x06001462 RID: 5218 RVA: 0x0006AB48 File Offset: 0x00068D48
		public unsafe Il2CppStructArray<long> Values
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 14016, RefRangeEnd = 14017, XrefRangeStart = 14016, XrefRangeEnd = 14017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumMap.NativeMethodInfoPtr_get_Values_Public_get_Il2CppStructArray_1_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<long>>(intPtr3) : null;
			}
		}

		// Token: 0x06001463 RID: 5219 RVA: 0x0006AB88 File Offset: 0x00068D88
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 407871, RefRangeEnd = 407873, XrefRangeStart = 407855, XrefRangeEnd = 407871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetXmlName(string typeName, Object enumValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(typeName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(enumValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumMap.NativeMethodInfoPtr_GetXmlName_Public_String_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001464 RID: 5220 RVA: 0x0006ABE4 File Offset: 0x00068DE4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 407877, RefRangeEnd = 407879, XrefRangeStart = 407873, XrefRangeEnd = 407877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetEnumName(string typeName, string xmlName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(typeName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(xmlName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumMap.NativeMethodInfoPtr_GetEnumName_Public_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001465 RID: 5221 RVA: 0x0000917B File Offset: 0x0000737B
		public EnumMap(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006CB RID: 1739
		// (get) Token: 0x06001466 RID: 5222 RVA: 0x0006AC40 File Offset: 0x00068E40
		// (set) Token: 0x06001467 RID: 5223 RVA: 0x00009184 File Offset: 0x00007384
		public unsafe Il2CppReferenceArray<EnumMap.EnumMapMember> _members
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumMap.NativeFieldInfoPtr__members);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<EnumMap.EnumMapMember>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumMap.NativeFieldInfoPtr__members), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006CC RID: 1740
		// (get) Token: 0x06001468 RID: 5224 RVA: 0x0006AC70 File Offset: 0x00068E70
		// (set) Token: 0x06001469 RID: 5225 RVA: 0x000091A3 File Offset: 0x000073A3
		public unsafe bool _isFlags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumMap.NativeFieldInfoPtr__isFlags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumMap.NativeFieldInfoPtr__isFlags)) = value;
			}
		}

		// Token: 0x170006CD RID: 1741
		// (get) Token: 0x0600146A RID: 5226 RVA: 0x0006AC98 File Offset: 0x00068E98
		// (set) Token: 0x0600146B RID: 5227 RVA: 0x000091BE File Offset: 0x000073BE
		public unsafe Il2CppStringArray _enumNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumMap.NativeFieldInfoPtr__enumNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumMap.NativeFieldInfoPtr__enumNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006CE RID: 1742
		// (get) Token: 0x0600146C RID: 5228 RVA: 0x0006ACC8 File Offset: 0x00068EC8
		// (set) Token: 0x0600146D RID: 5229 RVA: 0x000091DD File Offset: 0x000073DD
		public unsafe Il2CppStringArray _xmlNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumMap.NativeFieldInfoPtr__xmlNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumMap.NativeFieldInfoPtr__xmlNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006CF RID: 1743
		// (get) Token: 0x0600146E RID: 5230 RVA: 0x0006ACF8 File Offset: 0x00068EF8
		// (set) Token: 0x0600146F RID: 5231 RVA: 0x000091FC File Offset: 0x000073FC
		public unsafe Il2CppStructArray<long> _values
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumMap.NativeFieldInfoPtr__values);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<long>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumMap.NativeFieldInfoPtr__values), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000FB1 RID: 4017
		private static readonly IntPtr NativeFieldInfoPtr__members;

		// Token: 0x04000FB2 RID: 4018
		private static readonly IntPtr NativeFieldInfoPtr__isFlags;

		// Token: 0x04000FB3 RID: 4019
		private static readonly IntPtr NativeFieldInfoPtr__enumNames;

		// Token: 0x04000FB4 RID: 4020
		private static readonly IntPtr NativeFieldInfoPtr__xmlNames;

		// Token: 0x04000FB5 RID: 4021
		private static readonly IntPtr NativeFieldInfoPtr__values;

		// Token: 0x04000FB6 RID: 4022
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_EnumMapMember_Boolean_0;

		// Token: 0x04000FB7 RID: 4023
		private static readonly IntPtr NativeMethodInfoPtr_get_IsFlags_Public_get_Boolean_0;

		// Token: 0x04000FB8 RID: 4024
		private static readonly IntPtr NativeMethodInfoPtr_get_EnumNames_Public_get_Il2CppStringArray_0;

		// Token: 0x04000FB9 RID: 4025
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlNames_Public_get_Il2CppStringArray_0;

		// Token: 0x04000FBA RID: 4026
		private static readonly IntPtr NativeMethodInfoPtr_get_Values_Public_get_Il2CppStructArray_1_Int64_0;

		// Token: 0x04000FBB RID: 4027
		private static readonly IntPtr NativeMethodInfoPtr_GetXmlName_Public_String_String_Object_0;

		// Token: 0x04000FBC RID: 4028
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumName_Public_String_String_String_0;

		// Token: 0x0200022C RID: 556
		public class EnumMapMember : Object
		{
			// Token: 0x06002C27 RID: 11303 RVA: 0x000C5B0C File Offset: 0x000C3D0C
			// Note: this type is marked as 'beforefieldinit'.
			static EnumMapMember()
			{
				Il2CppClassPointerStore<EnumMap.EnumMapMember>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EnumMap>.NativeClassPtr, "EnumMapMember");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnumMap.EnumMapMember>.NativeClassPtr);
				EnumMap.EnumMapMember.NativeFieldInfoPtr__xmlName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumMap.EnumMapMember>.NativeClassPtr, "_xmlName");
				EnumMap.EnumMapMember.NativeFieldInfoPtr__enumName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumMap.EnumMapMember>.NativeClassPtr, "_enumName");
				EnumMap.EnumMapMember.NativeFieldInfoPtr__value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumMap.EnumMapMember>.NativeClassPtr, "_value");
				EnumMap.EnumMapMember.NativeMethodInfoPtr__ctor_Public_Void_String_String_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumMap.EnumMapMember>.NativeClassPtr, 100666431);
				EnumMap.EnumMapMember.NativeMethodInfoPtr_get_XmlName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumMap.EnumMapMember>.NativeClassPtr, 100666432);
				EnumMap.EnumMapMember.NativeMethodInfoPtr_get_EnumName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumMap.EnumMapMember>.NativeClassPtr, 100666433);
				EnumMap.EnumMapMember.NativeMethodInfoPtr_get_Value_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumMap.EnumMapMember>.NativeClassPtr, 100666434);
			}

			// Token: 0x06002C28 RID: 11304 RVA: 0x000C5BC4 File Offset: 0x000C3DC4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 407840, RefRangeEnd = 407841, XrefRangeStart = 407840, XrefRangeEnd = 407840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EnumMapMember(string xmlName, string enumName, long value)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnumMap.EnumMapMember>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(xmlName);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(enumName);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumMap.EnumMapMember.NativeMethodInfoPtr__ctor_Public_Void_String_String_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000F0F RID: 3855
			// (get) Token: 0x06002C29 RID: 11305 RVA: 0x000C5C30 File Offset: 0x000C3E30
			public unsafe string XmlName
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumMap.EnumMapMember.NativeMethodInfoPtr_get_XmlName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17000F10 RID: 3856
			// (get) Token: 0x06002C2A RID: 11306 RVA: 0x000C5C68 File Offset: 0x000C3E68
			public unsafe string EnumName
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumMap.EnumMapMember.NativeMethodInfoPtr_get_EnumName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17000F11 RID: 3857
			// (get) Token: 0x06002C2B RID: 11307 RVA: 0x000C5CA0 File Offset: 0x000C3EA0
			public unsafe long Value
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumMap.EnumMapMember.NativeMethodInfoPtr_get_Value_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002C2C RID: 11308 RVA: 0x00012F03 File Offset: 0x00011103
			public EnumMapMember(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000F0C RID: 3852
			// (get) Token: 0x06002C2D RID: 11309 RVA: 0x000C5CDC File Offset: 0x000C3EDC
			// (set) Token: 0x06002C2E RID: 11310 RVA: 0x00012F0C File Offset: 0x0001110C
			public unsafe string _xmlName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumMap.EnumMapMember.NativeFieldInfoPtr__xmlName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumMap.EnumMapMember.NativeFieldInfoPtr__xmlName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000F0D RID: 3853
			// (get) Token: 0x06002C2F RID: 11311 RVA: 0x000C5D04 File Offset: 0x000C3F04
			// (set) Token: 0x06002C30 RID: 11312 RVA: 0x00012F2B File Offset: 0x0001112B
			public unsafe string _enumName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumMap.EnumMapMember.NativeFieldInfoPtr__enumName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumMap.EnumMapMember.NativeFieldInfoPtr__enumName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000F0E RID: 3854
			// (get) Token: 0x06002C31 RID: 11313 RVA: 0x000C5D2C File Offset: 0x000C3F2C
			// (set) Token: 0x06002C32 RID: 11314 RVA: 0x00012F4A File Offset: 0x0001114A
			public unsafe long _value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumMap.EnumMapMember.NativeFieldInfoPtr__value);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumMap.EnumMapMember.NativeFieldInfoPtr__value)) = value;
				}
			}

			// Token: 0x0400226F RID: 8815
			private static readonly IntPtr NativeFieldInfoPtr__xmlName;

			// Token: 0x04002270 RID: 8816
			private static readonly IntPtr NativeFieldInfoPtr__enumName;

			// Token: 0x04002271 RID: 8817
			private static readonly IntPtr NativeFieldInfoPtr__value;

			// Token: 0x04002272 RID: 8818
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_Int64_0;

			// Token: 0x04002273 RID: 8819
			private static readonly IntPtr NativeMethodInfoPtr_get_XmlName_Public_get_String_0;

			// Token: 0x04002274 RID: 8820
			private static readonly IntPtr NativeMethodInfoPtr_get_EnumName_Public_get_String_0;

			// Token: 0x04002275 RID: 8821
			private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_Int64_0;
		}
	}
}
