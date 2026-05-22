using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Util
{
	// Token: 0x020002CC RID: 716
	public sealed class TokenizerStream : Object
	{
		// Token: 0x0600308E RID: 12430 RVA: 0x000F564C File Offset: 0x000F384C
		// Note: this type is marked as 'beforefieldinit'.
		static TokenizerStream()
		{
			Il2CppClassPointerStore<TokenizerStream>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Util", "TokenizerStream");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TokenizerStream>.NativeClassPtr);
			TokenizerStream.NativeFieldInfoPtr_m_countTokens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenizerStream>.NativeClassPtr, "m_countTokens");
			TokenizerStream.NativeFieldInfoPtr_m_headTokens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenizerStream>.NativeClassPtr, "m_headTokens");
			TokenizerStream.NativeFieldInfoPtr_m_lastTokens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenizerStream>.NativeClassPtr, "m_lastTokens");
			TokenizerStream.NativeFieldInfoPtr_m_currentTokens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenizerStream>.NativeClassPtr, "m_currentTokens");
			TokenizerStream.NativeFieldInfoPtr_m_indexTokens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenizerStream>.NativeClassPtr, "m_indexTokens");
			TokenizerStream.NativeFieldInfoPtr_m_headStrings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenizerStream>.NativeClassPtr, "m_headStrings");
			TokenizerStream.NativeFieldInfoPtr_m_currentStrings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenizerStream>.NativeClassPtr, "m_currentStrings");
			TokenizerStream.NativeFieldInfoPtr_m_indexStrings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenizerStream>.NativeClassPtr, "m_indexStrings");
			TokenizerStream.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenizerStream>.NativeClassPtr, 100671019);
			TokenizerStream.NativeMethodInfoPtr_AddToken_Internal_Void_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenizerStream>.NativeClassPtr, 100671020);
			TokenizerStream.NativeMethodInfoPtr_AddString_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenizerStream>.NativeClassPtr, 100671021);
			TokenizerStream.NativeMethodInfoPtr_Reset_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenizerStream>.NativeClassPtr, 100671022);
			TokenizerStream.NativeMethodInfoPtr_GetNextFullToken_Internal_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenizerStream>.NativeClassPtr, 100671023);
			TokenizerStream.NativeMethodInfoPtr_GetNextToken_Internal_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenizerStream>.NativeClassPtr, 100671024);
			TokenizerStream.NativeMethodInfoPtr_GetNextString_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenizerStream>.NativeClassPtr, 100671025);
			TokenizerStream.NativeMethodInfoPtr_ThrowAwayNextString_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenizerStream>.NativeClassPtr, 100671026);
			TokenizerStream.NativeMethodInfoPtr_TagLastToken_Internal_Void_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenizerStream>.NativeClassPtr, 100671027);
			TokenizerStream.NativeMethodInfoPtr_GetTokenCount_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenizerStream>.NativeClassPtr, 100671028);
			TokenizerStream.NativeMethodInfoPtr_GoToPosition_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenizerStream>.NativeClassPtr, 100671029);
		}

		// Token: 0x0600308F RID: 12431 RVA: 0x000F57F8 File Offset: 0x000F39F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208364, XrefRangeEnd = 208373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TokenizerStream()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TokenizerStream>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenizerStream.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003090 RID: 12432 RVA: 0x000F5834 File Offset: 0x000F3A34
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 208377, RefRangeEnd = 208379, XrefRangeStart = 208373, XrefRangeEnd = 208377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddToken(short token)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref token;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenizerStream.NativeMethodInfoPtr_AddToken_Internal_Void_Int16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003091 RID: 12433 RVA: 0x000F5874 File Offset: 0x000F3A74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 208388, RefRangeEnd = 208389, XrefRangeStart = 208379, XrefRangeEnd = 208388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddString(string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenizerStream.NativeMethodInfoPtr_AddString_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003092 RID: 12434 RVA: 0x000F58B8 File Offset: 0x000F3AB8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 208389, RefRangeEnd = 208397, XrefRangeStart = 208389, XrefRangeEnd = 208389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenizerStream.NativeMethodInfoPtr_Reset_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003093 RID: 12435 RVA: 0x000F58EC File Offset: 0x000F3AEC
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 208397, RefRangeEnd = 208417, XrefRangeStart = 208397, XrefRangeEnd = 208397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe short GetNextFullToken()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenizerStream.NativeMethodInfoPtr_GetNextFullToken_Internal_Int16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003094 RID: 12436 RVA: 0x000F5928 File Offset: 0x000F3B28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208417, XrefRangeEnd = 208418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe short GetNextToken()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenizerStream.NativeMethodInfoPtr_GetNextToken_Internal_Int16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003095 RID: 12437 RVA: 0x000F5964 File Offset: 0x000F3B64
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 208418, RefRangeEnd = 208438, XrefRangeStart = 208418, XrefRangeEnd = 208418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetNextString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenizerStream.NativeMethodInfoPtr_GetNextString_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003096 RID: 12438 RVA: 0x000F599C File Offset: 0x000F3B9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208438, XrefRangeEnd = 208439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowAwayNextString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenizerStream.NativeMethodInfoPtr_ThrowAwayNextString_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003097 RID: 12439 RVA: 0x000F59D0 File Offset: 0x000F3BD0
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 208439, RefRangeEnd = 208448, XrefRangeStart = 208439, XrefRangeEnd = 208439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TagLastToken(short tag)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref tag;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenizerStream.NativeMethodInfoPtr_TagLastToken_Internal_Void_Int16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003098 RID: 12440 RVA: 0x000F5A10 File Offset: 0x000F3C10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 896, RefRangeEnd = 897, XrefRangeStart = 896, XrefRangeEnd = 897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetTokenCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenizerStream.NativeMethodInfoPtr_GetTokenCount_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003099 RID: 12441 RVA: 0x000F5A4C File Offset: 0x000F3C4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208448, XrefRangeEnd = 208451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GoToPosition(int position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenizerStream.NativeMethodInfoPtr_GoToPosition_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600309A RID: 12442 RVA: 0x00010DA6 File Offset: 0x0000EFA6
		public TokenizerStream(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B89 RID: 2953
		// (get) Token: 0x0600309B RID: 12443 RVA: 0x000F5A8C File Offset: 0x000F3C8C
		// (set) Token: 0x0600309C RID: 12444 RVA: 0x00010DAF File Offset: 0x0000EFAF
		public unsafe int m_countTokens
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenizerStream.NativeFieldInfoPtr_m_countTokens);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenizerStream.NativeFieldInfoPtr_m_countTokens)) = value;
			}
		}

		// Token: 0x17000B8A RID: 2954
		// (get) Token: 0x0600309D RID: 12445 RVA: 0x000F5AB4 File Offset: 0x000F3CB4
		// (set) Token: 0x0600309E RID: 12446 RVA: 0x00010DCA File Offset: 0x0000EFCA
		public unsafe TokenizerShortBlock m_headTokens
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenizerStream.NativeFieldInfoPtr_m_headTokens);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TokenizerShortBlock>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenizerStream.NativeFieldInfoPtr_m_headTokens), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B8B RID: 2955
		// (get) Token: 0x0600309F RID: 12447 RVA: 0x000F5AE4 File Offset: 0x000F3CE4
		// (set) Token: 0x060030A0 RID: 12448 RVA: 0x00010DE9 File Offset: 0x0000EFE9
		public unsafe TokenizerShortBlock m_lastTokens
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenizerStream.NativeFieldInfoPtr_m_lastTokens);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TokenizerShortBlock>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenizerStream.NativeFieldInfoPtr_m_lastTokens), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B8C RID: 2956
		// (get) Token: 0x060030A1 RID: 12449 RVA: 0x000F5B14 File Offset: 0x000F3D14
		// (set) Token: 0x060030A2 RID: 12450 RVA: 0x00010E08 File Offset: 0x0000F008
		public unsafe TokenizerShortBlock m_currentTokens
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenizerStream.NativeFieldInfoPtr_m_currentTokens);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TokenizerShortBlock>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenizerStream.NativeFieldInfoPtr_m_currentTokens), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B8D RID: 2957
		// (get) Token: 0x060030A3 RID: 12451 RVA: 0x000F5B44 File Offset: 0x000F3D44
		// (set) Token: 0x060030A4 RID: 12452 RVA: 0x00010E27 File Offset: 0x0000F027
		public unsafe int m_indexTokens
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenizerStream.NativeFieldInfoPtr_m_indexTokens);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenizerStream.NativeFieldInfoPtr_m_indexTokens)) = value;
			}
		}

		// Token: 0x17000B8E RID: 2958
		// (get) Token: 0x060030A5 RID: 12453 RVA: 0x000F5B6C File Offset: 0x000F3D6C
		// (set) Token: 0x060030A6 RID: 12454 RVA: 0x00010E42 File Offset: 0x0000F042
		public unsafe TokenizerStringBlock m_headStrings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenizerStream.NativeFieldInfoPtr_m_headStrings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TokenizerStringBlock>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenizerStream.NativeFieldInfoPtr_m_headStrings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B8F RID: 2959
		// (get) Token: 0x060030A7 RID: 12455 RVA: 0x000F5B9C File Offset: 0x000F3D9C
		// (set) Token: 0x060030A8 RID: 12456 RVA: 0x00010E61 File Offset: 0x0000F061
		public unsafe TokenizerStringBlock m_currentStrings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenizerStream.NativeFieldInfoPtr_m_currentStrings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TokenizerStringBlock>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenizerStream.NativeFieldInfoPtr_m_currentStrings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B90 RID: 2960
		// (get) Token: 0x060030A9 RID: 12457 RVA: 0x000F5BCC File Offset: 0x000F3DCC
		// (set) Token: 0x060030AA RID: 12458 RVA: 0x00010E80 File Offset: 0x0000F080
		public unsafe int m_indexStrings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenizerStream.NativeFieldInfoPtr_m_indexStrings);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenizerStream.NativeFieldInfoPtr_m_indexStrings)) = value;
			}
		}

		// Token: 0x040029D2 RID: 10706
		private static readonly IntPtr NativeFieldInfoPtr_m_countTokens;

		// Token: 0x040029D3 RID: 10707
		private static readonly IntPtr NativeFieldInfoPtr_m_headTokens;

		// Token: 0x040029D4 RID: 10708
		private static readonly IntPtr NativeFieldInfoPtr_m_lastTokens;

		// Token: 0x040029D5 RID: 10709
		private static readonly IntPtr NativeFieldInfoPtr_m_currentTokens;

		// Token: 0x040029D6 RID: 10710
		private static readonly IntPtr NativeFieldInfoPtr_m_indexTokens;

		// Token: 0x040029D7 RID: 10711
		private static readonly IntPtr NativeFieldInfoPtr_m_headStrings;

		// Token: 0x040029D8 RID: 10712
		private static readonly IntPtr NativeFieldInfoPtr_m_currentStrings;

		// Token: 0x040029D9 RID: 10713
		private static readonly IntPtr NativeFieldInfoPtr_m_indexStrings;

		// Token: 0x040029DA RID: 10714
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x040029DB RID: 10715
		private static readonly IntPtr NativeMethodInfoPtr_AddToken_Internal_Void_Int16_0;

		// Token: 0x040029DC RID: 10716
		private static readonly IntPtr NativeMethodInfoPtr_AddString_Internal_Void_String_0;

		// Token: 0x040029DD RID: 10717
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Internal_Void_0;

		// Token: 0x040029DE RID: 10718
		private static readonly IntPtr NativeMethodInfoPtr_GetNextFullToken_Internal_Int16_0;

		// Token: 0x040029DF RID: 10719
		private static readonly IntPtr NativeMethodInfoPtr_GetNextToken_Internal_Int16_0;

		// Token: 0x040029E0 RID: 10720
		private static readonly IntPtr NativeMethodInfoPtr_GetNextString_Internal_String_0;

		// Token: 0x040029E1 RID: 10721
		private static readonly IntPtr NativeMethodInfoPtr_ThrowAwayNextString_Internal_Void_0;

		// Token: 0x040029E2 RID: 10722
		private static readonly IntPtr NativeMethodInfoPtr_TagLastToken_Internal_Void_Int16_0;

		// Token: 0x040029E3 RID: 10723
		private static readonly IntPtr NativeMethodInfoPtr_GetTokenCount_Internal_Int32_0;

		// Token: 0x040029E4 RID: 10724
		private static readonly IntPtr NativeMethodInfoPtr_GoToPosition_Internal_Void_Int32_0;
	}
}
