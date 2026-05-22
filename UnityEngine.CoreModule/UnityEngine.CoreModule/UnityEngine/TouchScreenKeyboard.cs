using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000100 RID: 256
	public class TouchScreenKeyboard : Object
	{
		// Token: 0x06001580 RID: 5504 RVA: 0x00054080 File Offset: 0x00052280
		// Note: this type is marked as 'beforefieldinit'.
		static TouchScreenKeyboard()
		{
			Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "TouchScreenKeyboard");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr);
			TouchScreenKeyboard.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, "m_Ptr");
			TouchScreenKeyboard.NativeFieldInfoPtr__disableInPlaceEditing_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, "<disableInPlaceEditing>k__BackingField");
			TouchScreenKeyboard.NativeMethodInfoPtr_Internal_Destroy_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100665142);
			TouchScreenKeyboard.NativeMethodInfoPtr_Destroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100665143);
			TouchScreenKeyboard.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100665144);
			TouchScreenKeyboard.NativeMethodInfoPtr__ctor_Public_Void_String_TouchScreenKeyboardType_Boolean_Boolean_Boolean_Boolean_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100665145);
			TouchScreenKeyboard.NativeMethodInfoPtr_TouchScreenKeyboard_InternalConstructorHelper_Private_Static_IntPtr_byref_TouchScreenKeyboard_InternalConstructorHelperArguments_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100665146);
			TouchScreenKeyboard.NativeMethodInfoPtr_get_isSupported_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100665147);
			TouchScreenKeyboard.NativeMethodInfoPtr_get_disableInPlaceEditing_Internal_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100665148);
			TouchScreenKeyboard.NativeMethodInfoPtr_get_isInPlaceEditingAllowed_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100665149);
			TouchScreenKeyboard.NativeMethodInfoPtr_get_isRequiredToForceOpen_Internal_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100665150);
			TouchScreenKeyboard.NativeMethodInfoPtr_IsRequiredToForceOpen_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100665151);
			TouchScreenKeyboard.NativeMethodInfoPtr_Open_Public_Static_TouchScreenKeyboard_String_TouchScreenKeyboardType_Boolean_Boolean_Boolean_Boolean_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100665152);
			TouchScreenKeyboard.NativeMethodInfoPtr_Open_Public_Static_TouchScreenKeyboard_String_TouchScreenKeyboardType_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100665153);
			TouchScreenKeyboard.NativeMethodInfoPtr_get_text_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100665154);
			TouchScreenKeyboard.NativeMethodInfoPtr_set_text_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100665155);
			TouchScreenKeyboard.NativeMethodInfoPtr_set_hideInput_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100665156);
			TouchScreenKeyboard.NativeMethodInfoPtr_get_active_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100665157);
			TouchScreenKeyboard.NativeMethodInfoPtr_set_active_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100665158);
			TouchScreenKeyboard.NativeMethodInfoPtr_get_status_Public_get_Status_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100665159);
			TouchScreenKeyboard.NativeMethodInfoPtr_set_characterLimit_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100665160);
			TouchScreenKeyboard.NativeMethodInfoPtr_get_canGetSelection_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100665161);
			TouchScreenKeyboard.NativeMethodInfoPtr_get_canSetSelection_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100665162);
			TouchScreenKeyboard.NativeMethodInfoPtr_get_selection_Public_get_RangeInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100665163);
			TouchScreenKeyboard.NativeMethodInfoPtr_set_selection_Public_set_Void_RangeInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100665164);
			TouchScreenKeyboard.NativeMethodInfoPtr_GetSelection_Private_Static_Void_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100665165);
			TouchScreenKeyboard.NativeMethodInfoPtr_SetSelection_Private_Static_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100665166);
			TouchScreenKeyboard.IsInPlaceEditingAllowedDelegateField = IL2CPP.ResolveICall<TouchScreenKeyboard.IsInPlaceEditingAllowedDelegate>("UnityEngine.TouchScreenKeyboard::IsInPlaceEditingAllowed");
			TouchScreenKeyboard.get_hideInputDelegateField = IL2CPP.ResolveICall<TouchScreenKeyboard.get_hideInputDelegate>("UnityEngine.TouchScreenKeyboard::get_hideInput");
			TouchScreenKeyboard.GetDoneDelegateField = IL2CPP.ResolveICall<TouchScreenKeyboard.GetDoneDelegate>("UnityEngine.TouchScreenKeyboard::GetDone");
			TouchScreenKeyboard.GetWasCanceledDelegateField = IL2CPP.ResolveICall<TouchScreenKeyboard.GetWasCanceledDelegate>("UnityEngine.TouchScreenKeyboard::GetWasCanceled");
			TouchScreenKeyboard.get_characterLimitDelegateField = IL2CPP.ResolveICall<TouchScreenKeyboard.get_characterLimitDelegate>("UnityEngine.TouchScreenKeyboard::get_characterLimit");
			TouchScreenKeyboard.get_typeDelegateField = IL2CPP.ResolveICall<TouchScreenKeyboard.get_typeDelegate>("UnityEngine.TouchScreenKeyboard::get_type");
			TouchScreenKeyboard.get_visibleDelegateField = IL2CPP.ResolveICall<TouchScreenKeyboard.get_visibleDelegate>("UnityEngine.TouchScreenKeyboard::get_visible");
			TouchScreenKeyboard.get_area_InjectedDelegateField = IL2CPP.ResolveICall<TouchScreenKeyboard.get_area_InjectedDelegate>("UnityEngine.TouchScreenKeyboard::get_area_Injected");
		}

		// Token: 0x06001581 RID: 5505 RVA: 0x00054344 File Offset: 0x00052544
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498701, XrefRangeEnd = 498705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_Destroy(IntPtr ptr)
		{
			checked
			{
				IntPtr* ptr2 = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_Internal_Destroy_Private_Static_Void_IntPtr_0, 0, (void**)ptr2, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001582 RID: 5506 RVA: 0x00054378 File Offset: 0x00052578
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498705, XrefRangeEnd = 498714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_Destroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001583 RID: 5507 RVA: 0x000543AC File Offset: 0x000525AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498714, XrefRangeEnd = 498722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchScreenKeyboard.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001584 RID: 5508 RVA: 0x000543E8 File Offset: 0x000525E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498722, XrefRangeEnd = 498738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TouchScreenKeyboard(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder, int characterLimit)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keyboardType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autocorrection;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref multiline;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref secure;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alert;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(textPlaceholder);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref characterLimit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr__ctor_Public_Void_String_TouchScreenKeyboardType_Boolean_Boolean_Boolean_Boolean_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001585 RID: 5509 RVA: 0x0005449C File Offset: 0x0005269C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498738, XrefRangeEnd = 498742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr TouchScreenKeyboard_InternalConstructorHelper(ref TouchScreenKeyboard_InternalConstructorHelperArguments arguments, string text, string textPlaceholder)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &arguments;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(text);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(textPlaceholder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_TouchScreenKeyboard_InternalConstructorHelper_Private_Static_IntPtr_byref_TouchScreenKeyboard_InternalConstructorHelperArguments_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x06001586 RID: 5510 RVA: 0x00054500 File Offset: 0x00052700
		public unsafe static bool isSupported
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 498744, RefRangeEnd = 498758, XrefRangeStart = 498742, XrefRangeEnd = 498744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_get_isSupported_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x06001587 RID: 5511 RVA: 0x00054530 File Offset: 0x00052730
		// (set) Token: 0x0600159F RID: 5535 RVA: 0x0000BD82 File Offset: 0x00009F82
		public unsafe static bool disableInPlaceEditing
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498758, XrefRangeEnd = 498760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_get_disableInPlaceEditing_Internal_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				TouchScreenKeyboard._disableInPlaceEditing_k__BackingField = value;
			}
		}

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x06001588 RID: 5512 RVA: 0x00054560 File Offset: 0x00052760
		public unsafe static bool isInPlaceEditingAllowed
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498760, XrefRangeEnd = 498761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_get_isInPlaceEditingAllowed_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x06001589 RID: 5513 RVA: 0x00054590 File Offset: 0x00052790
		public unsafe static bool isRequiredToForceOpen
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498761, XrefRangeEnd = 498765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_get_isRequiredToForceOpen_Internal_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600158A RID: 5514 RVA: 0x000545C0 File Offset: 0x000527C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsRequiredToForceOpen()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_IsRequiredToForceOpen_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600158B RID: 5515 RVA: 0x000545F0 File Offset: 0x000527F0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 498784, RefRangeEnd = 498787, XrefRangeStart = 498765, XrefRangeEnd = 498784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder, int characterLimit)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keyboardType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autocorrection;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref multiline;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref secure;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alert;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(textPlaceholder);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref characterLimit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_Open_Public_Static_TouchScreenKeyboard_String_TouchScreenKeyboardType_Boolean_Boolean_Boolean_Boolean_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TouchScreenKeyboard>(intPtr3) : null;
		}

		// Token: 0x0600158C RID: 5516 RVA: 0x0005469C File Offset: 0x0005289C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 498790, RefRangeEnd = 498792, XrefRangeStart = 498787, XrefRangeEnd = 498790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keyboardType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autocorrection;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref multiline;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref secure;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_Open_Public_Static_TouchScreenKeyboard_String_TouchScreenKeyboardType_Boolean_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TouchScreenKeyboard>(intPtr3) : null;
		}

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x0600158D RID: 5517 RVA: 0x00054718 File Offset: 0x00052918
		// (set) Token: 0x0600158E RID: 5518 RVA: 0x00054750 File Offset: 0x00052950
		public unsafe string text
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 498796, RefRangeEnd = 498798, XrefRangeStart = 498792, XrefRangeEnd = 498796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_get_text_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 498802, RefRangeEnd = 498808, XrefRangeStart = 498798, XrefRangeEnd = 498802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_set_text_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x060015A7 RID: 5543 RVA: 0x0000BD96 File Offset: 0x00009F96
		// (set) Token: 0x0600158F RID: 5519 RVA: 0x00054794 File Offset: 0x00052994
		public unsafe static bool hideInput
		{
			get
			{
				return TouchScreenKeyboard.get_hideInputDelegateField();
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 498812, RefRangeEnd = 498814, XrefRangeStart = 498808, XrefRangeEnd = 498812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_set_hideInput_Public_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x06001590 RID: 5520 RVA: 0x000547C8 File Offset: 0x000529C8
		// (set) Token: 0x06001591 RID: 5521 RVA: 0x00054804 File Offset: 0x00052A04
		public unsafe bool active
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 498818, RefRangeEnd = 498824, XrefRangeStart = 498814, XrefRangeEnd = 498818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_get_active_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 498828, RefRangeEnd = 498835, XrefRangeStart = 498824, XrefRangeEnd = 498828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_set_active_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x06001592 RID: 5522 RVA: 0x00054844 File Offset: 0x00052A44
		public unsafe TouchScreenKeyboard.Status status
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498835, XrefRangeEnd = 498839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_get_status_Public_get_Status_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x060015AC RID: 5548 RVA: 0x0000BDBC File Offset: 0x00009FBC
		// (set) Token: 0x06001593 RID: 5523 RVA: 0x00054880 File Offset: 0x00052A80
		public unsafe int characterLimit
		{
			get
			{
				return TouchScreenKeyboard.get_characterLimitDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 498843, RefRangeEnd = 498845, XrefRangeStart = 498839, XrefRangeEnd = 498843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_set_characterLimit_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x06001594 RID: 5524 RVA: 0x000548C0 File Offset: 0x00052AC0
		public unsafe bool canGetSelection
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498845, XrefRangeEnd = 498849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_get_canGetSelection_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x06001595 RID: 5525 RVA: 0x000548FC File Offset: 0x00052AFC
		public unsafe bool canSetSelection
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498849, XrefRangeEnd = 498853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_get_canSetSelection_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x06001596 RID: 5526 RVA: 0x00054938 File Offset: 0x00052B38
		// (set) Token: 0x06001597 RID: 5527 RVA: 0x00054974 File Offset: 0x00052B74
		public unsafe RangeInt selection
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498853, XrefRangeEnd = 498855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_get_selection_Public_get_RangeInt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 498871, RefRangeEnd = 498874, XrefRangeStart = 498855, XrefRangeEnd = 498871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_set_selection_Public_set_Void_RangeInt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001598 RID: 5528 RVA: 0x000549B4 File Offset: 0x00052BB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498874, XrefRangeEnd = 498878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetSelection(out int start, out int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_GetSelection_Private_Static_Void_byref_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001599 RID: 5529 RVA: 0x000549F4 File Offset: 0x00052BF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498878, XrefRangeEnd = 498882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetSelection(int start, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_SetSelection_Private_Static_Void_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600159A RID: 5530 RVA: 0x0000BD50 File Offset: 0x00009F50
		public TouchScreenKeyboard(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x0600159B RID: 5531 RVA: 0x00054A34 File Offset: 0x00052C34
		// (set) Token: 0x0600159C RID: 5532 RVA: 0x0000BD59 File Offset: 0x00009F59
		public unsafe IntPtr m_Ptr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchScreenKeyboard.NativeFieldInfoPtr_m_Ptr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchScreenKeyboard.NativeFieldInfoPtr_m_Ptr)) = value;
			}
		}

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x0600159D RID: 5533 RVA: 0x00054A5C File Offset: 0x00052C5C
		// (set) Token: 0x0600159E RID: 5534 RVA: 0x0000BD74 File Offset: 0x00009F74
		public unsafe static bool _disableInPlaceEditing_k__BackingField
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(TouchScreenKeyboard.NativeFieldInfoPtr__disableInPlaceEditing_k__BackingField, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TouchScreenKeyboard.NativeFieldInfoPtr__disableInPlaceEditing_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x060015A0 RID: 5536 RVA: 0x0000BD8A File Offset: 0x00009F8A
		public static bool IsInPlaceEditingAllowed()
		{
			return TouchScreenKeyboard.IsInPlaceEditingAllowedDelegateField();
		}

		// Token: 0x060015A1 RID: 5537 RVA: 0x00054A78 File Offset: 0x00052C78
		public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder)
		{
			int num = 0;
			return TouchScreenKeyboard.Open(text, keyboardType, autocorrection, multiline, secure, alert, textPlaceholder, num);
		}

		// Token: 0x060015A2 RID: 5538 RVA: 0x00054A9C File Offset: 0x00052C9C
		public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert)
		{
			int num = 0;
			string text2 = "";
			return TouchScreenKeyboard.Open(text, keyboardType, autocorrection, multiline, secure, alert, text2, num);
		}

		// Token: 0x060015A3 RID: 5539 RVA: 0x00054AC8 File Offset: 0x00052CC8
		public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline)
		{
			int num = 0;
			string text2 = "";
			bool flag = false;
			bool flag2 = false;
			return TouchScreenKeyboard.Open(text, keyboardType, autocorrection, multiline, flag2, flag, text2, num);
		}

		// Token: 0x060015A4 RID: 5540 RVA: 0x00054AF8 File Offset: 0x00052CF8
		public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection)
		{
			int num = 0;
			string text2 = "";
			bool flag = false;
			bool flag2 = false;
			bool flag3 = false;
			return TouchScreenKeyboard.Open(text, keyboardType, autocorrection, flag3, flag2, flag, text2, num);
		}

		// Token: 0x060015A5 RID: 5541 RVA: 0x00054B2C File Offset: 0x00052D2C
		public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType)
		{
			int num = 0;
			string text2 = "";
			bool flag = false;
			bool flag2 = false;
			bool flag3 = false;
			bool flag4 = true;
			return TouchScreenKeyboard.Open(text, keyboardType, flag4, flag3, flag2, flag, text2, num);
		}

		// Token: 0x060015A6 RID: 5542 RVA: 0x00054B64 File Offset: 0x00052D64
		public static TouchScreenKeyboard Open(string text)
		{
			int num = 0;
			string text2 = "";
			bool flag = false;
			bool flag2 = false;
			bool flag3 = false;
			bool flag4 = true;
			TouchScreenKeyboardType touchScreenKeyboardType = TouchScreenKeyboardType.Default;
			return TouchScreenKeyboard.Open(text, touchScreenKeyboardType, flag4, flag3, flag2, flag, text2, num);
		}

		// Token: 0x060015A8 RID: 5544 RVA: 0x0000BDA2 File Offset: 0x00009FA2
		public static bool GetDone(IntPtr ptr)
		{
			return TouchScreenKeyboard.GetDoneDelegateField(ptr);
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x060015A9 RID: 5545 RVA: 0x00054BA0 File Offset: 0x00052DA0
		public bool done
		{
			get
			{
				return TouchScreenKeyboard.GetDone(this.m_Ptr);
			}
		}

		// Token: 0x060015AA RID: 5546 RVA: 0x0000BDAF File Offset: 0x00009FAF
		public static bool GetWasCanceled(IntPtr ptr)
		{
			return TouchScreenKeyboard.GetWasCanceledDelegateField(ptr);
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x060015AB RID: 5547 RVA: 0x00054BC0 File Offset: 0x00052DC0
		public bool wasCanceled
		{
			get
			{
				return TouchScreenKeyboard.GetWasCanceled(this.m_Ptr);
			}
		}

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x060015AD RID: 5549 RVA: 0x0000BDCE File Offset: 0x00009FCE
		public TouchScreenKeyboardType type
		{
			get
			{
				return TouchScreenKeyboard.get_typeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x060015AE RID: 5550 RVA: 0x00054BE0 File Offset: 0x00052DE0
		// (set) Token: 0x060015AF RID: 5551 RVA: 0x0000BDE0 File Offset: 0x00009FE0
		public int targetDisplay
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x060015B0 RID: 5552 RVA: 0x00054BF4 File Offset: 0x00052DF4
		public static Rect area
		{
			get
			{
				Rect rect;
				TouchScreenKeyboard.get_area_Injected(out rect);
				return rect;
			}
		}

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x060015B1 RID: 5553 RVA: 0x0000BDE3 File Offset: 0x00009FE3
		public static bool visible
		{
			get
			{
				return TouchScreenKeyboard.get_visibleDelegateField();
			}
		}

		// Token: 0x060015B2 RID: 5554 RVA: 0x0000BDEF File Offset: 0x00009FEF
		public static void get_area_Injected(out Rect ret)
		{
			TouchScreenKeyboard.get_area_InjectedDelegateField(out ret);
		}

		// Token: 0x040010C8 RID: 4296
		private static readonly IntPtr NativeFieldInfoPtr_m_Ptr;

		// Token: 0x040010C9 RID: 4297
		private static readonly IntPtr NativeFieldInfoPtr__disableInPlaceEditing_k__BackingField;

		// Token: 0x040010CA RID: 4298
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Destroy_Private_Static_Void_IntPtr_0;

		// Token: 0x040010CB RID: 4299
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Private_Void_0;

		// Token: 0x040010CC RID: 4300
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x040010CD RID: 4301
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_TouchScreenKeyboardType_Boolean_Boolean_Boolean_Boolean_String_Int32_0;

		// Token: 0x040010CE RID: 4302
		private static readonly IntPtr NativeMethodInfoPtr_TouchScreenKeyboard_InternalConstructorHelper_Private_Static_IntPtr_byref_TouchScreenKeyboard_InternalConstructorHelperArguments_String_String_0;

		// Token: 0x040010CF RID: 4303
		private static readonly IntPtr NativeMethodInfoPtr_get_isSupported_Public_Static_get_Boolean_0;

		// Token: 0x040010D0 RID: 4304
		private static readonly IntPtr NativeMethodInfoPtr_get_disableInPlaceEditing_Internal_Static_get_Boolean_0;

		// Token: 0x040010D1 RID: 4305
		private static readonly IntPtr NativeMethodInfoPtr_get_isInPlaceEditingAllowed_Public_Static_get_Boolean_0;

		// Token: 0x040010D2 RID: 4306
		private static readonly IntPtr NativeMethodInfoPtr_get_isRequiredToForceOpen_Internal_Static_get_Boolean_0;

		// Token: 0x040010D3 RID: 4307
		private static readonly IntPtr NativeMethodInfoPtr_IsRequiredToForceOpen_Private_Static_Boolean_0;

		// Token: 0x040010D4 RID: 4308
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Static_TouchScreenKeyboard_String_TouchScreenKeyboardType_Boolean_Boolean_Boolean_Boolean_String_Int32_0;

		// Token: 0x040010D5 RID: 4309
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Static_TouchScreenKeyboard_String_TouchScreenKeyboardType_Boolean_Boolean_Boolean_0;

		// Token: 0x040010D6 RID: 4310
		private static readonly IntPtr NativeMethodInfoPtr_get_text_Public_get_String_0;

		// Token: 0x040010D7 RID: 4311
		private static readonly IntPtr NativeMethodInfoPtr_set_text_Public_set_Void_String_0;

		// Token: 0x040010D8 RID: 4312
		private static readonly IntPtr NativeMethodInfoPtr_set_hideInput_Public_Static_set_Void_Boolean_0;

		// Token: 0x040010D9 RID: 4313
		private static readonly IntPtr NativeMethodInfoPtr_get_active_Public_get_Boolean_0;

		// Token: 0x040010DA RID: 4314
		private static readonly IntPtr NativeMethodInfoPtr_set_active_Public_set_Void_Boolean_0;

		// Token: 0x040010DB RID: 4315
		private static readonly IntPtr NativeMethodInfoPtr_get_status_Public_get_Status_0;

		// Token: 0x040010DC RID: 4316
		private static readonly IntPtr NativeMethodInfoPtr_set_characterLimit_Public_set_Void_Int32_0;

		// Token: 0x040010DD RID: 4317
		private static readonly IntPtr NativeMethodInfoPtr_get_canGetSelection_Public_get_Boolean_0;

		// Token: 0x040010DE RID: 4318
		private static readonly IntPtr NativeMethodInfoPtr_get_canSetSelection_Public_get_Boolean_0;

		// Token: 0x040010DF RID: 4319
		private static readonly IntPtr NativeMethodInfoPtr_get_selection_Public_get_RangeInt_0;

		// Token: 0x040010E0 RID: 4320
		private static readonly IntPtr NativeMethodInfoPtr_set_selection_Public_set_Void_RangeInt_0;

		// Token: 0x040010E1 RID: 4321
		private static readonly IntPtr NativeMethodInfoPtr_GetSelection_Private_Static_Void_byref_Int32_byref_Int32_0;

		// Token: 0x040010E2 RID: 4322
		private static readonly IntPtr NativeMethodInfoPtr_SetSelection_Private_Static_Void_Int32_Int32_0;

		// Token: 0x040010E3 RID: 4323
		private static readonly TouchScreenKeyboard.IsInPlaceEditingAllowedDelegate IsInPlaceEditingAllowedDelegateField;

		// Token: 0x040010E4 RID: 4324
		private static readonly TouchScreenKeyboard.get_hideInputDelegate get_hideInputDelegateField;

		// Token: 0x040010E5 RID: 4325
		private static readonly TouchScreenKeyboard.GetDoneDelegate GetDoneDelegateField;

		// Token: 0x040010E6 RID: 4326
		private static readonly TouchScreenKeyboard.GetWasCanceledDelegate GetWasCanceledDelegateField;

		// Token: 0x040010E7 RID: 4327
		private static readonly TouchScreenKeyboard.get_characterLimitDelegate get_characterLimitDelegateField;

		// Token: 0x040010E8 RID: 4328
		private static readonly TouchScreenKeyboard.get_typeDelegate get_typeDelegateField;

		// Token: 0x040010E9 RID: 4329
		private static readonly TouchScreenKeyboard.get_visibleDelegate get_visibleDelegateField;

		// Token: 0x040010EA RID: 4330
		private static readonly TouchScreenKeyboard.get_area_InjectedDelegate get_area_InjectedDelegateField;

		// Token: 0x0200084A RID: 2122
		[OriginalName("UnityEngine.CoreModule.dll", "", "Status")]
		public enum Status
		{
			// Token: 0x04001F36 RID: 7990
			Visible,
			// Token: 0x04001F37 RID: 7991
			Done,
			// Token: 0x04001F38 RID: 7992
			Canceled,
			// Token: 0x04001F39 RID: 7993
			LostFocus
		}

		// Token: 0x0200084B RID: 2123
		public class Android
		{
		}

		// Token: 0x0200084C RID: 2124
		// (Invoke) Token: 0x06002E96 RID: 11926
		private delegate bool IsInPlaceEditingAllowedDelegate();

		// Token: 0x0200084D RID: 2125
		// (Invoke) Token: 0x06002E98 RID: 11928
		private delegate bool get_hideInputDelegate();

		// Token: 0x0200084E RID: 2126
		// (Invoke) Token: 0x06002E9A RID: 11930
		private delegate bool GetDoneDelegate(IntPtr ptr);

		// Token: 0x0200084F RID: 2127
		// (Invoke) Token: 0x06002E9C RID: 11932
		private delegate bool GetWasCanceledDelegate(IntPtr ptr);

		// Token: 0x02000850 RID: 2128
		// (Invoke) Token: 0x06002E9E RID: 11934
		private delegate int get_characterLimitDelegate(IntPtr @this);

		// Token: 0x02000851 RID: 2129
		// (Invoke) Token: 0x06002EA0 RID: 11936
		private delegate TouchScreenKeyboardType get_typeDelegate(IntPtr @this);

		// Token: 0x02000852 RID: 2130
		// (Invoke) Token: 0x06002EA2 RID: 11938
		private delegate bool get_visibleDelegate();

		// Token: 0x02000853 RID: 2131
		// (Invoke) Token: 0x06002EA4 RID: 11940
		private delegate void get_area_InjectedDelegate([Out] IntPtr ret);
	}
}
