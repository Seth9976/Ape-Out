using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppRewired.ComponentControls.Data
{
	// Token: 0x02000043 RID: 67
	[Serializable]
	public sealed class CustomControllerElementSelector : Object
	{
		// Token: 0x06000525 RID: 1317 RVA: 0x000418A0 File Offset: 0x0003FAA0
		// Note: this type is marked as 'beforefieldinit'.
		static CustomControllerElementSelector()
		{
			Il2CppClassPointerStore<CustomControllerElementSelector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.ComponentControls.Data", "CustomControllerElementSelector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomControllerElementSelector>.NativeClassPtr);
			CustomControllerElementSelector.NativeFieldInfoPtr__elementType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomControllerElementSelector>.NativeClassPtr, "_elementType");
			CustomControllerElementSelector.NativeFieldInfoPtr__selectorType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomControllerElementSelector>.NativeClassPtr, "_selectorType");
			CustomControllerElementSelector.NativeFieldInfoPtr__elementName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomControllerElementSelector>.NativeClassPtr, "_elementName");
			CustomControllerElementSelector.NativeFieldInfoPtr__elementIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomControllerElementSelector>.NativeClassPtr, "_elementIndex");
			CustomControllerElementSelector.NativeFieldInfoPtr__elementId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomControllerElementSelector>.NativeClassPtr, "_elementId");
			CustomControllerElementSelector.NativeFieldInfoPtr_nWCZBTtzOBDSgoegtNyBRywruTh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomControllerElementSelector>.NativeClassPtr, "nWCZBTtzOBDSgoegtNyBRywruTh");
			CustomControllerElementSelector.NativeFieldInfoPtr_tzPBybOlWqbNUGMYhRgUQWGzjKoe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomControllerElementSelector>.NativeClassPtr, "tzPBybOlWqbNUGMYhRgUQWGzjKoe");
			CustomControllerElementSelector.NativeMethodInfoPtr_get_elementType_Public_get_ElementType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerElementSelector>.NativeClassPtr, 100664182);
			CustomControllerElementSelector.NativeMethodInfoPtr_set_elementType_Public_set_Void_ElementType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerElementSelector>.NativeClassPtr, 100664183);
			CustomControllerElementSelector.NativeMethodInfoPtr_get_selectorType_Public_get_SelectorType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerElementSelector>.NativeClassPtr, 100664184);
			CustomControllerElementSelector.NativeMethodInfoPtr_set_selectorType_Public_set_Void_SelectorType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerElementSelector>.NativeClassPtr, 100664185);
			CustomControllerElementSelector.NativeMethodInfoPtr_get_elementName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerElementSelector>.NativeClassPtr, 100664186);
			CustomControllerElementSelector.NativeMethodInfoPtr_set_elementName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerElementSelector>.NativeClassPtr, 100664187);
			CustomControllerElementSelector.NativeMethodInfoPtr_get_elementIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerElementSelector>.NativeClassPtr, 100664188);
			CustomControllerElementSelector.NativeMethodInfoPtr_set_elementIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerElementSelector>.NativeClassPtr, 100664189);
			CustomControllerElementSelector.NativeMethodInfoPtr_get_elementId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerElementSelector>.NativeClassPtr, 100664190);
			CustomControllerElementSelector.NativeMethodInfoPtr_set_elementId_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerElementSelector>.NativeClassPtr, 100664191);
			CustomControllerElementSelector.NativeMethodInfoPtr_get_isAssigned_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerElementSelector>.NativeClassPtr, 100664192);
			CustomControllerElementSelector.NativeMethodInfoPtr_GetElementIndex_Public_Int32_CustomController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerElementSelector>.NativeClassPtr, 100664193);
			CustomControllerElementSelector.NativeMethodInfoPtr_GetSelectorFormattedString_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerElementSelector>.NativeClassPtr, 100664194);
			CustomControllerElementSelector.NativeMethodInfoPtr_oREbLnHCPJlzlyLiPsPTokrbldMf_Private_IList_1_ControllerElementIdentifier_CustomController_ElementType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerElementSelector>.NativeClassPtr, 100664195);
			CustomControllerElementSelector.NativeMethodInfoPtr_ClearCache_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerElementSelector>.NativeClassPtr, 100664196);
			CustomControllerElementSelector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerElementSelector>.NativeClassPtr, 100664197);
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x06000526 RID: 1318 RVA: 0x00041A9C File Offset: 0x0003FC9C
		// (set) Token: 0x06000527 RID: 1319 RVA: 0x00041AD8 File Offset: 0x0003FCD8
		public unsafe CustomControllerElementSelector.ElementType elementType
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 896, RefRangeEnd = 897, XrefRangeStart = 896, XrefRangeEnd = 897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomControllerElementSelector.NativeMethodInfoPtr_get_elementType_Public_get_ElementType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomControllerElementSelector.NativeMethodInfoPtr_set_elementType_Public_set_Void_ElementType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x06000528 RID: 1320 RVA: 0x00041B18 File Offset: 0x0003FD18
		// (set) Token: 0x06000529 RID: 1321 RVA: 0x00041B54 File Offset: 0x0003FD54
		public unsafe CustomControllerElementSelector.SelectorType selectorType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomControllerElementSelector.NativeMethodInfoPtr_get_selectorType_Public_get_SelectorType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomControllerElementSelector.NativeMethodInfoPtr_set_selectorType_Public_set_Void_SelectorType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x0600052A RID: 1322 RVA: 0x00041B94 File Offset: 0x0003FD94
		// (set) Token: 0x0600052B RID: 1323 RVA: 0x00041BCC File Offset: 0x0003FDCC
		public unsafe string elementName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomControllerElementSelector.NativeMethodInfoPtr_get_elementName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomControllerElementSelector.NativeMethodInfoPtr_set_elementName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x0600052C RID: 1324 RVA: 0x00041C10 File Offset: 0x0003FE10
		// (set) Token: 0x0600052D RID: 1325 RVA: 0x00041C4C File Offset: 0x0003FE4C
		public unsafe int elementIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomControllerElementSelector.NativeMethodInfoPtr_get_elementIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomControllerElementSelector.NativeMethodInfoPtr_set_elementIndex_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x0600052E RID: 1326 RVA: 0x00041C8C File Offset: 0x0003FE8C
		// (set) Token: 0x0600052F RID: 1327 RVA: 0x00041CC8 File Offset: 0x0003FEC8
		public unsafe int elementId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomControllerElementSelector.NativeMethodInfoPtr_get_elementId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomControllerElementSelector.NativeMethodInfoPtr_set_elementId_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x06000530 RID: 1328 RVA: 0x00041D08 File Offset: 0x0003FF08
		public unsafe bool isAssigned
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 245977, RefRangeEnd = 245979, XrefRangeStart = 245977, XrefRangeEnd = 245977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomControllerElementSelector.NativeMethodInfoPtr_get_isAssigned_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x00041D44 File Offset: 0x0003FF44
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 246002, RefRangeEnd = 246007, XrefRangeStart = 245979, XrefRangeEnd = 246002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetElementIndex(CustomController customController)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(customController);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomControllerElementSelector.NativeMethodInfoPtr_GetElementIndex_Public_Int32_CustomController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x00041D94 File Offset: 0x0003FF94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246007, XrefRangeEnd = 246025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetSelectorFormattedString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomControllerElementSelector.NativeMethodInfoPtr_GetSelectorFormattedString_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x00041DCC File Offset: 0x0003FFCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246025, XrefRangeEnd = 246033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IList<ControllerElementIdentifier> oREbLnHCPJlzlyLiPsPTokrbldMf(CustomController A_1, CustomControllerElementSelector.ElementType A_2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomControllerElementSelector.NativeMethodInfoPtr_oREbLnHCPJlzlyLiPsPTokrbldMf_Private_IList_1_ControllerElementIdentifier_CustomController_ElementType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<ControllerElementIdentifier>>(intPtr3) : null;
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x00041E2C File Offset: 0x0004002C
		[CallerCount(0)]
		public unsafe void ClearCache()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomControllerElementSelector.NativeMethodInfoPtr_ClearCache_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000535 RID: 1333 RVA: 0x00041E60 File Offset: 0x00040060
		[CallerCount(0)]
		public unsafe CustomControllerElementSelector()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomControllerElementSelector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomControllerElementSelector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000536 RID: 1334 RVA: 0x000039AF File Offset: 0x00001BAF
		public CustomControllerElementSelector(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x06000537 RID: 1335 RVA: 0x00041E9C File Offset: 0x0004009C
		// (set) Token: 0x06000538 RID: 1336 RVA: 0x000039B8 File Offset: 0x00001BB8
		public unsafe CustomControllerElementSelector.ElementType _elementType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomControllerElementSelector.NativeFieldInfoPtr__elementType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomControllerElementSelector.NativeFieldInfoPtr__elementType)) = value;
			}
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x06000539 RID: 1337 RVA: 0x00041EC4 File Offset: 0x000400C4
		// (set) Token: 0x0600053A RID: 1338 RVA: 0x000039D3 File Offset: 0x00001BD3
		public unsafe CustomControllerElementSelector.SelectorType _selectorType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomControllerElementSelector.NativeFieldInfoPtr__selectorType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomControllerElementSelector.NativeFieldInfoPtr__selectorType)) = value;
			}
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x0600053B RID: 1339 RVA: 0x00041EEC File Offset: 0x000400EC
		// (set) Token: 0x0600053C RID: 1340 RVA: 0x000039EE File Offset: 0x00001BEE
		public unsafe string _elementName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomControllerElementSelector.NativeFieldInfoPtr__elementName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomControllerElementSelector.NativeFieldInfoPtr__elementName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x0600053D RID: 1341 RVA: 0x00041F14 File Offset: 0x00040114
		// (set) Token: 0x0600053E RID: 1342 RVA: 0x00003A0D File Offset: 0x00001C0D
		public unsafe int _elementIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomControllerElementSelector.NativeFieldInfoPtr__elementIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomControllerElementSelector.NativeFieldInfoPtr__elementIndex)) = value;
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x0600053F RID: 1343 RVA: 0x00041F3C File Offset: 0x0004013C
		// (set) Token: 0x06000540 RID: 1344 RVA: 0x00003A28 File Offset: 0x00001C28
		public unsafe int _elementId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomControllerElementSelector.NativeFieldInfoPtr__elementId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomControllerElementSelector.NativeFieldInfoPtr__elementId)) = value;
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x06000541 RID: 1345 RVA: 0x00041F64 File Offset: 0x00040164
		// (set) Token: 0x06000542 RID: 1346 RVA: 0x00003A43 File Offset: 0x00001C43
		public unsafe int nWCZBTtzOBDSgoegtNyBRywruTh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomControllerElementSelector.NativeFieldInfoPtr_nWCZBTtzOBDSgoegtNyBRywruTh);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomControllerElementSelector.NativeFieldInfoPtr_nWCZBTtzOBDSgoegtNyBRywruTh)) = value;
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x06000543 RID: 1347 RVA: 0x00041F8C File Offset: 0x0004018C
		// (set) Token: 0x06000544 RID: 1348 RVA: 0x00003A5E File Offset: 0x00001C5E
		public unsafe int tzPBybOlWqbNUGMYhRgUQWGzjKoe
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomControllerElementSelector.NativeFieldInfoPtr_tzPBybOlWqbNUGMYhRgUQWGzjKoe);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomControllerElementSelector.NativeFieldInfoPtr_tzPBybOlWqbNUGMYhRgUQWGzjKoe)) = value;
			}
		}

		// Token: 0x04000456 RID: 1110
		private static readonly IntPtr NativeFieldInfoPtr__elementType;

		// Token: 0x04000457 RID: 1111
		private static readonly IntPtr NativeFieldInfoPtr__selectorType;

		// Token: 0x04000458 RID: 1112
		private static readonly IntPtr NativeFieldInfoPtr__elementName;

		// Token: 0x04000459 RID: 1113
		private static readonly IntPtr NativeFieldInfoPtr__elementIndex;

		// Token: 0x0400045A RID: 1114
		private static readonly IntPtr NativeFieldInfoPtr__elementId;

		// Token: 0x0400045B RID: 1115
		private static readonly IntPtr NativeFieldInfoPtr_nWCZBTtzOBDSgoegtNyBRywruTh;

		// Token: 0x0400045C RID: 1116
		private static readonly IntPtr NativeFieldInfoPtr_tzPBybOlWqbNUGMYhRgUQWGzjKoe;

		// Token: 0x0400045D RID: 1117
		private static readonly IntPtr NativeMethodInfoPtr_get_elementType_Public_get_ElementType_0;

		// Token: 0x0400045E RID: 1118
		private static readonly IntPtr NativeMethodInfoPtr_set_elementType_Public_set_Void_ElementType_0;

		// Token: 0x0400045F RID: 1119
		private static readonly IntPtr NativeMethodInfoPtr_get_selectorType_Public_get_SelectorType_0;

		// Token: 0x04000460 RID: 1120
		private static readonly IntPtr NativeMethodInfoPtr_set_selectorType_Public_set_Void_SelectorType_0;

		// Token: 0x04000461 RID: 1121
		private static readonly IntPtr NativeMethodInfoPtr_get_elementName_Public_get_String_0;

		// Token: 0x04000462 RID: 1122
		private static readonly IntPtr NativeMethodInfoPtr_set_elementName_Public_set_Void_String_0;

		// Token: 0x04000463 RID: 1123
		private static readonly IntPtr NativeMethodInfoPtr_get_elementIndex_Public_get_Int32_0;

		// Token: 0x04000464 RID: 1124
		private static readonly IntPtr NativeMethodInfoPtr_set_elementIndex_Public_set_Void_Int32_0;

		// Token: 0x04000465 RID: 1125
		private static readonly IntPtr NativeMethodInfoPtr_get_elementId_Public_get_Int32_0;

		// Token: 0x04000466 RID: 1126
		private static readonly IntPtr NativeMethodInfoPtr_set_elementId_Public_set_Void_Int32_0;

		// Token: 0x04000467 RID: 1127
		private static readonly IntPtr NativeMethodInfoPtr_get_isAssigned_Public_get_Boolean_0;

		// Token: 0x04000468 RID: 1128
		private static readonly IntPtr NativeMethodInfoPtr_GetElementIndex_Public_Int32_CustomController_0;

		// Token: 0x04000469 RID: 1129
		private static readonly IntPtr NativeMethodInfoPtr_GetSelectorFormattedString_Public_String_0;

		// Token: 0x0400046A RID: 1130
		private static readonly IntPtr NativeMethodInfoPtr_oREbLnHCPJlzlyLiPsPTokrbldMf_Private_IList_1_ControllerElementIdentifier_CustomController_ElementType_0;

		// Token: 0x0400046B RID: 1131
		private static readonly IntPtr NativeMethodInfoPtr_ClearCache_Public_Void_0;

		// Token: 0x0400046C RID: 1132
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200023D RID: 573
		[OriginalName("Rewired_Core.dll", "", "ElementType")]
		public enum ElementType
		{
			// Token: 0x04002FCB RID: 12235
			Axis,
			// Token: 0x04002FCC RID: 12236
			Button
		}

		// Token: 0x0200023E RID: 574
		[OriginalName("Rewired_Core.dll", "", "SelectorType")]
		public enum SelectorType
		{
			// Token: 0x04002FCE RID: 12238
			Name,
			// Token: 0x04002FCF RID: 12239
			Index,
			// Token: 0x04002FD0 RID: 12240
			Id
		}
	}
}
