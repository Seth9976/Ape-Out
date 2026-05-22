using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000E6 RID: 230
	public class XmlTypeMapMember : Object
	{
		// Token: 0x0600138A RID: 5002 RVA: 0x00067CC0 File Offset: 0x00065EC0
		// Note: this type is marked as 'beforefieldinit'.
		static XmlTypeMapMember()
		{
			Il2CppClassPointerStore<XmlTypeMapMember>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlTypeMapMember");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlTypeMapMember>.NativeClassPtr);
			XmlTypeMapMember.NativeFieldInfoPtr__name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTypeMapMember>.NativeClassPtr, "_name");
			XmlTypeMapMember.NativeFieldInfoPtr__index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTypeMapMember>.NativeClassPtr, "_index");
			XmlTypeMapMember.NativeFieldInfoPtr__globalIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTypeMapMember>.NativeClassPtr, "_globalIndex");
			XmlTypeMapMember.NativeFieldInfoPtr__specifiedGlobalIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTypeMapMember>.NativeClassPtr, "_specifiedGlobalIndex");
			XmlTypeMapMember.NativeFieldInfoPtr__typeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTypeMapMember>.NativeClassPtr, "_typeData");
			XmlTypeMapMember.NativeFieldInfoPtr__member = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTypeMapMember>.NativeClassPtr, "_member");
			XmlTypeMapMember.NativeFieldInfoPtr__specifiedMember = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTypeMapMember>.NativeClassPtr, "_specifiedMember");
			XmlTypeMapMember.NativeFieldInfoPtr__shouldSerialize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTypeMapMember>.NativeClassPtr, "_shouldSerialize");
			XmlTypeMapMember.NativeFieldInfoPtr__defaultValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTypeMapMember>.NativeClassPtr, "_defaultValue");
			XmlTypeMapMember.NativeFieldInfoPtr__flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTypeMapMember>.NativeClassPtr, "_flags");
			XmlTypeMapMember.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMember>.NativeClassPtr, 100666337);
			XmlTypeMapMember.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMember>.NativeClassPtr, 100666338);
			XmlTypeMapMember.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMember>.NativeClassPtr, 100666339);
			XmlTypeMapMember.NativeMethodInfoPtr_get_DefaultValue_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMember>.NativeClassPtr, 100666340);
			XmlTypeMapMember.NativeMethodInfoPtr_set_DefaultValue_Public_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMember>.NativeClassPtr, 100666341);
			XmlTypeMapMember.NativeMethodInfoPtr_GetValue_Public_Static_Object_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMember>.NativeClassPtr, 100666342);
			XmlTypeMapMember.NativeMethodInfoPtr_GetValue_Public_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMember>.NativeClassPtr, 100666343);
			XmlTypeMapMember.NativeMethodInfoPtr_InitMember_Private_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMember>.NativeClassPtr, 100666344);
			XmlTypeMapMember.NativeMethodInfoPtr_get_TypeData_Public_get_TypeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMember>.NativeClassPtr, 100666345);
			XmlTypeMapMember.NativeMethodInfoPtr_set_TypeData_Public_set_Void_TypeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMember>.NativeClassPtr, 100666346);
			XmlTypeMapMember.NativeMethodInfoPtr_get_Index_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMember>.NativeClassPtr, 100666347);
			XmlTypeMapMember.NativeMethodInfoPtr_set_Index_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMember>.NativeClassPtr, 100666348);
			XmlTypeMapMember.NativeMethodInfoPtr_get_GlobalIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMember>.NativeClassPtr, 100666349);
			XmlTypeMapMember.NativeMethodInfoPtr_set_GlobalIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMember>.NativeClassPtr, 100666350);
			XmlTypeMapMember.NativeMethodInfoPtr_get_IsOptionalValueType_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMember>.NativeClassPtr, 100666351);
			XmlTypeMapMember.NativeMethodInfoPtr_set_IsOptionalValueType_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMember>.NativeClassPtr, 100666352);
			XmlTypeMapMember.NativeMethodInfoPtr_get_IsReturnValue_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMember>.NativeClassPtr, 100666353);
			XmlTypeMapMember.NativeMethodInfoPtr_set_IsReturnValue_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMember>.NativeClassPtr, 100666354);
			XmlTypeMapMember.NativeMethodInfoPtr_CheckOptionalValueType_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMember>.NativeClassPtr, 100666355);
			XmlTypeMapMember.NativeMethodInfoPtr_GetValueSpecified_Public_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMember>.NativeClassPtr, 100666356);
		}

		// Token: 0x0600138B RID: 5003 RVA: 0x00067F48 File Offset: 0x00066148
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 407408, RefRangeEnd = 407422, XrefRangeStart = 407404, XrefRangeEnd = 407408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTypeMapMember()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTypeMapMember>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMember.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x0600138C RID: 5004 RVA: 0x00067F84 File Offset: 0x00066184
		// (set) Token: 0x0600138D RID: 5005 RVA: 0x00067FBC File Offset: 0x000661BC
		public unsafe string Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMember.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(79)]
			[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMember.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700067F RID: 1663
		// (get) Token: 0x0600138E RID: 5006 RVA: 0x00068000 File Offset: 0x00066200
		// (set) Token: 0x0600138F RID: 5007 RVA: 0x00068040 File Offset: 0x00066240
		public unsafe Object DefaultValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMember.NativeMethodInfoPtr_get_DefaultValue_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 14747, RefRangeEnd = 14763, XrefRangeStart = 14747, XrefRangeEnd = 14763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMember.NativeMethodInfoPtr_set_DefaultValue_Public_set_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001390 RID: 5008 RVA: 0x00068084 File Offset: 0x00066284
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 407432, RefRangeEnd = 407434, XrefRangeStart = 407422, XrefRangeEnd = 407432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object GetValue(Object ob, string name)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ob);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMember.NativeMethodInfoPtr_GetValue_Public_Static_Object_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001391 RID: 5009 RVA: 0x000680DC File Offset: 0x000662DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 407448, RefRangeEnd = 407450, XrefRangeStart = 407434, XrefRangeEnd = 407448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetValue(Object ob)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ob);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMember.NativeMethodInfoPtr_GetValue_Public_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001392 RID: 5010 RVA: 0x0006812C File Offset: 0x0006632C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 407470, RefRangeEnd = 407472, XrefRangeStart = 407450, XrefRangeEnd = 407470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitMember(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMember.NativeMethodInfoPtr_InitMember_Private_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000680 RID: 1664
		// (get) Token: 0x06001393 RID: 5011 RVA: 0x00068170 File Offset: 0x00066370
		// (set) Token: 0x06001394 RID: 5012 RVA: 0x000681B0 File Offset: 0x000663B0
		public unsafe TypeData TypeData
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 13519, RefRangeEnd = 13522, XrefRangeStart = 13519, XrefRangeEnd = 13522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMember.NativeMethodInfoPtr_get_TypeData_Public_get_TypeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TypeData>(intPtr3) : null;
			}
			[CallerCount(38)]
			[CachedScanResults(RefRangeStart = 17089, RefRangeEnd = 17127, XrefRangeStart = 17089, XrefRangeEnd = 17127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMember.NativeMethodInfoPtr_set_TypeData_Public_set_Void_TypeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000681 RID: 1665
		// (get) Token: 0x06001395 RID: 5013 RVA: 0x000681F4 File Offset: 0x000663F4
		// (set) Token: 0x06001396 RID: 5014 RVA: 0x00068230 File Offset: 0x00066430
		public unsafe int Index
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMember.NativeMethodInfoPtr_get_Index_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMember.NativeMethodInfoPtr_set_Index_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x06001397 RID: 5015 RVA: 0x00068270 File Offset: 0x00066470
		// (set) Token: 0x06001398 RID: 5016 RVA: 0x000682AC File Offset: 0x000664AC
		public unsafe int GlobalIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMember.NativeMethodInfoPtr_get_GlobalIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMember.NativeMethodInfoPtr_set_GlobalIndex_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x06001399 RID: 5017 RVA: 0x000682EC File Offset: 0x000664EC
		// (set) Token: 0x0600139A RID: 5018 RVA: 0x00068328 File Offset: 0x00066528
		public unsafe bool IsOptionalValueType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMember.NativeMethodInfoPtr_get_IsOptionalValueType_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMember.NativeMethodInfoPtr_set_IsOptionalValueType_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000684 RID: 1668
		// (get) Token: 0x0600139B RID: 5019 RVA: 0x00068368 File Offset: 0x00066568
		// (set) Token: 0x0600139C RID: 5020 RVA: 0x000683A4 File Offset: 0x000665A4
		public unsafe bool IsReturnValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMember.NativeMethodInfoPtr_get_IsReturnValue_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMember.NativeMethodInfoPtr_set_IsReturnValue_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600139D RID: 5021 RVA: 0x000683E4 File Offset: 0x000665E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 407480, RefRangeEnd = 407481, XrefRangeStart = 407472, XrefRangeEnd = 407480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckOptionalValueType(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMember.NativeMethodInfoPtr_CheckOptionalValueType_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600139E RID: 5022 RVA: 0x00068428 File Offset: 0x00066628
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 407505, RefRangeEnd = 407506, XrefRangeStart = 407481, XrefRangeEnd = 407505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetValueSpecified(Object ob)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ob);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMember.NativeMethodInfoPtr_GetValueSpecified_Public_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600139F RID: 5023 RVA: 0x00008AA0 File Offset: 0x00006CA0
		public XmlTypeMapMember(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000674 RID: 1652
		// (get) Token: 0x060013A0 RID: 5024 RVA: 0x00068478 File Offset: 0x00066678
		// (set) Token: 0x060013A1 RID: 5025 RVA: 0x00008AA9 File Offset: 0x00006CA9
		public unsafe string _name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapMember.NativeFieldInfoPtr__name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapMember.NativeFieldInfoPtr__name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000675 RID: 1653
		// (get) Token: 0x060013A2 RID: 5026 RVA: 0x000684A0 File Offset: 0x000666A0
		// (set) Token: 0x060013A3 RID: 5027 RVA: 0x00008AC8 File Offset: 0x00006CC8
		public unsafe int _index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapMember.NativeFieldInfoPtr__index);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapMember.NativeFieldInfoPtr__index)) = value;
			}
		}

		// Token: 0x17000676 RID: 1654
		// (get) Token: 0x060013A4 RID: 5028 RVA: 0x000684C8 File Offset: 0x000666C8
		// (set) Token: 0x060013A5 RID: 5029 RVA: 0x00008AE3 File Offset: 0x00006CE3
		public unsafe int _globalIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapMember.NativeFieldInfoPtr__globalIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapMember.NativeFieldInfoPtr__globalIndex)) = value;
			}
		}

		// Token: 0x17000677 RID: 1655
		// (get) Token: 0x060013A6 RID: 5030 RVA: 0x000684F0 File Offset: 0x000666F0
		// (set) Token: 0x060013A7 RID: 5031 RVA: 0x00008AFE File Offset: 0x00006CFE
		public unsafe int _specifiedGlobalIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapMember.NativeFieldInfoPtr__specifiedGlobalIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapMember.NativeFieldInfoPtr__specifiedGlobalIndex)) = value;
			}
		}

		// Token: 0x17000678 RID: 1656
		// (get) Token: 0x060013A8 RID: 5032 RVA: 0x00068518 File Offset: 0x00066718
		// (set) Token: 0x060013A9 RID: 5033 RVA: 0x00008B19 File Offset: 0x00006D19
		public unsafe TypeData _typeData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapMember.NativeFieldInfoPtr__typeData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TypeData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapMember.NativeFieldInfoPtr__typeData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000679 RID: 1657
		// (get) Token: 0x060013AA RID: 5034 RVA: 0x00068548 File Offset: 0x00066748
		// (set) Token: 0x060013AB RID: 5035 RVA: 0x00008B38 File Offset: 0x00006D38
		public unsafe MemberInfo _member
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapMember.NativeFieldInfoPtr__member);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MemberInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapMember.NativeFieldInfoPtr__member), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700067A RID: 1658
		// (get) Token: 0x060013AC RID: 5036 RVA: 0x00068578 File Offset: 0x00066778
		// (set) Token: 0x060013AD RID: 5037 RVA: 0x00008B57 File Offset: 0x00006D57
		public unsafe MemberInfo _specifiedMember
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapMember.NativeFieldInfoPtr__specifiedMember);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MemberInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapMember.NativeFieldInfoPtr__specifiedMember), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700067B RID: 1659
		// (get) Token: 0x060013AE RID: 5038 RVA: 0x000685A8 File Offset: 0x000667A8
		// (set) Token: 0x060013AF RID: 5039 RVA: 0x00008B76 File Offset: 0x00006D76
		public unsafe MethodInfo _shouldSerialize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapMember.NativeFieldInfoPtr__shouldSerialize);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapMember.NativeFieldInfoPtr__shouldSerialize), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x060013B0 RID: 5040 RVA: 0x000685D8 File Offset: 0x000667D8
		// (set) Token: 0x060013B1 RID: 5041 RVA: 0x00008B95 File Offset: 0x00006D95
		public unsafe Object _defaultValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapMember.NativeFieldInfoPtr__defaultValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapMember.NativeFieldInfoPtr__defaultValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x060013B2 RID: 5042 RVA: 0x00068608 File Offset: 0x00066808
		// (set) Token: 0x060013B3 RID: 5043 RVA: 0x00008BB4 File Offset: 0x00006DB4
		public unsafe int _flags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapMember.NativeFieldInfoPtr__flags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapMember.NativeFieldInfoPtr__flags)) = value;
			}
		}

		// Token: 0x04000F29 RID: 3881
		private static readonly IntPtr NativeFieldInfoPtr__name;

		// Token: 0x04000F2A RID: 3882
		private static readonly IntPtr NativeFieldInfoPtr__index;

		// Token: 0x04000F2B RID: 3883
		private static readonly IntPtr NativeFieldInfoPtr__globalIndex;

		// Token: 0x04000F2C RID: 3884
		private static readonly IntPtr NativeFieldInfoPtr__specifiedGlobalIndex;

		// Token: 0x04000F2D RID: 3885
		private static readonly IntPtr NativeFieldInfoPtr__typeData;

		// Token: 0x04000F2E RID: 3886
		private static readonly IntPtr NativeFieldInfoPtr__member;

		// Token: 0x04000F2F RID: 3887
		private static readonly IntPtr NativeFieldInfoPtr__specifiedMember;

		// Token: 0x04000F30 RID: 3888
		private static readonly IntPtr NativeFieldInfoPtr__shouldSerialize;

		// Token: 0x04000F31 RID: 3889
		private static readonly IntPtr NativeFieldInfoPtr__defaultValue;

		// Token: 0x04000F32 RID: 3890
		private static readonly IntPtr NativeFieldInfoPtr__flags;

		// Token: 0x04000F33 RID: 3891
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000F34 RID: 3892
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x04000F35 RID: 3893
		private static readonly IntPtr NativeMethodInfoPtr_set_Name_Public_set_Void_String_0;

		// Token: 0x04000F36 RID: 3894
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultValue_Public_get_Object_0;

		// Token: 0x04000F37 RID: 3895
		private static readonly IntPtr NativeMethodInfoPtr_set_DefaultValue_Public_set_Void_Object_0;

		// Token: 0x04000F38 RID: 3896
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Static_Object_Object_String_0;

		// Token: 0x04000F39 RID: 3897
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Object_Object_0;

		// Token: 0x04000F3A RID: 3898
		private static readonly IntPtr NativeMethodInfoPtr_InitMember_Private_Void_Type_0;

		// Token: 0x04000F3B RID: 3899
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeData_Public_get_TypeData_0;

		// Token: 0x04000F3C RID: 3900
		private static readonly IntPtr NativeMethodInfoPtr_set_TypeData_Public_set_Void_TypeData_0;

		// Token: 0x04000F3D RID: 3901
		private static readonly IntPtr NativeMethodInfoPtr_get_Index_Public_get_Int32_0;

		// Token: 0x04000F3E RID: 3902
		private static readonly IntPtr NativeMethodInfoPtr_set_Index_Public_set_Void_Int32_0;

		// Token: 0x04000F3F RID: 3903
		private static readonly IntPtr NativeMethodInfoPtr_get_GlobalIndex_Public_get_Int32_0;

		// Token: 0x04000F40 RID: 3904
		private static readonly IntPtr NativeMethodInfoPtr_set_GlobalIndex_Public_set_Void_Int32_0;

		// Token: 0x04000F41 RID: 3905
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOptionalValueType_Public_get_Boolean_0;

		// Token: 0x04000F42 RID: 3906
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOptionalValueType_Public_set_Void_Boolean_0;

		// Token: 0x04000F43 RID: 3907
		private static readonly IntPtr NativeMethodInfoPtr_get_IsReturnValue_Public_get_Boolean_0;

		// Token: 0x04000F44 RID: 3908
		private static readonly IntPtr NativeMethodInfoPtr_set_IsReturnValue_Public_set_Void_Boolean_0;

		// Token: 0x04000F45 RID: 3909
		private static readonly IntPtr NativeMethodInfoPtr_CheckOptionalValueType_Public_Void_Type_0;

		// Token: 0x04000F46 RID: 3910
		private static readonly IntPtr NativeMethodInfoPtr_GetValueSpecified_Public_Boolean_Object_0;
	}
}
