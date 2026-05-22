using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Text.RegularExpressions
{
	// Token: 0x02000064 RID: 100
	public class RegexRunner : Object
	{
		// Token: 0x060006F9 RID: 1785 RVA: 0x0002B968 File Offset: 0x00029B68
		// Note: this type is marked as 'beforefieldinit'.
		static RegexRunner()
		{
			Il2CppClassPointerStore<RegexRunner>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Text.RegularExpressions", "RegexRunner");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr);
			RegexRunner.NativeFieldInfoPtr_runtextbeg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, "runtextbeg");
			RegexRunner.NativeFieldInfoPtr_runtextend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, "runtextend");
			RegexRunner.NativeFieldInfoPtr_runtextstart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, "runtextstart");
			RegexRunner.NativeFieldInfoPtr_runtext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, "runtext");
			RegexRunner.NativeFieldInfoPtr_runtextpos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, "runtextpos");
			RegexRunner.NativeFieldInfoPtr_runtrack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, "runtrack");
			RegexRunner.NativeFieldInfoPtr_runtrackpos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, "runtrackpos");
			RegexRunner.NativeFieldInfoPtr_runstack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, "runstack");
			RegexRunner.NativeFieldInfoPtr_runstackpos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, "runstackpos");
			RegexRunner.NativeFieldInfoPtr_runcrawl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, "runcrawl");
			RegexRunner.NativeFieldInfoPtr_runcrawlpos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, "runcrawlpos");
			RegexRunner.NativeFieldInfoPtr_runtrackcount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, "runtrackcount");
			RegexRunner.NativeFieldInfoPtr_runmatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, "runmatch");
			RegexRunner.NativeFieldInfoPtr_runregex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, "runregex");
			RegexRunner.NativeFieldInfoPtr_timeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, "timeout");
			RegexRunner.NativeFieldInfoPtr_ignoreTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, "ignoreTimeout");
			RegexRunner.NativeFieldInfoPtr_timeoutOccursAt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, "timeoutOccursAt");
			RegexRunner.NativeFieldInfoPtr_timeoutChecksToSkip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, "timeoutChecksToSkip");
			RegexRunner.NativeMethodInfoPtr__ctor_FamOrAssem_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, 100664355);
			RegexRunner.NativeMethodInfoPtr_Scan_FamOrAssem_Match_Regex_String_Int32_Int32_Int32_Int32_Boolean_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, 100664356);
			RegexRunner.NativeMethodInfoPtr_StartTimeoutWatch_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, 100664357);
			RegexRunner.NativeMethodInfoPtr_CheckTimeout_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, 100664358);
			RegexRunner.NativeMethodInfoPtr_DoCheckTimeout_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, 100664359);
			RegexRunner.NativeMethodInfoPtr_Go_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, 100664360);
			RegexRunner.NativeMethodInfoPtr_FindFirstChar_Protected_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, 100664361);
			RegexRunner.NativeMethodInfoPtr_InitTrackCount_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, 100664362);
			RegexRunner.NativeMethodInfoPtr_InitMatch_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, 100664363);
			RegexRunner.NativeMethodInfoPtr_TidyMatch_Private_Match_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, 100664364);
			RegexRunner.NativeMethodInfoPtr_EnsureStorage_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, 100664365);
			RegexRunner.NativeMethodInfoPtr_IsBoundary_Protected_Boolean_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, 100664366);
			RegexRunner.NativeMethodInfoPtr_IsECMABoundary_Protected_Boolean_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, 100664367);
			RegexRunner.NativeMethodInfoPtr_DoubleTrack_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, 100664368);
			RegexRunner.NativeMethodInfoPtr_DoubleStack_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, 100664369);
			RegexRunner.NativeMethodInfoPtr_DoubleCrawl_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, 100664370);
			RegexRunner.NativeMethodInfoPtr_Crawl_Protected_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, 100664371);
			RegexRunner.NativeMethodInfoPtr_Popcrawl_Protected_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, 100664372);
			RegexRunner.NativeMethodInfoPtr_Crawlpos_Protected_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, 100664373);
			RegexRunner.NativeMethodInfoPtr_Capture_Protected_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, 100664374);
			RegexRunner.NativeMethodInfoPtr_TransferCapture_Protected_Void_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, 100664375);
			RegexRunner.NativeMethodInfoPtr_Uncapture_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, 100664376);
			RegexRunner.NativeMethodInfoPtr_IsMatched_Protected_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, 100664377);
			RegexRunner.NativeMethodInfoPtr_MatchIndex_Protected_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, 100664378);
			RegexRunner.NativeMethodInfoPtr_MatchLength_Protected_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, 100664379);
		}

		// Token: 0x060006FA RID: 1786 RVA: 0x0002BCF4 File Offset: 0x00029EF4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexRunner()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexRunner.NativeMethodInfoPtr__ctor_FamOrAssem_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006FB RID: 1787 RVA: 0x0002BD30 File Offset: 0x00029F30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 372210, RefRangeEnd = 372211, XrefRangeStart = 372191, XrefRangeEnd = 372210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Match Scan(Regex regex, string text, int textbeg, int textend, int textstart, int prevlen, bool quick, TimeSpan timeout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(regex);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(text);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref textbeg;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref textend;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref textstart;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref prevlen;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quick;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeout;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexRunner.NativeMethodInfoPtr_Scan_FamOrAssem_Match_Regex_String_Int32_Int32_Int32_Int32_Boolean_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Match>(intPtr3) : null;
		}

		// Token: 0x060006FC RID: 1788 RVA: 0x0002BDE8 File Offset: 0x00029FE8
		[CallerCount(0)]
		public unsafe void StartTimeoutWatch()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexRunner.NativeMethodInfoPtr_StartTimeoutWatch_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006FD RID: 1789 RVA: 0x0002BE1C File Offset: 0x0002A01C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 372211, RefRangeEnd = 372213, XrefRangeStart = 372211, XrefRangeEnd = 372211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckTimeout()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexRunner.NativeMethodInfoPtr_CheckTimeout_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006FE RID: 1790 RVA: 0x0002BE50 File Offset: 0x0002A050
		[CallerCount(0)]
		public unsafe void DoCheckTimeout()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexRunner.NativeMethodInfoPtr_DoCheckTimeout_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006FF RID: 1791 RVA: 0x0002BE84 File Offset: 0x0002A084
		[CallerCount(0)]
		public unsafe virtual void Go()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RegexRunner.NativeMethodInfoPtr_Go_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000700 RID: 1792 RVA: 0x0002BEC0 File Offset: 0x0002A0C0
		[CallerCount(0)]
		public unsafe virtual bool FindFirstChar()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RegexRunner.NativeMethodInfoPtr_FindFirstChar_Protected_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000701 RID: 1793 RVA: 0x0002BF08 File Offset: 0x0002A108
		[CallerCount(0)]
		public unsafe virtual void InitTrackCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RegexRunner.NativeMethodInfoPtr_InitTrackCount_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000702 RID: 1794 RVA: 0x0002BF44 File Offset: 0x0002A144
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 372235, RefRangeEnd = 372236, XrefRangeStart = 372213, XrefRangeEnd = 372235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitMatch()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexRunner.NativeMethodInfoPtr_InitMatch_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000703 RID: 1795 RVA: 0x0002BF78 File Offset: 0x0002A178
		[CallerCount(0)]
		public unsafe Match TidyMatch(bool quick)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref quick;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexRunner.NativeMethodInfoPtr_TidyMatch_Private_Match_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Match>(intPtr3) : null;
			}
		}

		// Token: 0x06000704 RID: 1796 RVA: 0x0002BFC4 File Offset: 0x0002A1C4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 372244, RefRangeEnd = 372247, XrefRangeStart = 372236, XrefRangeEnd = 372244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnsureStorage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexRunner.NativeMethodInfoPtr_EnsureStorage_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000705 RID: 1797 RVA: 0x0002BFF8 File Offset: 0x0002A1F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 372256, RefRangeEnd = 372258, XrefRangeStart = 372247, XrefRangeEnd = 372256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsBoundary(int index, int startpos, int endpos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startpos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endpos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexRunner.NativeMethodInfoPtr_IsBoundary_Protected_Boolean_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000706 RID: 1798 RVA: 0x0002C060 File Offset: 0x0002A260
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 372267, RefRangeEnd = 372269, XrefRangeStart = 372258, XrefRangeEnd = 372267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsECMABoundary(int index, int startpos, int endpos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startpos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endpos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexRunner.NativeMethodInfoPtr_IsECMABoundary_Protected_Boolean_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000707 RID: 1799 RVA: 0x0002C0C8 File Offset: 0x0002A2C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372269, XrefRangeEnd = 372273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoubleTrack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexRunner.NativeMethodInfoPtr_DoubleTrack_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000708 RID: 1800 RVA: 0x0002C0FC File Offset: 0x0002A2FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372273, XrefRangeEnd = 372277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoubleStack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexRunner.NativeMethodInfoPtr_DoubleStack_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000709 RID: 1801 RVA: 0x0002C130 File Offset: 0x0002A330
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372277, XrefRangeEnd = 372281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoubleCrawl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexRunner.NativeMethodInfoPtr_DoubleCrawl_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600070A RID: 1802 RVA: 0x0002C164 File Offset: 0x0002A364
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 372285, RefRangeEnd = 372291, XrefRangeStart = 372281, XrefRangeEnd = 372285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Crawl(int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexRunner.NativeMethodInfoPtr_Crawl_Protected_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600070B RID: 1803 RVA: 0x0002C1A4 File Offset: 0x0002A3A4
		[CallerCount(0)]
		public unsafe int Popcrawl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexRunner.NativeMethodInfoPtr_Popcrawl_Protected_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600070C RID: 1804 RVA: 0x0002C1E0 File Offset: 0x0002A3E0
		[CallerCount(0)]
		public unsafe int Crawlpos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexRunner.NativeMethodInfoPtr_Crawlpos_Protected_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600070D RID: 1805 RVA: 0x0002C21C File Offset: 0x0002A41C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372291, XrefRangeEnd = 372293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Capture(int capnum, int start, int end)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capnum;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexRunner.NativeMethodInfoPtr_Capture_Protected_Void_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600070E RID: 1806 RVA: 0x0002C278 File Offset: 0x0002A478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372293, XrefRangeEnd = 372296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TransferCapture(int capnum, int uncapnum, int start, int end)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capnum;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref uncapnum;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexRunner.NativeMethodInfoPtr_TransferCapture_Protected_Void_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600070F RID: 1807 RVA: 0x0002C2E0 File Offset: 0x0002A4E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 372299, RefRangeEnd = 372300, XrefRangeStart = 372296, XrefRangeEnd = 372299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Uncapture()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexRunner.NativeMethodInfoPtr_Uncapture_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000710 RID: 1808 RVA: 0x0002C314 File Offset: 0x0002A514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372300, XrefRangeEnd = 372301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsMatched(int cap)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cap;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexRunner.NativeMethodInfoPtr_IsMatched_Protected_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000711 RID: 1809 RVA: 0x0002C360 File Offset: 0x0002A560
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372301, XrefRangeEnd = 372302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int MatchIndex(int cap)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cap;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexRunner.NativeMethodInfoPtr_MatchIndex_Protected_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000712 RID: 1810 RVA: 0x0002C3AC File Offset: 0x0002A5AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372302, XrefRangeEnd = 372303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int MatchLength(int cap)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cap;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexRunner.NativeMethodInfoPtr_MatchLength_Protected_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000713 RID: 1811 RVA: 0x00004A30 File Offset: 0x00002C30
		public RegexRunner(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x06000714 RID: 1812 RVA: 0x0002C3F8 File Offset: 0x0002A5F8
		// (set) Token: 0x06000715 RID: 1813 RVA: 0x00004A39 File Offset: 0x00002C39
		public unsafe int runtextbeg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_runtextbeg);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_runtextbeg)) = value;
			}
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x06000716 RID: 1814 RVA: 0x0002C420 File Offset: 0x0002A620
		// (set) Token: 0x06000717 RID: 1815 RVA: 0x00004A54 File Offset: 0x00002C54
		public unsafe int runtextend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_runtextend);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_runtextend)) = value;
			}
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x06000718 RID: 1816 RVA: 0x0002C448 File Offset: 0x0002A648
		// (set) Token: 0x06000719 RID: 1817 RVA: 0x00004A6F File Offset: 0x00002C6F
		public unsafe int runtextstart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_runtextstart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_runtextstart)) = value;
			}
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x0600071A RID: 1818 RVA: 0x0002C470 File Offset: 0x0002A670
		// (set) Token: 0x0600071B RID: 1819 RVA: 0x00004A8A File Offset: 0x00002C8A
		public unsafe string runtext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_runtext);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_runtext), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x0600071C RID: 1820 RVA: 0x0002C498 File Offset: 0x0002A698
		// (set) Token: 0x0600071D RID: 1821 RVA: 0x00004AA9 File Offset: 0x00002CA9
		public unsafe int runtextpos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_runtextpos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_runtextpos)) = value;
			}
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x0600071E RID: 1822 RVA: 0x0002C4C0 File Offset: 0x0002A6C0
		// (set) Token: 0x0600071F RID: 1823 RVA: 0x00004AC4 File Offset: 0x00002CC4
		public unsafe Il2CppStructArray<int> runtrack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_runtrack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_runtrack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x06000720 RID: 1824 RVA: 0x0002C4F0 File Offset: 0x0002A6F0
		// (set) Token: 0x06000721 RID: 1825 RVA: 0x00004AE3 File Offset: 0x00002CE3
		public unsafe int runtrackpos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_runtrackpos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_runtrackpos)) = value;
			}
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x06000722 RID: 1826 RVA: 0x0002C518 File Offset: 0x0002A718
		// (set) Token: 0x06000723 RID: 1827 RVA: 0x00004AFE File Offset: 0x00002CFE
		public unsafe Il2CppStructArray<int> runstack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_runstack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_runstack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x06000724 RID: 1828 RVA: 0x0002C548 File Offset: 0x0002A748
		// (set) Token: 0x06000725 RID: 1829 RVA: 0x00004B1D File Offset: 0x00002D1D
		public unsafe int runstackpos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_runstackpos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_runstackpos)) = value;
			}
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x06000726 RID: 1830 RVA: 0x0002C570 File Offset: 0x0002A770
		// (set) Token: 0x06000727 RID: 1831 RVA: 0x00004B38 File Offset: 0x00002D38
		public unsafe Il2CppStructArray<int> runcrawl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_runcrawl);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_runcrawl), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x06000728 RID: 1832 RVA: 0x0002C5A0 File Offset: 0x0002A7A0
		// (set) Token: 0x06000729 RID: 1833 RVA: 0x00004B57 File Offset: 0x00002D57
		public unsafe int runcrawlpos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_runcrawlpos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_runcrawlpos)) = value;
			}
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x0600072A RID: 1834 RVA: 0x0002C5C8 File Offset: 0x0002A7C8
		// (set) Token: 0x0600072B RID: 1835 RVA: 0x00004B72 File Offset: 0x00002D72
		public unsafe int runtrackcount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_runtrackcount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_runtrackcount)) = value;
			}
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x0600072C RID: 1836 RVA: 0x0002C5F0 File Offset: 0x0002A7F0
		// (set) Token: 0x0600072D RID: 1837 RVA: 0x00004B8D File Offset: 0x00002D8D
		public unsafe Match runmatch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_runmatch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_runmatch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x0600072E RID: 1838 RVA: 0x0002C620 File Offset: 0x0002A820
		// (set) Token: 0x0600072F RID: 1839 RVA: 0x00004BAC File Offset: 0x00002DAC
		public unsafe Regex runregex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_runregex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Regex>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_runregex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x06000730 RID: 1840 RVA: 0x0002C650 File Offset: 0x0002A850
		// (set) Token: 0x06000731 RID: 1841 RVA: 0x00004BCB File Offset: 0x00002DCB
		public unsafe int timeout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_timeout);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_timeout)) = value;
			}
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x06000732 RID: 1842 RVA: 0x0002C678 File Offset: 0x0002A878
		// (set) Token: 0x06000733 RID: 1843 RVA: 0x00004BE6 File Offset: 0x00002DE6
		public unsafe bool ignoreTimeout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_ignoreTimeout);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_ignoreTimeout)) = value;
			}
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x06000734 RID: 1844 RVA: 0x0002C6A0 File Offset: 0x0002A8A0
		// (set) Token: 0x06000735 RID: 1845 RVA: 0x00004C01 File Offset: 0x00002E01
		public unsafe int timeoutOccursAt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_timeoutOccursAt);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_timeoutOccursAt)) = value;
			}
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x06000736 RID: 1846 RVA: 0x0002C6C8 File Offset: 0x0002A8C8
		// (set) Token: 0x06000737 RID: 1847 RVA: 0x00004C1C File Offset: 0x00002E1C
		public unsafe int timeoutChecksToSkip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_timeoutChecksToSkip);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_timeoutChecksToSkip)) = value;
			}
		}

		// Token: 0x04000549 RID: 1353
		private static readonly IntPtr NativeFieldInfoPtr_runtextbeg;

		// Token: 0x0400054A RID: 1354
		private static readonly IntPtr NativeFieldInfoPtr_runtextend;

		// Token: 0x0400054B RID: 1355
		private static readonly IntPtr NativeFieldInfoPtr_runtextstart;

		// Token: 0x0400054C RID: 1356
		private static readonly IntPtr NativeFieldInfoPtr_runtext;

		// Token: 0x0400054D RID: 1357
		private static readonly IntPtr NativeFieldInfoPtr_runtextpos;

		// Token: 0x0400054E RID: 1358
		private static readonly IntPtr NativeFieldInfoPtr_runtrack;

		// Token: 0x0400054F RID: 1359
		private static readonly IntPtr NativeFieldInfoPtr_runtrackpos;

		// Token: 0x04000550 RID: 1360
		private static readonly IntPtr NativeFieldInfoPtr_runstack;

		// Token: 0x04000551 RID: 1361
		private static readonly IntPtr NativeFieldInfoPtr_runstackpos;

		// Token: 0x04000552 RID: 1362
		private static readonly IntPtr NativeFieldInfoPtr_runcrawl;

		// Token: 0x04000553 RID: 1363
		private static readonly IntPtr NativeFieldInfoPtr_runcrawlpos;

		// Token: 0x04000554 RID: 1364
		private static readonly IntPtr NativeFieldInfoPtr_runtrackcount;

		// Token: 0x04000555 RID: 1365
		private static readonly IntPtr NativeFieldInfoPtr_runmatch;

		// Token: 0x04000556 RID: 1366
		private static readonly IntPtr NativeFieldInfoPtr_runregex;

		// Token: 0x04000557 RID: 1367
		private static readonly IntPtr NativeFieldInfoPtr_timeout;

		// Token: 0x04000558 RID: 1368
		private static readonly IntPtr NativeFieldInfoPtr_ignoreTimeout;

		// Token: 0x04000559 RID: 1369
		private static readonly IntPtr NativeFieldInfoPtr_timeoutOccursAt;

		// Token: 0x0400055A RID: 1370
		private static readonly IntPtr NativeFieldInfoPtr_timeoutChecksToSkip;

		// Token: 0x0400055B RID: 1371
		private static readonly IntPtr NativeMethodInfoPtr__ctor_FamOrAssem_Void_0;

		// Token: 0x0400055C RID: 1372
		private static readonly IntPtr NativeMethodInfoPtr_Scan_FamOrAssem_Match_Regex_String_Int32_Int32_Int32_Int32_Boolean_TimeSpan_0;

		// Token: 0x0400055D RID: 1373
		private static readonly IntPtr NativeMethodInfoPtr_StartTimeoutWatch_Private_Void_0;

		// Token: 0x0400055E RID: 1374
		private static readonly IntPtr NativeMethodInfoPtr_CheckTimeout_Protected_Void_0;

		// Token: 0x0400055F RID: 1375
		private static readonly IntPtr NativeMethodInfoPtr_DoCheckTimeout_Private_Void_0;

		// Token: 0x04000560 RID: 1376
		private static readonly IntPtr NativeMethodInfoPtr_Go_Protected_Abstract_Virtual_New_Void_0;

		// Token: 0x04000561 RID: 1377
		private static readonly IntPtr NativeMethodInfoPtr_FindFirstChar_Protected_Abstract_Virtual_New_Boolean_0;

		// Token: 0x04000562 RID: 1378
		private static readonly IntPtr NativeMethodInfoPtr_InitTrackCount_Protected_Abstract_Virtual_New_Void_0;

		// Token: 0x04000563 RID: 1379
		private static readonly IntPtr NativeMethodInfoPtr_InitMatch_Private_Void_0;

		// Token: 0x04000564 RID: 1380
		private static readonly IntPtr NativeMethodInfoPtr_TidyMatch_Private_Match_Boolean_0;

		// Token: 0x04000565 RID: 1381
		private static readonly IntPtr NativeMethodInfoPtr_EnsureStorage_Protected_Void_0;

		// Token: 0x04000566 RID: 1382
		private static readonly IntPtr NativeMethodInfoPtr_IsBoundary_Protected_Boolean_Int32_Int32_Int32_0;

		// Token: 0x04000567 RID: 1383
		private static readonly IntPtr NativeMethodInfoPtr_IsECMABoundary_Protected_Boolean_Int32_Int32_Int32_0;

		// Token: 0x04000568 RID: 1384
		private static readonly IntPtr NativeMethodInfoPtr_DoubleTrack_Protected_Void_0;

		// Token: 0x04000569 RID: 1385
		private static readonly IntPtr NativeMethodInfoPtr_DoubleStack_Protected_Void_0;

		// Token: 0x0400056A RID: 1386
		private static readonly IntPtr NativeMethodInfoPtr_DoubleCrawl_Protected_Void_0;

		// Token: 0x0400056B RID: 1387
		private static readonly IntPtr NativeMethodInfoPtr_Crawl_Protected_Void_Int32_0;

		// Token: 0x0400056C RID: 1388
		private static readonly IntPtr NativeMethodInfoPtr_Popcrawl_Protected_Int32_0;

		// Token: 0x0400056D RID: 1389
		private static readonly IntPtr NativeMethodInfoPtr_Crawlpos_Protected_Int32_0;

		// Token: 0x0400056E RID: 1390
		private static readonly IntPtr NativeMethodInfoPtr_Capture_Protected_Void_Int32_Int32_Int32_0;

		// Token: 0x0400056F RID: 1391
		private static readonly IntPtr NativeMethodInfoPtr_TransferCapture_Protected_Void_Int32_Int32_Int32_Int32_0;

		// Token: 0x04000570 RID: 1392
		private static readonly IntPtr NativeMethodInfoPtr_Uncapture_Protected_Void_0;

		// Token: 0x04000571 RID: 1393
		private static readonly IntPtr NativeMethodInfoPtr_IsMatched_Protected_Boolean_Int32_0;

		// Token: 0x04000572 RID: 1394
		private static readonly IntPtr NativeMethodInfoPtr_MatchIndex_Protected_Int32_Int32_0;

		// Token: 0x04000573 RID: 1395
		private static readonly IntPtr NativeMethodInfoPtr_MatchLength_Protected_Int32_Int32_0;
	}
}
