using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Globalization;

namespace Il2CppSystem.Resources
{
	// Token: 0x02000184 RID: 388
	public class ResourceFallbackManager : Object
	{
		// Token: 0x06001ADE RID: 6878 RVA: 0x0009E964 File Offset: 0x0009CB64
		// Note: this type is marked as 'beforefieldinit'.
		static ResourceFallbackManager()
		{
			Il2CppClassPointerStore<ResourceFallbackManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Resources", "ResourceFallbackManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResourceFallbackManager>.NativeClassPtr);
			ResourceFallbackManager.NativeFieldInfoPtr_m_startingCulture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceFallbackManager>.NativeClassPtr, "m_startingCulture");
			ResourceFallbackManager.NativeFieldInfoPtr_m_neutralResourcesCulture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceFallbackManager>.NativeClassPtr, "m_neutralResourcesCulture");
			ResourceFallbackManager.NativeFieldInfoPtr_m_useParents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceFallbackManager>.NativeClassPtr, "m_useParents");
			ResourceFallbackManager.NativeMethodInfoPtr__ctor_Internal_Void_CultureInfo_CultureInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceFallbackManager>.NativeClassPtr, 100667899);
			ResourceFallbackManager.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceFallbackManager>.NativeClassPtr, 100667900);
			ResourceFallbackManager.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceFallbackManager>.NativeClassPtr, 100667901);
		}

		// Token: 0x06001ADF RID: 6879 RVA: 0x0009EA0C File Offset: 0x0009CC0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 185208, RefRangeEnd = 185209, XrefRangeStart = 185202, XrefRangeEnd = 185208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResourceFallbackManager(CultureInfo startingCulture, CultureInfo neutralResourcesCulture, bool useParents)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResourceFallbackManager>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(startingCulture);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(neutralResourcesCulture);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useParents;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceFallbackManager.NativeMethodInfoPtr__ctor_Internal_Void_CultureInfo_CultureInfo_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AE0 RID: 6880 RVA: 0x0009EA78 File Offset: 0x0009CC78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185209, XrefRangeEnd = 185210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceFallbackManager.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001AE1 RID: 6881 RVA: 0x0009EAB8 File Offset: 0x0009CCB8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 185213, RefRangeEnd = 185215, XrefRangeStart = 185210, XrefRangeEnd = 185213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator<CultureInfo> GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceFallbackManager.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<CultureInfo>>(intPtr3) : null;
		}

		// Token: 0x06001AE2 RID: 6882 RVA: 0x0000903B File Offset: 0x0000723B
		public ResourceFallbackManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x06001AE3 RID: 6883 RVA: 0x0009EAF8 File Offset: 0x0009CCF8
		// (set) Token: 0x06001AE4 RID: 6884 RVA: 0x00009044 File Offset: 0x00007244
		public unsafe CultureInfo m_startingCulture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceFallbackManager.NativeFieldInfoPtr_m_startingCulture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceFallbackManager.NativeFieldInfoPtr_m_startingCulture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x06001AE5 RID: 6885 RVA: 0x0009EB28 File Offset: 0x0009CD28
		// (set) Token: 0x06001AE6 RID: 6886 RVA: 0x00009063 File Offset: 0x00007263
		public unsafe CultureInfo m_neutralResourcesCulture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceFallbackManager.NativeFieldInfoPtr_m_neutralResourcesCulture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceFallbackManager.NativeFieldInfoPtr_m_neutralResourcesCulture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x06001AE7 RID: 6887 RVA: 0x0009EB58 File Offset: 0x0009CD58
		// (set) Token: 0x06001AE8 RID: 6888 RVA: 0x00009082 File Offset: 0x00007282
		public unsafe bool m_useParents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceFallbackManager.NativeFieldInfoPtr_m_useParents);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceFallbackManager.NativeFieldInfoPtr_m_useParents)) = value;
			}
		}

		// Token: 0x04001876 RID: 6262
		private static readonly IntPtr NativeFieldInfoPtr_m_startingCulture;

		// Token: 0x04001877 RID: 6263
		private static readonly IntPtr NativeFieldInfoPtr_m_neutralResourcesCulture;

		// Token: 0x04001878 RID: 6264
		private static readonly IntPtr NativeFieldInfoPtr_m_useParents;

		// Token: 0x04001879 RID: 6265
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_CultureInfo_CultureInfo_Boolean_0;

		// Token: 0x0400187A RID: 6266
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x0400187B RID: 6267
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_CultureInfo_0;

		// Token: 0x020005C0 RID: 1472
		[ObfuscatedName("System.Resources.ResourceFallbackManager+<GetEnumerator>d__5")]
		public sealed class _GetEnumerator_d__5 : Object
		{
			// Token: 0x0600525F RID: 21087 RVA: 0x0017442C File Offset: 0x0017262C
			// Note: this type is marked as 'beforefieldinit'.
			static _GetEnumerator_d__5()
			{
				Il2CppClassPointerStore<ResourceFallbackManager._GetEnumerator_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResourceFallbackManager>.NativeClassPtr, "<GetEnumerator>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResourceFallbackManager._GetEnumerator_d__5>.NativeClassPtr);
				ResourceFallbackManager._GetEnumerator_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceFallbackManager._GetEnumerator_d__5>.NativeClassPtr, "<>1__state");
				ResourceFallbackManager._GetEnumerator_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceFallbackManager._GetEnumerator_d__5>.NativeClassPtr, "<>2__current");
				ResourceFallbackManager._GetEnumerator_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceFallbackManager._GetEnumerator_d__5>.NativeClassPtr, "<>4__this");
				ResourceFallbackManager._GetEnumerator_d__5.NativeFieldInfoPtr__currentCulture_5__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceFallbackManager._GetEnumerator_d__5>.NativeClassPtr, "<currentCulture>5__1");
				ResourceFallbackManager._GetEnumerator_d__5.NativeFieldInfoPtr__reachedNeutralResourcesCulture_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceFallbackManager._GetEnumerator_d__5>.NativeClassPtr, "<reachedNeutralResourcesCulture>5__2");
				ResourceFallbackManager._GetEnumerator_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceFallbackManager._GetEnumerator_d__5>.NativeClassPtr, 100667902);
				ResourceFallbackManager._GetEnumerator_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceFallbackManager._GetEnumerator_d__5>.NativeClassPtr, 100667903);
				ResourceFallbackManager._GetEnumerator_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceFallbackManager._GetEnumerator_d__5>.NativeClassPtr, 100667904);
				ResourceFallbackManager._GetEnumerator_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Globalization_CultureInfo__get_Current_Private_Virtual_Final_New_get_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceFallbackManager._GetEnumerator_d__5>.NativeClassPtr, 100667905);
				ResourceFallbackManager._GetEnumerator_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceFallbackManager._GetEnumerator_d__5>.NativeClassPtr, 100667906);
				ResourceFallbackManager._GetEnumerator_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceFallbackManager._GetEnumerator_d__5>.NativeClassPtr, 100667907);
			}

			// Token: 0x06005260 RID: 21088 RVA: 0x00174534 File Offset: 0x00172734
			[CallerCount(0)]
			public unsafe _GetEnumerator_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResourceFallbackManager._GetEnumerator_d__5>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceFallbackManager._GetEnumerator_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005261 RID: 21089 RVA: 0x0017457C File Offset: 0x0017277C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceFallbackManager._GetEnumerator_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005262 RID: 21090 RVA: 0x001745B0 File Offset: 0x001727B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185196, XrefRangeEnd = 185197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceFallbackManager._GetEnumerator_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001522 RID: 5410
			// (get) Token: 0x06005263 RID: 21091 RVA: 0x001745EC File Offset: 0x001727EC
			public unsafe CultureInfo System.Collections.Generic.IEnumerator<System.Globalization.CultureInfo>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceFallbackManager._GetEnumerator_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Globalization_CultureInfo__get_Current_Private_Virtual_Final_New_get_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr3) : null;
				}
			}

			// Token: 0x06005264 RID: 21092 RVA: 0x0017462C File Offset: 0x0017282C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185197, XrefRangeEnd = 185202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceFallbackManager._GetEnumerator_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001523 RID: 5411
			// (get) Token: 0x06005265 RID: 21093 RVA: 0x00174660 File Offset: 0x00172860
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceFallbackManager._GetEnumerator_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005266 RID: 21094 RVA: 0x0001EFA3 File Offset: 0x0001D1A3
			public _GetEnumerator_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700151D RID: 5405
			// (get) Token: 0x06005267 RID: 21095 RVA: 0x001746A0 File Offset: 0x001728A0
			// (set) Token: 0x06005268 RID: 21096 RVA: 0x0001EFAC File Offset: 0x0001D1AC
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceFallbackManager._GetEnumerator_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceFallbackManager._GetEnumerator_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700151E RID: 5406
			// (get) Token: 0x06005269 RID: 21097 RVA: 0x001746C8 File Offset: 0x001728C8
			// (set) Token: 0x0600526A RID: 21098 RVA: 0x0001EFC7 File Offset: 0x0001D1C7
			public unsafe CultureInfo __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceFallbackManager._GetEnumerator_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceFallbackManager._GetEnumerator_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700151F RID: 5407
			// (get) Token: 0x0600526B RID: 21099 RVA: 0x001746F8 File Offset: 0x001728F8
			// (set) Token: 0x0600526C RID: 21100 RVA: 0x0001EFE6 File Offset: 0x0001D1E6
			public unsafe ResourceFallbackManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceFallbackManager._GetEnumerator_d__5.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResourceFallbackManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceFallbackManager._GetEnumerator_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001520 RID: 5408
			// (get) Token: 0x0600526D RID: 21101 RVA: 0x00174728 File Offset: 0x00172928
			// (set) Token: 0x0600526E RID: 21102 RVA: 0x0001F005 File Offset: 0x0001D205
			public unsafe CultureInfo _currentCulture_5__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceFallbackManager._GetEnumerator_d__5.NativeFieldInfoPtr__currentCulture_5__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceFallbackManager._GetEnumerator_d__5.NativeFieldInfoPtr__currentCulture_5__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001521 RID: 5409
			// (get) Token: 0x0600526F RID: 21103 RVA: 0x00174758 File Offset: 0x00172958
			// (set) Token: 0x06005270 RID: 21104 RVA: 0x0001F024 File Offset: 0x0001D224
			public unsafe bool _reachedNeutralResourcesCulture_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceFallbackManager._GetEnumerator_d__5.NativeFieldInfoPtr__reachedNeutralResourcesCulture_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceFallbackManager._GetEnumerator_d__5.NativeFieldInfoPtr__reachedNeutralResourcesCulture_5__2)) = value;
				}
			}

			// Token: 0x040042E1 RID: 17121
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040042E2 RID: 17122
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040042E3 RID: 17123
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040042E4 RID: 17124
			private static readonly IntPtr NativeFieldInfoPtr__currentCulture_5__1;

			// Token: 0x040042E5 RID: 17125
			private static readonly IntPtr NativeFieldInfoPtr__reachedNeutralResourcesCulture_5__2;

			// Token: 0x040042E6 RID: 17126
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040042E7 RID: 17127
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040042E8 RID: 17128
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040042E9 RID: 17129
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Globalization_CultureInfo__get_Current_Private_Virtual_Final_New_get_CultureInfo_0;

			// Token: 0x040042EA RID: 17130
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040042EB RID: 17131
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
