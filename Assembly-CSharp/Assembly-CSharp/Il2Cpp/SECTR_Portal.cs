using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Il2Cpp
{
	// Token: 0x0200004F RID: 79
	public class SECTR_Portal : SECTR_Hull
	{
		// Token: 0x06000BBB RID: 3003 RVA: 0x00056F8C File Offset: 0x0005518C
		// Note: this type is marked as 'beforefieldinit'.
		static SECTR_Portal()
		{
			Il2CppClassPointerStore<SECTR_Portal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SECTR_Portal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SECTR_Portal>.NativeClassPtr);
			SECTR_Portal.NativeFieldInfoPtr_frontSector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Portal>.NativeClassPtr, "frontSector");
			SECTR_Portal.NativeFieldInfoPtr_backSector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Portal>.NativeClassPtr, "backSector");
			SECTR_Portal.NativeFieldInfoPtr_visited = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Portal>.NativeClassPtr, "visited");
			SECTR_Portal.NativeFieldInfoPtr_allPortals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Portal>.NativeClassPtr, "allPortals");
			SECTR_Portal.NativeFieldInfoPtr_Flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Portal>.NativeClassPtr, "Flags");
			SECTR_Portal.NativeMethodInfoPtr_get_All_Public_Static_get_List_1_SECTR_Portal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Portal>.NativeClassPtr, 100664293);
			SECTR_Portal.NativeMethodInfoPtr_set_FrontSector_Public_set_Void_SECTR_Sector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Portal>.NativeClassPtr, 100664294);
			SECTR_Portal.NativeMethodInfoPtr_get_FrontSector_Public_get_SECTR_Sector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Portal>.NativeClassPtr, 100664295);
			SECTR_Portal.NativeMethodInfoPtr_set_BackSector_Public_set_Void_SECTR_Sector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Portal>.NativeClassPtr, 100664296);
			SECTR_Portal.NativeMethodInfoPtr_get_BackSector_Public_get_SECTR_Sector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Portal>.NativeClassPtr, 100664297);
			SECTR_Portal.NativeMethodInfoPtr_get_Visited_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Portal>.NativeClassPtr, 100664298);
			SECTR_Portal.NativeMethodInfoPtr_set_Visited_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Portal>.NativeClassPtr, 100664299);
			SECTR_Portal.NativeMethodInfoPtr_GetSectors_Public_IEnumerable_1_SECTR_Sector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Portal>.NativeClassPtr, 100664300);
			SECTR_Portal.NativeMethodInfoPtr_SetFlag_Public_Void_PortalFlags_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Portal>.NativeClassPtr, 100664301);
			SECTR_Portal.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Portal>.NativeClassPtr, 100664302);
			SECTR_Portal.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Portal>.NativeClassPtr, 100664303);
			SECTR_Portal.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Portal>.NativeClassPtr, 100664304);
		}

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x06000BBC RID: 3004 RVA: 0x00057110 File Offset: 0x00055310
		public unsafe static List<SECTR_Portal> All
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41991, XrefRangeEnd = 41995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Portal.NativeMethodInfoPtr_get_All_Public_Static_get_List_1_SECTR_Portal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<SECTR_Portal>>(intPtr3) : null;
			}
		}

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x06000BBE RID: 3006 RVA: 0x00057188 File Offset: 0x00055388
		// (set) Token: 0x06000BBD RID: 3005 RVA: 0x00057144 File Offset: 0x00055344
		public unsafe SECTR_Sector FrontSector
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 42028, RefRangeEnd = 42037, XrefRangeStart = 42022, XrefRangeEnd = 42028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Portal.NativeMethodInfoPtr_get_FrontSector_Public_get_SECTR_Sector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SECTR_Sector>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41995, XrefRangeEnd = 42022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Portal.NativeMethodInfoPtr_set_FrontSector_Public_set_Void_SECTR_Sector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x06000BC0 RID: 3008 RVA: 0x0005720C File Offset: 0x0005540C
		// (set) Token: 0x06000BBF RID: 3007 RVA: 0x000571C8 File Offset: 0x000553C8
		public unsafe SECTR_Sector BackSector
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 42070, RefRangeEnd = 42075, XrefRangeStart = 42064, XrefRangeEnd = 42070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Portal.NativeMethodInfoPtr_get_BackSector_Public_get_SECTR_Sector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SECTR_Sector>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42037, XrefRangeEnd = 42064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Portal.NativeMethodInfoPtr_set_BackSector_Public_set_Void_SECTR_Sector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x06000BC1 RID: 3009 RVA: 0x0005724C File Offset: 0x0005544C
		// (set) Token: 0x06000BC2 RID: 3010 RVA: 0x00057288 File Offset: 0x00055488
		public unsafe bool Visited
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Portal.NativeMethodInfoPtr_get_Visited_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Portal.NativeMethodInfoPtr_set_Visited_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000BC3 RID: 3011 RVA: 0x000572C8 File Offset: 0x000554C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42075, XrefRangeEnd = 42080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<SECTR_Sector> GetSectors()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Portal.NativeMethodInfoPtr_GetSectors_Public_IEnumerable_1_SECTR_Sector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<SECTR_Sector>>(intPtr3) : null;
		}

		// Token: 0x06000BC4 RID: 3012 RVA: 0x00057308 File Offset: 0x00055508
		[CallerCount(0)]
		public unsafe void SetFlag(SECTR_Portal.PortalFlags flag, bool on)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flag;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref on;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Portal.NativeMethodInfoPtr_SetFlag_Public_Void_PortalFlags_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BC5 RID: 3013 RVA: 0x00057354 File Offset: 0x00055554
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42080, XrefRangeEnd = 42096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Portal.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BC6 RID: 3014 RVA: 0x00057388 File Offset: 0x00055588
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42096, XrefRangeEnd = 42111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Portal.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BC7 RID: 3015 RVA: 0x000573BC File Offset: 0x000555BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SECTR_Portal()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SECTR_Portal>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Portal.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BC8 RID: 3016 RVA: 0x000093DE File Offset: 0x000075DE
		public SECTR_Portal(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x06000BC9 RID: 3017 RVA: 0x000573F8 File Offset: 0x000555F8
		// (set) Token: 0x06000BCA RID: 3018 RVA: 0x000093E7 File Offset: 0x000075E7
		public unsafe SECTR_Sector frontSector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Portal.NativeFieldInfoPtr_frontSector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_Sector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Portal.NativeFieldInfoPtr_frontSector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x06000BCB RID: 3019 RVA: 0x00057428 File Offset: 0x00055628
		// (set) Token: 0x06000BCC RID: 3020 RVA: 0x00009406 File Offset: 0x00007606
		public unsafe SECTR_Sector backSector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Portal.NativeFieldInfoPtr_backSector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_Sector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Portal.NativeFieldInfoPtr_backSector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x06000BCD RID: 3021 RVA: 0x00057458 File Offset: 0x00055658
		// (set) Token: 0x06000BCE RID: 3022 RVA: 0x00009425 File Offset: 0x00007625
		public unsafe bool visited
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Portal.NativeFieldInfoPtr_visited);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Portal.NativeFieldInfoPtr_visited)) = value;
			}
		}

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x06000BCF RID: 3023 RVA: 0x00057480 File Offset: 0x00055680
		// (set) Token: 0x06000BD0 RID: 3024 RVA: 0x00009440 File Offset: 0x00007640
		public unsafe static List<SECTR_Portal> allPortals
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SECTR_Portal.NativeFieldInfoPtr_allPortals, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SECTR_Portal>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SECTR_Portal.NativeFieldInfoPtr_allPortals, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x06000BD1 RID: 3025 RVA: 0x000574A8 File Offset: 0x000556A8
		// (set) Token: 0x06000BD2 RID: 3026 RVA: 0x00009452 File Offset: 0x00007652
		public unsafe SECTR_Portal.PortalFlags Flags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Portal.NativeFieldInfoPtr_Flags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Portal.NativeFieldInfoPtr_Flags)) = value;
			}
		}

		// Token: 0x04000727 RID: 1831
		private static readonly IntPtr NativeFieldInfoPtr_frontSector;

		// Token: 0x04000728 RID: 1832
		private static readonly IntPtr NativeFieldInfoPtr_backSector;

		// Token: 0x04000729 RID: 1833
		private static readonly IntPtr NativeFieldInfoPtr_visited;

		// Token: 0x0400072A RID: 1834
		private static readonly IntPtr NativeFieldInfoPtr_allPortals;

		// Token: 0x0400072B RID: 1835
		private static readonly IntPtr NativeFieldInfoPtr_Flags;

		// Token: 0x0400072C RID: 1836
		private static readonly IntPtr NativeMethodInfoPtr_get_All_Public_Static_get_List_1_SECTR_Portal_0;

		// Token: 0x0400072D RID: 1837
		private static readonly IntPtr NativeMethodInfoPtr_set_FrontSector_Public_set_Void_SECTR_Sector_0;

		// Token: 0x0400072E RID: 1838
		private static readonly IntPtr NativeMethodInfoPtr_get_FrontSector_Public_get_SECTR_Sector_0;

		// Token: 0x0400072F RID: 1839
		private static readonly IntPtr NativeMethodInfoPtr_set_BackSector_Public_set_Void_SECTR_Sector_0;

		// Token: 0x04000730 RID: 1840
		private static readonly IntPtr NativeMethodInfoPtr_get_BackSector_Public_get_SECTR_Sector_0;

		// Token: 0x04000731 RID: 1841
		private static readonly IntPtr NativeMethodInfoPtr_get_Visited_Public_get_Boolean_0;

		// Token: 0x04000732 RID: 1842
		private static readonly IntPtr NativeMethodInfoPtr_set_Visited_Public_set_Void_Boolean_0;

		// Token: 0x04000733 RID: 1843
		private static readonly IntPtr NativeMethodInfoPtr_GetSectors_Public_IEnumerable_1_SECTR_Sector_0;

		// Token: 0x04000734 RID: 1844
		private static readonly IntPtr NativeMethodInfoPtr_SetFlag_Public_Void_PortalFlags_Boolean_0;

		// Token: 0x04000735 RID: 1845
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04000736 RID: 1846
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04000737 RID: 1847
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020002C3 RID: 707
		[OriginalName("Assembly-CSharp.dll", "", "PortalFlags")]
		[Flags]
		public enum PortalFlags
		{
			// Token: 0x040031D9 RID: 12761
			Closed = 1,
			// Token: 0x040031DA RID: 12762
			Locked = 2,
			// Token: 0x040031DB RID: 12763
			PassThrough = 4
		}

		// Token: 0x020002C4 RID: 708
		[ObfuscatedName("SECTR_Portal+<GetSectors>d__17")]
		public sealed class _GetSectors_d__17 : Object
		{
			// Token: 0x06004C0D RID: 19469 RVA: 0x001188AC File Offset: 0x00116AAC
			// Note: this type is marked as 'beforefieldinit'.
			static _GetSectors_d__17()
			{
				Il2CppClassPointerStore<SECTR_Portal._GetSectors_d__17>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SECTR_Portal>.NativeClassPtr, "<GetSectors>d__17");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SECTR_Portal._GetSectors_d__17>.NativeClassPtr);
				SECTR_Portal._GetSectors_d__17.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Portal._GetSectors_d__17>.NativeClassPtr, "<>1__state");
				SECTR_Portal._GetSectors_d__17.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Portal._GetSectors_d__17>.NativeClassPtr, "<>2__current");
				SECTR_Portal._GetSectors_d__17.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Portal._GetSectors_d__17>.NativeClassPtr, "<>l__initialThreadId");
				SECTR_Portal._GetSectors_d__17.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Portal._GetSectors_d__17>.NativeClassPtr, "<>4__this");
				SECTR_Portal._GetSectors_d__17.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Portal._GetSectors_d__17>.NativeClassPtr, 100664306);
				SECTR_Portal._GetSectors_d__17.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Portal._GetSectors_d__17>.NativeClassPtr, 100664307);
				SECTR_Portal._GetSectors_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Portal._GetSectors_d__17>.NativeClassPtr, 100664308);
				SECTR_Portal._GetSectors_d__17.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_SECTR_Sector__get_Current_Private_Virtual_Final_New_get_SECTR_Sector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Portal._GetSectors_d__17>.NativeClassPtr, 100664309);
				SECTR_Portal._GetSectors_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Portal._GetSectors_d__17>.NativeClassPtr, 100664310);
				SECTR_Portal._GetSectors_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Portal._GetSectors_d__17>.NativeClassPtr, 100664311);
				SECTR_Portal._GetSectors_d__17.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_SECTR_Sector__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_SECTR_Sector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Portal._GetSectors_d__17>.NativeClassPtr, 100664312);
				SECTR_Portal._GetSectors_d__17.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Portal._GetSectors_d__17>.NativeClassPtr, 100664313);
			}

			// Token: 0x06004C0E RID: 19470 RVA: 0x001189C8 File Offset: 0x00116BC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GetSectors_d__17(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SECTR_Portal._GetSectors_d__17>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Portal._GetSectors_d__17.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004C0F RID: 19471 RVA: 0x00118A10 File Offset: 0x00116C10
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Portal._GetSectors_d__17.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004C10 RID: 19472 RVA: 0x00118A44 File Offset: 0x00116C44
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Portal._GetSectors_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001BB5 RID: 7093
			// (get) Token: 0x06004C11 RID: 19473 RVA: 0x00118A80 File Offset: 0x00116C80
			public unsafe SECTR_Sector System.Collections.Generic.IEnumerator<SECTR_Sector>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Portal._GetSectors_d__17.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_SECTR_Sector__get_Current_Private_Virtual_Final_New_get_SECTR_Sector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<SECTR_Sector>(intPtr3) : null;
				}
			}

			// Token: 0x06004C12 RID: 19474 RVA: 0x00118AC0 File Offset: 0x00116CC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41983, XrefRangeEnd = 41988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Portal._GetSectors_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001BB6 RID: 7094
			// (get) Token: 0x06004C13 RID: 19475 RVA: 0x00118AF4 File Offset: 0x00116CF4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Portal._GetSectors_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004C14 RID: 19476 RVA: 0x00118B34 File Offset: 0x00116D34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41988, XrefRangeEnd = 41991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<SECTR_Sector> System_Collections_Generic_IEnumerable_SECTR_Sector__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Portal._GetSectors_d__17.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_SECTR_Sector__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_SECTR_Sector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<SECTR_Sector>>(intPtr3) : null;
			}

			// Token: 0x06004C15 RID: 19477 RVA: 0x00118B74 File Offset: 0x00116D74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Portal._GetSectors_d__17.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06004C16 RID: 19478 RVA: 0x0002CC02 File Offset: 0x0002AE02
			public _GetSectors_d__17(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001BB1 RID: 7089
			// (get) Token: 0x06004C17 RID: 19479 RVA: 0x00118BB4 File Offset: 0x00116DB4
			// (set) Token: 0x06004C18 RID: 19480 RVA: 0x0002CC0B File Offset: 0x0002AE0B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Portal._GetSectors_d__17.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Portal._GetSectors_d__17.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001BB2 RID: 7090
			// (get) Token: 0x06004C19 RID: 19481 RVA: 0x00118BDC File Offset: 0x00116DDC
			// (set) Token: 0x06004C1A RID: 19482 RVA: 0x0002CC26 File Offset: 0x0002AE26
			public unsafe SECTR_Sector __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Portal._GetSectors_d__17.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_Sector>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Portal._GetSectors_d__17.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BB3 RID: 7091
			// (get) Token: 0x06004C1B RID: 19483 RVA: 0x00118C0C File Offset: 0x00116E0C
			// (set) Token: 0x06004C1C RID: 19484 RVA: 0x0002CC45 File Offset: 0x0002AE45
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Portal._GetSectors_d__17.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Portal._GetSectors_d__17.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001BB4 RID: 7092
			// (get) Token: 0x06004C1D RID: 19485 RVA: 0x00118C34 File Offset: 0x00116E34
			// (set) Token: 0x06004C1E RID: 19486 RVA: 0x0002CC60 File Offset: 0x0002AE60
			public unsafe SECTR_Portal __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Portal._GetSectors_d__17.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_Portal>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Portal._GetSectors_d__17.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040031DC RID: 12764
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040031DD RID: 12765
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040031DE RID: 12766
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040031DF RID: 12767
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040031E0 RID: 12768
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040031E1 RID: 12769
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040031E2 RID: 12770
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040031E3 RID: 12771
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_SECTR_Sector__get_Current_Private_Virtual_Final_New_get_SECTR_Sector_0;

			// Token: 0x040031E4 RID: 12772
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040031E5 RID: 12773
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040031E6 RID: 12774
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_SECTR_Sector__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_SECTR_Sector_0;

			// Token: 0x040031E7 RID: 12775
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
