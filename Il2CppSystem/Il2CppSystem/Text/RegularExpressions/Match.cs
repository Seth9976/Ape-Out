using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Text.RegularExpressions
{
	// Token: 0x0200005B RID: 91
	[Serializable]
	public class Match : Group
	{
		// Token: 0x060005EA RID: 1514 RVA: 0x00027710 File Offset: 0x00025910
		// Note: this type is marked as 'beforefieldinit'.
		static Match()
		{
			Il2CppClassPointerStore<Match>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Text.RegularExpressions", "Match");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Match>.NativeClassPtr);
			Match.NativeFieldInfoPtr__empty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match>.NativeClassPtr, "_empty");
			Match.NativeFieldInfoPtr__groupcoll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match>.NativeClassPtr, "_groupcoll");
			Match.NativeFieldInfoPtr__regex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match>.NativeClassPtr, "_regex");
			Match.NativeFieldInfoPtr__textbeg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match>.NativeClassPtr, "_textbeg");
			Match.NativeFieldInfoPtr__textpos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match>.NativeClassPtr, "_textpos");
			Match.NativeFieldInfoPtr__textend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match>.NativeClassPtr, "_textend");
			Match.NativeFieldInfoPtr__textstart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match>.NativeClassPtr, "_textstart");
			Match.NativeFieldInfoPtr__matches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match>.NativeClassPtr, "_matches");
			Match.NativeFieldInfoPtr__matchcount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match>.NativeClassPtr, "_matchcount");
			Match.NativeFieldInfoPtr__balancing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match>.NativeClassPtr, "_balancing");
			Match.NativeMethodInfoPtr_get_Empty_Public_Static_get_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100664213);
			Match.NativeMethodInfoPtr__ctor_Internal_Void_Regex_Int32_String_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100664214);
			Match.NativeMethodInfoPtr_Reset_Internal_Virtual_New_Void_Regex_String_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100664215);
			Match.NativeMethodInfoPtr_get_Groups_Public_Virtual_New_get_GroupCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100664216);
			Match.NativeMethodInfoPtr_NextMatch_Public_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100664217);
			Match.NativeMethodInfoPtr_GroupToStringImpl_Internal_Virtual_New_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100664218);
			Match.NativeMethodInfoPtr_LastGroupToStringImpl_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100664219);
			Match.NativeMethodInfoPtr_AddMatch_Internal_Virtual_New_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100664220);
			Match.NativeMethodInfoPtr_BalanceMatch_Internal_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100664221);
			Match.NativeMethodInfoPtr_RemoveMatch_Internal_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100664222);
			Match.NativeMethodInfoPtr_IsMatched_Internal_Virtual_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100664223);
			Match.NativeMethodInfoPtr_MatchIndex_Internal_Virtual_New_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100664224);
			Match.NativeMethodInfoPtr_MatchLength_Internal_Virtual_New_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100664225);
			Match.NativeMethodInfoPtr_Tidy_Internal_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100664226);
			Match.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100664228);
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x060005EB RID: 1515 RVA: 0x00027934 File Offset: 0x00025B34
		public unsafe static Match Empty
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370950, XrefRangeEnd = 370954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_get_Empty_Public_Static_get_Match_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Match>(intPtr3) : null;
			}
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x00027968 File Offset: 0x00025B68
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 370970, RefRangeEnd = 370973, XrefRangeStart = 370954, XrefRangeEnd = 370970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Match(Regex regex, int capcount, string text, int begpos, int len, int startpos)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Match>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(regex);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref capcount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(text);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref begpos;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startpos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr__ctor_Internal_Void_Regex_Int32_String_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x00027A00 File Offset: 0x00025C00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370973, XrefRangeEnd = 370974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Reset(Regex regex, string text, int textbeg, int textend, int textstart)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(regex);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(text);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref textbeg;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref textend;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref textstart;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_Reset_Internal_Virtual_New_Void_Regex_String_Int32_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x060005EE RID: 1518 RVA: 0x00027A8C File Offset: 0x00025C8C
		public unsafe virtual GroupCollection Groups
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370974, XrefRangeEnd = 370978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_get_Groups_Public_Virtual_New_get_GroupCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GroupCollection>(intPtr3) : null;
			}
		}

		// Token: 0x060005EF RID: 1519 RVA: 0x00027AD8 File Offset: 0x00025CD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370978, XrefRangeEnd = 370979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Match NextMatch()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_NextMatch_Public_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Match>(intPtr3) : null;
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x00027B18 File Offset: 0x00025D18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370979, XrefRangeEnd = 370982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GroupToStringImpl(int groupnum)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref groupnum;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_GroupToStringImpl_Internal_Virtual_New_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060005F1 RID: 1521 RVA: 0x00027B68 File Offset: 0x00025D68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370982, XrefRangeEnd = 370983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string LastGroupToStringImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_LastGroupToStringImpl_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060005F2 RID: 1522 RVA: 0x00027BA0 File Offset: 0x00025DA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370983, XrefRangeEnd = 370993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AddMatch(int cap, int start, int len)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cap;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_AddMatch_Internal_Virtual_New_Void_Int32_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005F3 RID: 1523 RVA: 0x00027C08 File Offset: 0x00025E08
		[CallerCount(0)]
		public unsafe virtual void BalanceMatch(int cap)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cap;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_BalanceMatch_Internal_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x00027C54 File Offset: 0x00025E54
		[CallerCount(0)]
		public unsafe virtual void RemoveMatch(int cap)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cap;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_RemoveMatch_Internal_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x00027CA0 File Offset: 0x00025EA0
		[CallerCount(0)]
		public unsafe virtual bool IsMatched(int cap)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cap;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_IsMatched_Internal_Virtual_New_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x00027CF4 File Offset: 0x00025EF4
		[CallerCount(0)]
		public unsafe virtual int MatchIndex(int cap)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cap;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_MatchIndex_Internal_Virtual_New_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005F7 RID: 1527 RVA: 0x00027D48 File Offset: 0x00025F48
		[CallerCount(0)]
		public unsafe virtual int MatchLength(int cap)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cap;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_MatchLength_Internal_Virtual_New_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x00027D9C File Offset: 0x00025F9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370993, XrefRangeEnd = 370995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Tidy(int textpos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref textpos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_Tidy_Internal_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x00027DE8 File Offset: 0x00025FE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370995, XrefRangeEnd = 370998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Match()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Match>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x00004371 File Offset: 0x00002571
		public Match(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x060005FB RID: 1531 RVA: 0x00027E24 File Offset: 0x00026024
		// (set) Token: 0x060005FC RID: 1532 RVA: 0x0000437A File Offset: 0x0000257A
		public unsafe static Match _empty
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Match.NativeFieldInfoPtr__empty, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Match.NativeFieldInfoPtr__empty, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x060005FD RID: 1533 RVA: 0x00027E4C File Offset: 0x0002604C
		// (set) Token: 0x060005FE RID: 1534 RVA: 0x0000438C File Offset: 0x0000258C
		public unsafe GroupCollection _groupcoll
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr__groupcoll);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GroupCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr__groupcoll), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x060005FF RID: 1535 RVA: 0x00027E7C File Offset: 0x0002607C
		// (set) Token: 0x06000600 RID: 1536 RVA: 0x000043AB File Offset: 0x000025AB
		public unsafe Regex _regex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr__regex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Regex>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr__regex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x06000601 RID: 1537 RVA: 0x00027EAC File Offset: 0x000260AC
		// (set) Token: 0x06000602 RID: 1538 RVA: 0x000043CA File Offset: 0x000025CA
		public unsafe int _textbeg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr__textbeg);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr__textbeg)) = value;
			}
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x06000603 RID: 1539 RVA: 0x00027ED4 File Offset: 0x000260D4
		// (set) Token: 0x06000604 RID: 1540 RVA: 0x000043E5 File Offset: 0x000025E5
		public unsafe int _textpos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr__textpos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr__textpos)) = value;
			}
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x06000605 RID: 1541 RVA: 0x00027EFC File Offset: 0x000260FC
		// (set) Token: 0x06000606 RID: 1542 RVA: 0x00004400 File Offset: 0x00002600
		public unsafe int _textend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr__textend);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr__textend)) = value;
			}
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x06000607 RID: 1543 RVA: 0x00027F24 File Offset: 0x00026124
		// (set) Token: 0x06000608 RID: 1544 RVA: 0x0000441B File Offset: 0x0000261B
		public unsafe int _textstart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr__textstart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr__textstart)) = value;
			}
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x06000609 RID: 1545 RVA: 0x00027F4C File Offset: 0x0002614C
		// (set) Token: 0x0600060A RID: 1546 RVA: 0x00004436 File Offset: 0x00002636
		public unsafe Il2CppReferenceArray<Il2CppStructArray<int>> _matches
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr__matches);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStructArray<int>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr__matches), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x0600060B RID: 1547 RVA: 0x00027F7C File Offset: 0x0002617C
		// (set) Token: 0x0600060C RID: 1548 RVA: 0x00004455 File Offset: 0x00002655
		public unsafe Il2CppStructArray<int> _matchcount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr__matchcount);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr__matchcount), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x0600060D RID: 1549 RVA: 0x00027FAC File Offset: 0x000261AC
		// (set) Token: 0x0600060E RID: 1550 RVA: 0x00004474 File Offset: 0x00002674
		public unsafe bool _balancing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr__balancing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr__balancing)) = value;
			}
		}

		// Token: 0x04000479 RID: 1145
		private static readonly IntPtr NativeFieldInfoPtr__empty;

		// Token: 0x0400047A RID: 1146
		private static readonly IntPtr NativeFieldInfoPtr__groupcoll;

		// Token: 0x0400047B RID: 1147
		private static readonly IntPtr NativeFieldInfoPtr__regex;

		// Token: 0x0400047C RID: 1148
		private static readonly IntPtr NativeFieldInfoPtr__textbeg;

		// Token: 0x0400047D RID: 1149
		private static readonly IntPtr NativeFieldInfoPtr__textpos;

		// Token: 0x0400047E RID: 1150
		private static readonly IntPtr NativeFieldInfoPtr__textend;

		// Token: 0x0400047F RID: 1151
		private static readonly IntPtr NativeFieldInfoPtr__textstart;

		// Token: 0x04000480 RID: 1152
		private static readonly IntPtr NativeFieldInfoPtr__matches;

		// Token: 0x04000481 RID: 1153
		private static readonly IntPtr NativeFieldInfoPtr__matchcount;

		// Token: 0x04000482 RID: 1154
		private static readonly IntPtr NativeFieldInfoPtr__balancing;

		// Token: 0x04000483 RID: 1155
		private static readonly IntPtr NativeMethodInfoPtr_get_Empty_Public_Static_get_Match_0;

		// Token: 0x04000484 RID: 1156
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Regex_Int32_String_Int32_Int32_Int32_0;

		// Token: 0x04000485 RID: 1157
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Internal_Virtual_New_Void_Regex_String_Int32_Int32_Int32_0;

		// Token: 0x04000486 RID: 1158
		private static readonly IntPtr NativeMethodInfoPtr_get_Groups_Public_Virtual_New_get_GroupCollection_0;

		// Token: 0x04000487 RID: 1159
		private static readonly IntPtr NativeMethodInfoPtr_NextMatch_Public_Match_0;

		// Token: 0x04000488 RID: 1160
		private static readonly IntPtr NativeMethodInfoPtr_GroupToStringImpl_Internal_Virtual_New_String_Int32_0;

		// Token: 0x04000489 RID: 1161
		private static readonly IntPtr NativeMethodInfoPtr_LastGroupToStringImpl_Internal_String_0;

		// Token: 0x0400048A RID: 1162
		private static readonly IntPtr NativeMethodInfoPtr_AddMatch_Internal_Virtual_New_Void_Int32_Int32_Int32_0;

		// Token: 0x0400048B RID: 1163
		private static readonly IntPtr NativeMethodInfoPtr_BalanceMatch_Internal_Virtual_New_Void_Int32_0;

		// Token: 0x0400048C RID: 1164
		private static readonly IntPtr NativeMethodInfoPtr_RemoveMatch_Internal_Virtual_New_Void_Int32_0;

		// Token: 0x0400048D RID: 1165
		private static readonly IntPtr NativeMethodInfoPtr_IsMatched_Internal_Virtual_New_Boolean_Int32_0;

		// Token: 0x0400048E RID: 1166
		private static readonly IntPtr NativeMethodInfoPtr_MatchIndex_Internal_Virtual_New_Int32_Int32_0;

		// Token: 0x0400048F RID: 1167
		private static readonly IntPtr NativeMethodInfoPtr_MatchLength_Internal_Virtual_New_Int32_Int32_0;

		// Token: 0x04000490 RID: 1168
		private static readonly IntPtr NativeMethodInfoPtr_Tidy_Internal_Virtual_New_Void_Int32_0;

		// Token: 0x04000491 RID: 1169
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;
	}
}
