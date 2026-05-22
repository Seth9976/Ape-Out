using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Diagnostics
{
	// Token: 0x020004BF RID: 1215
	[Serializable]
	public class StackFrame : Object
	{
		// Token: 0x060048DC RID: 18652 RVA: 0x00151B98 File Offset: 0x0014FD98
		// Note: this type is marked as 'beforefieldinit'.
		static StackFrame()
		{
			Il2CppClassPointerStore<StackFrame>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics", "StackFrame");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StackFrame>.NativeClassPtr);
			StackFrame.NativeFieldInfoPtr_OFFSET_UNKNOWN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackFrame>.NativeClassPtr, "OFFSET_UNKNOWN");
			StackFrame.NativeFieldInfoPtr_ilOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackFrame>.NativeClassPtr, "ilOffset");
			StackFrame.NativeFieldInfoPtr_nativeOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackFrame>.NativeClassPtr, "nativeOffset");
			StackFrame.NativeFieldInfoPtr_methodAddress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackFrame>.NativeClassPtr, "methodAddress");
			StackFrame.NativeFieldInfoPtr_methodIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackFrame>.NativeClassPtr, "methodIndex");
			StackFrame.NativeFieldInfoPtr_methodBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackFrame>.NativeClassPtr, "methodBase");
			StackFrame.NativeFieldInfoPtr_fileName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackFrame>.NativeClassPtr, "fileName");
			StackFrame.NativeFieldInfoPtr_lineNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackFrame>.NativeClassPtr, "lineNumber");
			StackFrame.NativeFieldInfoPtr_columnNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackFrame>.NativeClassPtr, "columnNumber");
			StackFrame.NativeFieldInfoPtr_internalMethodName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackFrame>.NativeClassPtr, "internalMethodName");
			StackFrame.NativeMethodInfoPtr_get_frame_info_Private_Static_Boolean_Int32_Boolean_byref_MethodBase_byref_Int32_byref_Int32_byref_String_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackFrame>.NativeClassPtr, 100674212);
			StackFrame.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackFrame>.NativeClassPtr, 100674213);
			StackFrame.NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackFrame>.NativeClassPtr, 100674214);
			StackFrame.NativeMethodInfoPtr_GetFileLineNumber_Public_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackFrame>.NativeClassPtr, 100674215);
			StackFrame.NativeMethodInfoPtr_GetFileColumnNumber_Public_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackFrame>.NativeClassPtr, 100674216);
			StackFrame.NativeMethodInfoPtr_GetFileName_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackFrame>.NativeClassPtr, 100674217);
			StackFrame.NativeMethodInfoPtr_GetSecureFileName_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackFrame>.NativeClassPtr, 100674218);
			StackFrame.NativeMethodInfoPtr_GetILOffset_Public_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackFrame>.NativeClassPtr, 100674219);
			StackFrame.NativeMethodInfoPtr_GetMethod_Public_Virtual_New_MethodBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackFrame>.NativeClassPtr, 100674220);
			StackFrame.NativeMethodInfoPtr_GetNativeOffset_Public_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackFrame>.NativeClassPtr, 100674221);
			StackFrame.NativeMethodInfoPtr_GetMethodAddress_Internal_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackFrame>.NativeClassPtr, 100674222);
			StackFrame.NativeMethodInfoPtr_GetMethodIndex_Internal_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackFrame>.NativeClassPtr, 100674223);
			StackFrame.NativeMethodInfoPtr_GetInternalMethodName_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackFrame>.NativeClassPtr, 100674224);
			StackFrame.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackFrame>.NativeClassPtr, 100674225);
		}

		// Token: 0x060048DD RID: 18653 RVA: 0x00151DA8 File Offset: 0x0014FFA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233222, XrefRangeEnd = 233223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool get_frame_info(int skip, bool needFileInfo, out MethodBase method, out int iloffset, out int native_offset, out string file, out int line, out int column)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref skip;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref needFileInfo;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &iloffset;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &native_offset;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &line;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &column;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(StackFrame.NativeMethodInfoPtr_get_frame_info_Private_Static_Boolean_Int32_Boolean_byref_MethodBase_byref_Int32_byref_Int32_byref_String_byref_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			method = ((intPtr5 == 0) ? null : new MethodBase(intPtr5));
			file = IL2CPP.Il2CppStringToManaged(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x060048DE RID: 18654 RVA: 0x00151E70 File Offset: 0x00150070
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233223, XrefRangeEnd = 233224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StackFrame()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StackFrame>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackFrame.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048DF RID: 18655 RVA: 0x00151EAC File Offset: 0x001500AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 233225, RefRangeEnd = 233227, XrefRangeStart = 233224, XrefRangeEnd = 233225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StackFrame(int skipFrames, bool fNeedFileInfo)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StackFrame>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref skipFrames;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fNeedFileInfo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackFrame.NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048E0 RID: 18656 RVA: 0x00151F04 File Offset: 0x00150104
		[CallerCount(0)]
		public unsafe virtual int GetFileLineNumber()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StackFrame.NativeMethodInfoPtr_GetFileLineNumber_Public_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060048E1 RID: 18657 RVA: 0x00151F4C File Offset: 0x0015014C
		[CallerCount(0)]
		public unsafe virtual int GetFileColumnNumber()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StackFrame.NativeMethodInfoPtr_GetFileColumnNumber_Public_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060048E2 RID: 18658 RVA: 0x00151F94 File Offset: 0x00150194
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 14016, RefRangeEnd = 14017, XrefRangeStart = 14016, XrefRangeEnd = 14017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetFileName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StackFrame.NativeMethodInfoPtr_GetFileName_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060048E3 RID: 18659 RVA: 0x00151FD8 File Offset: 0x001501D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 233230, RefRangeEnd = 233232, XrefRangeStart = 233227, XrefRangeEnd = 233230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetSecureFileName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackFrame.NativeMethodInfoPtr_GetSecureFileName_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060048E4 RID: 18660 RVA: 0x00152010 File Offset: 0x00150210
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 896, RefRangeEnd = 897, XrefRangeStart = 896, XrefRangeEnd = 897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int GetILOffset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StackFrame.NativeMethodInfoPtr_GetILOffset_Public_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060048E5 RID: 18661 RVA: 0x00152058 File Offset: 0x00150258
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 13519, RefRangeEnd = 13522, XrefRangeStart = 13519, XrefRangeEnd = 13522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual MethodBase GetMethod()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StackFrame.NativeMethodInfoPtr_GetMethod_Public_Virtual_New_MethodBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodBase>(intPtr3) : null;
		}

		// Token: 0x060048E6 RID: 18662 RVA: 0x001520A4 File Offset: 0x001502A4
		[CallerCount(0)]
		public unsafe virtual int GetNativeOffset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StackFrame.NativeMethodInfoPtr_GetNativeOffset_Public_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060048E7 RID: 18663 RVA: 0x001520EC File Offset: 0x001502EC
		[CallerCount(0)]
		public unsafe long GetMethodAddress()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackFrame.NativeMethodInfoPtr_GetMethodAddress_Internal_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060048E8 RID: 18664 RVA: 0x00152128 File Offset: 0x00150328
		[CallerCount(0)]
		public unsafe uint GetMethodIndex()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackFrame.NativeMethodInfoPtr_GetMethodIndex_Internal_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060048E9 RID: 18665 RVA: 0x00152164 File Offset: 0x00150364
		[CallerCount(0)]
		public unsafe string GetInternalMethodName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackFrame.NativeMethodInfoPtr_GetInternalMethodName_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060048EA RID: 18666 RVA: 0x0015219C File Offset: 0x0015039C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233232, XrefRangeEnd = 233270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StackFrame.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060048EB RID: 18667 RVA: 0x0001B373 File Offset: 0x00019573
		public StackFrame(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001276 RID: 4726
		// (get) Token: 0x060048EC RID: 18668 RVA: 0x001521E0 File Offset: 0x001503E0
		// (set) Token: 0x060048ED RID: 18669 RVA: 0x0001B37C File Offset: 0x0001957C
		public unsafe static int OFFSET_UNKNOWN
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(StackFrame.NativeFieldInfoPtr_OFFSET_UNKNOWN, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StackFrame.NativeFieldInfoPtr_OFFSET_UNKNOWN, (void*)(&value));
			}
		}

		// Token: 0x17001277 RID: 4727
		// (get) Token: 0x060048EE RID: 18670 RVA: 0x001521FC File Offset: 0x001503FC
		// (set) Token: 0x060048EF RID: 18671 RVA: 0x0001B38A File Offset: 0x0001958A
		public unsafe int ilOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackFrame.NativeFieldInfoPtr_ilOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackFrame.NativeFieldInfoPtr_ilOffset)) = value;
			}
		}

		// Token: 0x17001278 RID: 4728
		// (get) Token: 0x060048F0 RID: 18672 RVA: 0x00152224 File Offset: 0x00150424
		// (set) Token: 0x060048F1 RID: 18673 RVA: 0x0001B3A5 File Offset: 0x000195A5
		public unsafe int nativeOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackFrame.NativeFieldInfoPtr_nativeOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackFrame.NativeFieldInfoPtr_nativeOffset)) = value;
			}
		}

		// Token: 0x17001279 RID: 4729
		// (get) Token: 0x060048F2 RID: 18674 RVA: 0x0015224C File Offset: 0x0015044C
		// (set) Token: 0x060048F3 RID: 18675 RVA: 0x0001B3C0 File Offset: 0x000195C0
		public unsafe long methodAddress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackFrame.NativeFieldInfoPtr_methodAddress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackFrame.NativeFieldInfoPtr_methodAddress)) = value;
			}
		}

		// Token: 0x1700127A RID: 4730
		// (get) Token: 0x060048F4 RID: 18676 RVA: 0x00152274 File Offset: 0x00150474
		// (set) Token: 0x060048F5 RID: 18677 RVA: 0x0001B3DB File Offset: 0x000195DB
		public unsafe uint methodIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackFrame.NativeFieldInfoPtr_methodIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackFrame.NativeFieldInfoPtr_methodIndex)) = value;
			}
		}

		// Token: 0x1700127B RID: 4731
		// (get) Token: 0x060048F6 RID: 18678 RVA: 0x0015229C File Offset: 0x0015049C
		// (set) Token: 0x060048F7 RID: 18679 RVA: 0x0001B3F6 File Offset: 0x000195F6
		public unsafe MethodBase methodBase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackFrame.NativeFieldInfoPtr_methodBase);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodBase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackFrame.NativeFieldInfoPtr_methodBase), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700127C RID: 4732
		// (get) Token: 0x060048F8 RID: 18680 RVA: 0x001522CC File Offset: 0x001504CC
		// (set) Token: 0x060048F9 RID: 18681 RVA: 0x0001B415 File Offset: 0x00019615
		public unsafe string fileName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackFrame.NativeFieldInfoPtr_fileName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackFrame.NativeFieldInfoPtr_fileName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700127D RID: 4733
		// (get) Token: 0x060048FA RID: 18682 RVA: 0x001522F4 File Offset: 0x001504F4
		// (set) Token: 0x060048FB RID: 18683 RVA: 0x0001B434 File Offset: 0x00019634
		public unsafe int lineNumber
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackFrame.NativeFieldInfoPtr_lineNumber);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackFrame.NativeFieldInfoPtr_lineNumber)) = value;
			}
		}

		// Token: 0x1700127E RID: 4734
		// (get) Token: 0x060048FC RID: 18684 RVA: 0x0015231C File Offset: 0x0015051C
		// (set) Token: 0x060048FD RID: 18685 RVA: 0x0001B44F File Offset: 0x0001964F
		public unsafe int columnNumber
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackFrame.NativeFieldInfoPtr_columnNumber);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackFrame.NativeFieldInfoPtr_columnNumber)) = value;
			}
		}

		// Token: 0x1700127F RID: 4735
		// (get) Token: 0x060048FE RID: 18686 RVA: 0x00152344 File Offset: 0x00150544
		// (set) Token: 0x060048FF RID: 18687 RVA: 0x0001B46A File Offset: 0x0001966A
		public unsafe string internalMethodName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackFrame.NativeFieldInfoPtr_internalMethodName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackFrame.NativeFieldInfoPtr_internalMethodName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04003B0F RID: 15119
		private static readonly IntPtr NativeFieldInfoPtr_OFFSET_UNKNOWN;

		// Token: 0x04003B10 RID: 15120
		private static readonly IntPtr NativeFieldInfoPtr_ilOffset;

		// Token: 0x04003B11 RID: 15121
		private static readonly IntPtr NativeFieldInfoPtr_nativeOffset;

		// Token: 0x04003B12 RID: 15122
		private static readonly IntPtr NativeFieldInfoPtr_methodAddress;

		// Token: 0x04003B13 RID: 15123
		private static readonly IntPtr NativeFieldInfoPtr_methodIndex;

		// Token: 0x04003B14 RID: 15124
		private static readonly IntPtr NativeFieldInfoPtr_methodBase;

		// Token: 0x04003B15 RID: 15125
		private static readonly IntPtr NativeFieldInfoPtr_fileName;

		// Token: 0x04003B16 RID: 15126
		private static readonly IntPtr NativeFieldInfoPtr_lineNumber;

		// Token: 0x04003B17 RID: 15127
		private static readonly IntPtr NativeFieldInfoPtr_columnNumber;

		// Token: 0x04003B18 RID: 15128
		private static readonly IntPtr NativeFieldInfoPtr_internalMethodName;

		// Token: 0x04003B19 RID: 15129
		private static readonly IntPtr NativeMethodInfoPtr_get_frame_info_Private_Static_Boolean_Int32_Boolean_byref_MethodBase_byref_Int32_byref_Int32_byref_String_byref_Int32_byref_Int32_0;

		// Token: 0x04003B1A RID: 15130
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003B1B RID: 15131
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_0;

		// Token: 0x04003B1C RID: 15132
		private static readonly IntPtr NativeMethodInfoPtr_GetFileLineNumber_Public_Virtual_New_Int32_0;

		// Token: 0x04003B1D RID: 15133
		private static readonly IntPtr NativeMethodInfoPtr_GetFileColumnNumber_Public_Virtual_New_Int32_0;

		// Token: 0x04003B1E RID: 15134
		private static readonly IntPtr NativeMethodInfoPtr_GetFileName_Public_Virtual_New_String_0;

		// Token: 0x04003B1F RID: 15135
		private static readonly IntPtr NativeMethodInfoPtr_GetSecureFileName_Internal_String_0;

		// Token: 0x04003B20 RID: 15136
		private static readonly IntPtr NativeMethodInfoPtr_GetILOffset_Public_Virtual_New_Int32_0;

		// Token: 0x04003B21 RID: 15137
		private static readonly IntPtr NativeMethodInfoPtr_GetMethod_Public_Virtual_New_MethodBase_0;

		// Token: 0x04003B22 RID: 15138
		private static readonly IntPtr NativeMethodInfoPtr_GetNativeOffset_Public_Virtual_New_Int32_0;

		// Token: 0x04003B23 RID: 15139
		private static readonly IntPtr NativeMethodInfoPtr_GetMethodAddress_Internal_Int64_0;

		// Token: 0x04003B24 RID: 15140
		private static readonly IntPtr NativeMethodInfoPtr_GetMethodIndex_Internal_UInt32_0;

		// Token: 0x04003B25 RID: 15141
		private static readonly IntPtr NativeMethodInfoPtr_GetInternalMethodName_Internal_String_0;

		// Token: 0x04003B26 RID: 15142
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
