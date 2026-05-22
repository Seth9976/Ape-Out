using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;
using Il2CppSystem.Text;

namespace Il2CppSystem.Diagnostics
{
	// Token: 0x020004C0 RID: 1216
	[Serializable]
	public class StackTrace : Object
	{
		// Token: 0x06004900 RID: 18688 RVA: 0x0015236C File Offset: 0x0015056C
		// Note: this type is marked as 'beforefieldinit'.
		static StackTrace()
		{
			Il2CppClassPointerStore<StackTrace>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics", "StackTrace");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StackTrace>.NativeClassPtr);
			StackTrace.NativeFieldInfoPtr_METHODS_TO_SKIP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackTrace>.NativeClassPtr, "METHODS_TO_SKIP");
			StackTrace.NativeFieldInfoPtr_frames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackTrace>.NativeClassPtr, "frames");
			StackTrace.NativeFieldInfoPtr_captured_traces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackTrace>.NativeClassPtr, "captured_traces");
			StackTrace.NativeFieldInfoPtr_debug_info = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackTrace>.NativeClassPtr, "debug_info");
			StackTrace.NativeFieldInfoPtr_isAotidSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackTrace>.NativeClassPtr, "isAotidSet");
			StackTrace.NativeFieldInfoPtr_aotid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackTrace>.NativeClassPtr, "aotid");
			StackTrace.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackTrace>.NativeClassPtr, 100674226);
			StackTrace.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackTrace>.NativeClassPtr, 100674227);
			StackTrace.NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackTrace>.NativeClassPtr, 100674228);
			StackTrace.NativeMethodInfoPtr_init_frames_Private_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackTrace>.NativeClassPtr, 100674229);
			StackTrace.NativeMethodInfoPtr_get_trace_Private_Static_Il2CppReferenceArray_1_StackFrame_Exception_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackTrace>.NativeClassPtr, 100674230);
			StackTrace.NativeMethodInfoPtr__ctor_Public_Void_Exception_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackTrace>.NativeClassPtr, 100674231);
			StackTrace.NativeMethodInfoPtr__ctor_Public_Void_Exception_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackTrace>.NativeClassPtr, 100674232);
			StackTrace.NativeMethodInfoPtr_get_FrameCount_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackTrace>.NativeClassPtr, 100674233);
			StackTrace.NativeMethodInfoPtr_GetFrame_Public_Virtual_New_StackFrame_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackTrace>.NativeClassPtr, 100674234);
			StackTrace.NativeMethodInfoPtr_GetFrames_Public_Virtual_New_Il2CppReferenceArray_1_StackFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackTrace>.NativeClassPtr, 100674235);
			StackTrace.NativeMethodInfoPtr_GetAotId_Private_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackTrace>.NativeClassPtr, 100674236);
			StackTrace.NativeMethodInfoPtr_AddFrames_Private_Boolean_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackTrace>.NativeClassPtr, 100674237);
			StackTrace.NativeMethodInfoPtr_GetFullNameForStackTrace_Internal_Void_StringBuilder_MethodBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackTrace>.NativeClassPtr, 100674238);
			StackTrace.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackTrace>.NativeClassPtr, 100674239);
			StackTrace.NativeMethodInfoPtr_ToString_Internal_String_TraceFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackTrace>.NativeClassPtr, 100674240);
		}

		// Token: 0x06004901 RID: 18689 RVA: 0x00152540 File Offset: 0x00150740
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233270, XrefRangeEnd = 233271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StackTrace()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StackTrace>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackTrace.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004902 RID: 18690 RVA: 0x0015257C File Offset: 0x0015077C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 233272, RefRangeEnd = 233274, XrefRangeStart = 233271, XrefRangeEnd = 233272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StackTrace(bool fNeedFileInfo)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StackTrace>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fNeedFileInfo;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackTrace.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004903 RID: 18691 RVA: 0x001525C4 File Offset: 0x001507C4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 233275, RefRangeEnd = 233279, XrefRangeStart = 233274, XrefRangeEnd = 233275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StackTrace(int skipFrames, bool fNeedFileInfo)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StackTrace>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref skipFrames;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fNeedFileInfo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackTrace.NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004904 RID: 18692 RVA: 0x0015261C File Offset: 0x0015081C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 233302, RefRangeEnd = 233305, XrefRangeStart = 233279, XrefRangeEnd = 233302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void init_frames(int skipFrames, bool fNeedFileInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref skipFrames;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fNeedFileInfo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackTrace.NativeMethodInfoPtr_init_frames_Private_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004905 RID: 18693 RVA: 0x00152668 File Offset: 0x00150868
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233305, XrefRangeEnd = 233313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<StackFrame> get_trace(Exception e, int skipFrames, bool fNeedFileInfo)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref skipFrames;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fNeedFileInfo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackTrace.NativeMethodInfoPtr_get_trace_Private_Static_Il2CppReferenceArray_1_StackFrame_Exception_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<StackFrame>>(intPtr3) : null;
		}

		// Token: 0x06004906 RID: 18694 RVA: 0x001526C8 File Offset: 0x001508C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233313, XrefRangeEnd = 233314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StackTrace(Exception e, bool fNeedFileInfo)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StackTrace>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fNeedFileInfo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackTrace.NativeMethodInfoPtr__ctor_Public_Void_Exception_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004907 RID: 18695 RVA: 0x00152724 File Offset: 0x00150924
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 233324, RefRangeEnd = 233331, XrefRangeStart = 233314, XrefRangeEnd = 233324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StackTrace(Exception e, int skipFrames, bool fNeedFileInfo)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StackTrace>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref skipFrames;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fNeedFileInfo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackTrace.NativeMethodInfoPtr__ctor_Public_Void_Exception_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001286 RID: 4742
		// (get) Token: 0x06004908 RID: 18696 RVA: 0x0015278C File Offset: 0x0015098C
		public unsafe virtual int FrameCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StackTrace.NativeMethodInfoPtr_get_FrameCount_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004909 RID: 18697 RVA: 0x001527D4 File Offset: 0x001509D4
		[CallerCount(0)]
		public unsafe virtual StackFrame GetFrame(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StackTrace.NativeMethodInfoPtr_GetFrame_Public_Virtual_New_StackFrame_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StackFrame>(intPtr3) : null;
			}
		}

		// Token: 0x0600490A RID: 18698 RVA: 0x0015282C File Offset: 0x00150A2C
		[CallerCount(0)]
		public unsafe virtual Il2CppReferenceArray<StackFrame> GetFrames()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StackTrace.NativeMethodInfoPtr_GetFrames_Public_Virtual_New_Il2CppReferenceArray_1_StackFrame_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<StackFrame>>(intPtr3) : null;
		}

		// Token: 0x0600490B RID: 18699 RVA: 0x00152878 File Offset: 0x00150A78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 233342, RefRangeEnd = 233343, XrefRangeStart = 233331, XrefRangeEnd = 233342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetAotId()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackTrace.NativeMethodInfoPtr_GetAotId_Private_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600490C RID: 18700 RVA: 0x001528A4 File Offset: 0x00150AA4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 233409, RefRangeEnd = 233411, XrefRangeStart = 233343, XrefRangeEnd = 233409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AddFrames(StringBuilder sb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackTrace.NativeMethodInfoPtr_AddFrames_Private_Boolean_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600490D RID: 18701 RVA: 0x001528F4 File Offset: 0x00150AF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 233454, RefRangeEnd = 233455, XrefRangeStart = 233411, XrefRangeEnd = 233454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetFullNameForStackTrace(StringBuilder sb, MethodBase mi)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mi);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackTrace.NativeMethodInfoPtr_GetFullNameForStackTrace_Internal_Void_StringBuilder_MethodBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600490E RID: 18702 RVA: 0x00152948 File Offset: 0x00150B48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233455, XrefRangeEnd = 233475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StackTrace.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600490F RID: 18703 RVA: 0x0015298C File Offset: 0x00150B8C
		[CallerCount(0)]
		public unsafe string ToString(StackTrace.TraceFormat traceFormat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref traceFormat;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackTrace.NativeMethodInfoPtr_ToString_Internal_String_TraceFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06004910 RID: 18704 RVA: 0x0001B489 File Offset: 0x00019689
		public StackTrace(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001280 RID: 4736
		// (get) Token: 0x06004911 RID: 18705 RVA: 0x001529D0 File Offset: 0x00150BD0
		// (set) Token: 0x06004912 RID: 18706 RVA: 0x0001B492 File Offset: 0x00019692
		public unsafe static int METHODS_TO_SKIP
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(StackTrace.NativeFieldInfoPtr_METHODS_TO_SKIP, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StackTrace.NativeFieldInfoPtr_METHODS_TO_SKIP, (void*)(&value));
			}
		}

		// Token: 0x17001281 RID: 4737
		// (get) Token: 0x06004913 RID: 18707 RVA: 0x001529EC File Offset: 0x00150BEC
		// (set) Token: 0x06004914 RID: 18708 RVA: 0x0001B4A0 File Offset: 0x000196A0
		public unsafe Il2CppReferenceArray<StackFrame> frames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackTrace.NativeFieldInfoPtr_frames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<StackFrame>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackTrace.NativeFieldInfoPtr_frames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001282 RID: 4738
		// (get) Token: 0x06004915 RID: 18709 RVA: 0x00152A1C File Offset: 0x00150C1C
		// (set) Token: 0x06004916 RID: 18710 RVA: 0x0001B4BF File Offset: 0x000196BF
		public unsafe Il2CppReferenceArray<StackTrace> captured_traces
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackTrace.NativeFieldInfoPtr_captured_traces);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<StackTrace>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackTrace.NativeFieldInfoPtr_captured_traces), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001283 RID: 4739
		// (get) Token: 0x06004917 RID: 18711 RVA: 0x00152A4C File Offset: 0x00150C4C
		// (set) Token: 0x06004918 RID: 18712 RVA: 0x0001B4DE File Offset: 0x000196DE
		public unsafe bool debug_info
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackTrace.NativeFieldInfoPtr_debug_info);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackTrace.NativeFieldInfoPtr_debug_info)) = value;
			}
		}

		// Token: 0x17001284 RID: 4740
		// (get) Token: 0x06004919 RID: 18713 RVA: 0x00152A74 File Offset: 0x00150C74
		// (set) Token: 0x0600491A RID: 18714 RVA: 0x0001B4F9 File Offset: 0x000196F9
		public unsafe static bool isAotidSet
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(StackTrace.NativeFieldInfoPtr_isAotidSet, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StackTrace.NativeFieldInfoPtr_isAotidSet, (void*)(&value));
			}
		}

		// Token: 0x17001285 RID: 4741
		// (get) Token: 0x0600491B RID: 18715 RVA: 0x00152A90 File Offset: 0x00150C90
		// (set) Token: 0x0600491C RID: 18716 RVA: 0x0001B507 File Offset: 0x00019707
		public unsafe static string aotid
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StackTrace.NativeFieldInfoPtr_aotid, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StackTrace.NativeFieldInfoPtr_aotid, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04003B27 RID: 15143
		private static readonly IntPtr NativeFieldInfoPtr_METHODS_TO_SKIP;

		// Token: 0x04003B28 RID: 15144
		private static readonly IntPtr NativeFieldInfoPtr_frames;

		// Token: 0x04003B29 RID: 15145
		private static readonly IntPtr NativeFieldInfoPtr_captured_traces;

		// Token: 0x04003B2A RID: 15146
		private static readonly IntPtr NativeFieldInfoPtr_debug_info;

		// Token: 0x04003B2B RID: 15147
		private static readonly IntPtr NativeFieldInfoPtr_isAotidSet;

		// Token: 0x04003B2C RID: 15148
		private static readonly IntPtr NativeFieldInfoPtr_aotid;

		// Token: 0x04003B2D RID: 15149
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003B2E RID: 15150
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x04003B2F RID: 15151
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_0;

		// Token: 0x04003B30 RID: 15152
		private static readonly IntPtr NativeMethodInfoPtr_init_frames_Private_Void_Int32_Boolean_0;

		// Token: 0x04003B31 RID: 15153
		private static readonly IntPtr NativeMethodInfoPtr_get_trace_Private_Static_Il2CppReferenceArray_1_StackFrame_Exception_Int32_Boolean_0;

		// Token: 0x04003B32 RID: 15154
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Exception_Boolean_0;

		// Token: 0x04003B33 RID: 15155
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Exception_Int32_Boolean_0;

		// Token: 0x04003B34 RID: 15156
		private static readonly IntPtr NativeMethodInfoPtr_get_FrameCount_Public_Virtual_New_get_Int32_0;

		// Token: 0x04003B35 RID: 15157
		private static readonly IntPtr NativeMethodInfoPtr_GetFrame_Public_Virtual_New_StackFrame_Int32_0;

		// Token: 0x04003B36 RID: 15158
		private static readonly IntPtr NativeMethodInfoPtr_GetFrames_Public_Virtual_New_Il2CppReferenceArray_1_StackFrame_0;

		// Token: 0x04003B37 RID: 15159
		private static readonly IntPtr NativeMethodInfoPtr_GetAotId_Private_Static_String_0;

		// Token: 0x04003B38 RID: 15160
		private static readonly IntPtr NativeMethodInfoPtr_AddFrames_Private_Boolean_StringBuilder_0;

		// Token: 0x04003B39 RID: 15161
		private static readonly IntPtr NativeMethodInfoPtr_GetFullNameForStackTrace_Internal_Void_StringBuilder_MethodBase_0;

		// Token: 0x04003B3A RID: 15162
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04003B3B RID: 15163
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Internal_String_TraceFormat_0;

		// Token: 0x02000672 RID: 1650
		[OriginalName("mscorlib.dll", "", "TraceFormat")]
		public enum TraceFormat
		{
			// Token: 0x040046D6 RID: 18134
			Normal,
			// Token: 0x040046D7 RID: 18135
			TrailingNewLine,
			// Token: 0x040046D8 RID: 18136
			NoResourceLookup
		}
	}
}
