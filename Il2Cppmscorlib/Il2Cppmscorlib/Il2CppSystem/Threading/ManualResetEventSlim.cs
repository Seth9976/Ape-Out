using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x02000263 RID: 611
	public class ManualResetEventSlim : Object
	{
		// Token: 0x06002A9F RID: 10911 RVA: 0x000DEC38 File Offset: 0x000DCE38
		// Note: this type is marked as 'beforefieldinit'.
		static ManualResetEventSlim()
		{
			Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "ManualResetEventSlim");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr);
			ManualResetEventSlim.NativeFieldInfoPtr_DEFAULT_SPIN_SP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, "DEFAULT_SPIN_SP");
			ManualResetEventSlim.NativeFieldInfoPtr_DEFAULT_SPIN_MP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, "DEFAULT_SPIN_MP");
			ManualResetEventSlim.NativeFieldInfoPtr_m_lock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, "m_lock");
			ManualResetEventSlim.NativeFieldInfoPtr_m_eventObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, "m_eventObj");
			ManualResetEventSlim.NativeFieldInfoPtr_m_combinedState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, "m_combinedState");
			ManualResetEventSlim.NativeFieldInfoPtr_SignalledState_BitMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, "SignalledState_BitMask");
			ManualResetEventSlim.NativeFieldInfoPtr_SignalledState_ShiftCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, "SignalledState_ShiftCount");
			ManualResetEventSlim.NativeFieldInfoPtr_Dispose_BitMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, "Dispose_BitMask");
			ManualResetEventSlim.NativeFieldInfoPtr_SpinCountState_BitMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, "SpinCountState_BitMask");
			ManualResetEventSlim.NativeFieldInfoPtr_SpinCountState_ShiftCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, "SpinCountState_ShiftCount");
			ManualResetEventSlim.NativeFieldInfoPtr_SpinCountState_MaxValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, "SpinCountState_MaxValue");
			ManualResetEventSlim.NativeFieldInfoPtr_NumWaitersState_BitMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, "NumWaitersState_BitMask");
			ManualResetEventSlim.NativeFieldInfoPtr_NumWaitersState_ShiftCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, "NumWaitersState_ShiftCount");
			ManualResetEventSlim.NativeFieldInfoPtr_NumWaitersState_MaxValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, "NumWaitersState_MaxValue");
			ManualResetEventSlim.NativeFieldInfoPtr_s_cancellationTokenCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, "s_cancellationTokenCallback");
			ManualResetEventSlim.NativeMethodInfoPtr_get_WaitHandle_Public_get_WaitHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, 100670155);
			ManualResetEventSlim.NativeMethodInfoPtr_get_IsSet_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, 100670156);
			ManualResetEventSlim.NativeMethodInfoPtr_set_IsSet_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, 100670157);
			ManualResetEventSlim.NativeMethodInfoPtr_get_SpinCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, 100670158);
			ManualResetEventSlim.NativeMethodInfoPtr_set_SpinCount_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, 100670159);
			ManualResetEventSlim.NativeMethodInfoPtr_get_Waiters_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, 100670160);
			ManualResetEventSlim.NativeMethodInfoPtr_set_Waiters_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, 100670161);
			ManualResetEventSlim.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, 100670162);
			ManualResetEventSlim.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, 100670163);
			ManualResetEventSlim.NativeMethodInfoPtr_Initialize_Private_Void_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, 100670164);
			ManualResetEventSlim.NativeMethodInfoPtr_EnsureLockObjectCreated_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, 100670165);
			ManualResetEventSlim.NativeMethodInfoPtr_LazyInitializeEvent_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, 100670166);
			ManualResetEventSlim.NativeMethodInfoPtr_Set_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, 100670167);
			ManualResetEventSlim.NativeMethodInfoPtr_Set_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, 100670168);
			ManualResetEventSlim.NativeMethodInfoPtr_Wait_Public_Boolean_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, 100670169);
			ManualResetEventSlim.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, 100670170);
			ManualResetEventSlim.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, 100670171);
			ManualResetEventSlim.NativeMethodInfoPtr_ThrowIfDisposed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, 100670172);
			ManualResetEventSlim.NativeMethodInfoPtr_CancellationTokenCallback_Private_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, 100670173);
			ManualResetEventSlim.NativeMethodInfoPtr_UpdateStateAtomically_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, 100670174);
			ManualResetEventSlim.NativeMethodInfoPtr_ExtractStatePortionAndShiftRight_Private_Static_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, 100670175);
			ManualResetEventSlim.NativeMethodInfoPtr_ExtractStatePortion_Private_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, 100670176);
		}

		// Token: 0x17000A13 RID: 2579
		// (get) Token: 0x06002AA0 RID: 10912 RVA: 0x000DEF4C File Offset: 0x000DD14C
		public unsafe WaitHandle WaitHandle
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200503, XrefRangeEnd = 200505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManualResetEventSlim.NativeMethodInfoPtr_get_WaitHandle_Public_get_WaitHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WaitHandle>(intPtr3) : null;
			}
		}

		// Token: 0x17000A14 RID: 2580
		// (get) Token: 0x06002AA1 RID: 10913 RVA: 0x000DEF8C File Offset: 0x000DD18C
		// (set) Token: 0x06002AA2 RID: 10914 RVA: 0x000DEFC8 File Offset: 0x000DD1C8
		public unsafe bool IsSet
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 200508, RefRangeEnd = 200510, XrefRangeStart = 200505, XrefRangeEnd = 200508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManualResetEventSlim.NativeMethodInfoPtr_get_IsSet_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200510, XrefRangeEnd = 200512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManualResetEventSlim.NativeMethodInfoPtr_set_IsSet_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A15 RID: 2581
		// (get) Token: 0x06002AA3 RID: 10915 RVA: 0x000DF008 File Offset: 0x000DD208
		// (set) Token: 0x06002AA4 RID: 10916 RVA: 0x000DF044 File Offset: 0x000DD244
		public unsafe int SpinCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200512, XrefRangeEnd = 200515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManualResetEventSlim.NativeMethodInfoPtr_get_SpinCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManualResetEventSlim.NativeMethodInfoPtr_set_SpinCount_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A16 RID: 2582
		// (get) Token: 0x06002AA5 RID: 10917 RVA: 0x000DF084 File Offset: 0x000DD284
		// (set) Token: 0x06002AA6 RID: 10918 RVA: 0x000DF0C0 File Offset: 0x000DD2C0
		public unsafe int Waiters
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 200518, RefRangeEnd = 200521, XrefRangeStart = 200515, XrefRangeEnd = 200518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManualResetEventSlim.NativeMethodInfoPtr_get_Waiters_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 200523, RefRangeEnd = 200526, XrefRangeStart = 200521, XrefRangeEnd = 200523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManualResetEventSlim.NativeMethodInfoPtr_set_Waiters_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002AA7 RID: 10919 RVA: 0x000DF100 File Offset: 0x000DD300
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200526, XrefRangeEnd = 200527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ManualResetEventSlim(bool initialState)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref initialState;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManualResetEventSlim.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002AA8 RID: 10920 RVA: 0x000DF148 File Offset: 0x000DD348
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200527, XrefRangeEnd = 200528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ManualResetEventSlim(bool initialState, int spinCount)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref initialState;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref spinCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManualResetEventSlim.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AA9 RID: 10921 RVA: 0x000DF1A0 File Offset: 0x000DD3A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200528, XrefRangeEnd = 200529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(bool initialState, int spinCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref initialState;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref spinCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManualResetEventSlim.NativeMethodInfoPtr_Initialize_Private_Void_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AAA RID: 10922 RVA: 0x000DF1EC File Offset: 0x000DD3EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200529, XrefRangeEnd = 200532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnsureLockObjectCreated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManualResetEventSlim.NativeMethodInfoPtr_EnsureLockObjectCreated_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AAB RID: 10923 RVA: 0x000DF220 File Offset: 0x000DD420
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 200546, RefRangeEnd = 200548, XrefRangeStart = 200532, XrefRangeEnd = 200546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool LazyInitializeEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManualResetEventSlim.NativeMethodInfoPtr_LazyInitializeEvent_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002AAC RID: 10924 RVA: 0x000DF25C File Offset: 0x000DD45C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200548, XrefRangeEnd = 200549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManualResetEventSlim.NativeMethodInfoPtr_Set_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AAD RID: 10925 RVA: 0x000DF290 File Offset: 0x000DD490
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 200562, RefRangeEnd = 200573, XrefRangeStart = 200549, XrefRangeEnd = 200562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set(bool duringCancellation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref duringCancellation;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManualResetEventSlim.NativeMethodInfoPtr_Set_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002AAE RID: 10926 RVA: 0x000DF2D0 File Offset: 0x000DD4D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 200630, RefRangeEnd = 200632, XrefRangeStart = 200573, XrefRangeEnd = 200630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Wait(int millisecondsTimeout, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref millisecondsTimeout;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManualResetEventSlim.NativeMethodInfoPtr_Wait_Public_Boolean_Int32_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002AAF RID: 10927 RVA: 0x000DF330 File Offset: 0x000DD530
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 200636, RefRangeEnd = 200638, XrefRangeStart = 200632, XrefRangeEnd = 200636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManualResetEventSlim.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AB0 RID: 10928 RVA: 0x000DF364 File Offset: 0x000DD564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200638, XrefRangeEnd = 200641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ManualResetEventSlim.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002AB1 RID: 10929 RVA: 0x000DF3B0 File Offset: 0x000DD5B0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 200641, RefRangeEnd = 200644, XrefRangeStart = 200641, XrefRangeEnd = 200641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowIfDisposed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManualResetEventSlim.NativeMethodInfoPtr_ThrowIfDisposed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AB2 RID: 10930 RVA: 0x000DF3E4 File Offset: 0x000DD5E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200644, XrefRangeEnd = 200650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CancellationTokenCallback(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManualResetEventSlim.NativeMethodInfoPtr_CancellationTokenCallback_Private_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002AB3 RID: 10931 RVA: 0x000DF41C File Offset: 0x000DD61C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200650, XrefRangeEnd = 200652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateStateAtomically(int newBits, int updateBitsMask)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newBits;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref updateBitsMask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManualResetEventSlim.NativeMethodInfoPtr_UpdateStateAtomically_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AB4 RID: 10932 RVA: 0x000DF468 File Offset: 0x000DD668
		[CallerCount(0)]
		public unsafe static int ExtractStatePortionAndShiftRight(int state, int mask, int rightBitShiftCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref state;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mask;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rightBitShiftCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManualResetEventSlim.NativeMethodInfoPtr_ExtractStatePortionAndShiftRight_Private_Static_Int32_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002AB5 RID: 10933 RVA: 0x000DF4C4 File Offset: 0x000DD6C4
		[CallerCount(0)]
		public unsafe static int ExtractStatePortion(int state, int mask)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref state;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManualResetEventSlim.NativeMethodInfoPtr_ExtractStatePortion_Private_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002AB6 RID: 10934 RVA: 0x0000EB8D File Offset: 0x0000CD8D
		public ManualResetEventSlim(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A04 RID: 2564
		// (get) Token: 0x06002AB7 RID: 10935 RVA: 0x000DF510 File Offset: 0x000DD710
		// (set) Token: 0x06002AB8 RID: 10936 RVA: 0x0000EB96 File Offset: 0x0000CD96
		public unsafe static int DEFAULT_SPIN_SP
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ManualResetEventSlim.NativeFieldInfoPtr_DEFAULT_SPIN_SP, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ManualResetEventSlim.NativeFieldInfoPtr_DEFAULT_SPIN_SP, (void*)(&value));
			}
		}

		// Token: 0x17000A05 RID: 2565
		// (get) Token: 0x06002AB9 RID: 10937 RVA: 0x000DF52C File Offset: 0x000DD72C
		// (set) Token: 0x06002ABA RID: 10938 RVA: 0x0000EBA4 File Offset: 0x0000CDA4
		public unsafe static int DEFAULT_SPIN_MP
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ManualResetEventSlim.NativeFieldInfoPtr_DEFAULT_SPIN_MP, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ManualResetEventSlim.NativeFieldInfoPtr_DEFAULT_SPIN_MP, (void*)(&value));
			}
		}

		// Token: 0x17000A06 RID: 2566
		// (get) Token: 0x06002ABB RID: 10939 RVA: 0x000DF548 File Offset: 0x000DD748
		// (set) Token: 0x06002ABC RID: 10940 RVA: 0x0000EBB2 File Offset: 0x0000CDB2
		public unsafe Object m_lock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManualResetEventSlim.NativeFieldInfoPtr_m_lock);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManualResetEventSlim.NativeFieldInfoPtr_m_lock), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A07 RID: 2567
		// (get) Token: 0x06002ABD RID: 10941 RVA: 0x000DF578 File Offset: 0x000DD778
		// (set) Token: 0x06002ABE RID: 10942 RVA: 0x0000EBD1 File Offset: 0x0000CDD1
		public unsafe ManualResetEvent m_eventObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManualResetEventSlim.NativeFieldInfoPtr_m_eventObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManualResetEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManualResetEventSlim.NativeFieldInfoPtr_m_eventObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A08 RID: 2568
		// (get) Token: 0x06002ABF RID: 10943 RVA: 0x000DF5A8 File Offset: 0x000DD7A8
		// (set) Token: 0x06002AC0 RID: 10944 RVA: 0x0000EBF0 File Offset: 0x0000CDF0
		public unsafe int m_combinedState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManualResetEventSlim.NativeFieldInfoPtr_m_combinedState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManualResetEventSlim.NativeFieldInfoPtr_m_combinedState)) = value;
			}
		}

		// Token: 0x17000A09 RID: 2569
		// (get) Token: 0x06002AC1 RID: 10945 RVA: 0x000DF5D0 File Offset: 0x000DD7D0
		// (set) Token: 0x06002AC2 RID: 10946 RVA: 0x0000EC0B File Offset: 0x0000CE0B
		public unsafe static int SignalledState_BitMask
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ManualResetEventSlim.NativeFieldInfoPtr_SignalledState_BitMask, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ManualResetEventSlim.NativeFieldInfoPtr_SignalledState_BitMask, (void*)(&value));
			}
		}

		// Token: 0x17000A0A RID: 2570
		// (get) Token: 0x06002AC3 RID: 10947 RVA: 0x000DF5EC File Offset: 0x000DD7EC
		// (set) Token: 0x06002AC4 RID: 10948 RVA: 0x0000EC19 File Offset: 0x0000CE19
		public unsafe static int SignalledState_ShiftCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ManualResetEventSlim.NativeFieldInfoPtr_SignalledState_ShiftCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ManualResetEventSlim.NativeFieldInfoPtr_SignalledState_ShiftCount, (void*)(&value));
			}
		}

		// Token: 0x17000A0B RID: 2571
		// (get) Token: 0x06002AC5 RID: 10949 RVA: 0x000DF608 File Offset: 0x000DD808
		// (set) Token: 0x06002AC6 RID: 10950 RVA: 0x0000EC27 File Offset: 0x0000CE27
		public unsafe static int Dispose_BitMask
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ManualResetEventSlim.NativeFieldInfoPtr_Dispose_BitMask, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ManualResetEventSlim.NativeFieldInfoPtr_Dispose_BitMask, (void*)(&value));
			}
		}

		// Token: 0x17000A0C RID: 2572
		// (get) Token: 0x06002AC7 RID: 10951 RVA: 0x000DF624 File Offset: 0x000DD824
		// (set) Token: 0x06002AC8 RID: 10952 RVA: 0x0000EC35 File Offset: 0x0000CE35
		public unsafe static int SpinCountState_BitMask
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ManualResetEventSlim.NativeFieldInfoPtr_SpinCountState_BitMask, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ManualResetEventSlim.NativeFieldInfoPtr_SpinCountState_BitMask, (void*)(&value));
			}
		}

		// Token: 0x17000A0D RID: 2573
		// (get) Token: 0x06002AC9 RID: 10953 RVA: 0x000DF640 File Offset: 0x000DD840
		// (set) Token: 0x06002ACA RID: 10954 RVA: 0x0000EC43 File Offset: 0x0000CE43
		public unsafe static int SpinCountState_ShiftCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ManualResetEventSlim.NativeFieldInfoPtr_SpinCountState_ShiftCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ManualResetEventSlim.NativeFieldInfoPtr_SpinCountState_ShiftCount, (void*)(&value));
			}
		}

		// Token: 0x17000A0E RID: 2574
		// (get) Token: 0x06002ACB RID: 10955 RVA: 0x000DF65C File Offset: 0x000DD85C
		// (set) Token: 0x06002ACC RID: 10956 RVA: 0x0000EC51 File Offset: 0x0000CE51
		public unsafe static int SpinCountState_MaxValue
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ManualResetEventSlim.NativeFieldInfoPtr_SpinCountState_MaxValue, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ManualResetEventSlim.NativeFieldInfoPtr_SpinCountState_MaxValue, (void*)(&value));
			}
		}

		// Token: 0x17000A0F RID: 2575
		// (get) Token: 0x06002ACD RID: 10957 RVA: 0x000DF678 File Offset: 0x000DD878
		// (set) Token: 0x06002ACE RID: 10958 RVA: 0x0000EC5F File Offset: 0x0000CE5F
		public unsafe static int NumWaitersState_BitMask
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ManualResetEventSlim.NativeFieldInfoPtr_NumWaitersState_BitMask, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ManualResetEventSlim.NativeFieldInfoPtr_NumWaitersState_BitMask, (void*)(&value));
			}
		}

		// Token: 0x17000A10 RID: 2576
		// (get) Token: 0x06002ACF RID: 10959 RVA: 0x000DF694 File Offset: 0x000DD894
		// (set) Token: 0x06002AD0 RID: 10960 RVA: 0x0000EC6D File Offset: 0x0000CE6D
		public unsafe static int NumWaitersState_ShiftCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ManualResetEventSlim.NativeFieldInfoPtr_NumWaitersState_ShiftCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ManualResetEventSlim.NativeFieldInfoPtr_NumWaitersState_ShiftCount, (void*)(&value));
			}
		}

		// Token: 0x17000A11 RID: 2577
		// (get) Token: 0x06002AD1 RID: 10961 RVA: 0x000DF6B0 File Offset: 0x000DD8B0
		// (set) Token: 0x06002AD2 RID: 10962 RVA: 0x0000EC7B File Offset: 0x0000CE7B
		public unsafe static int NumWaitersState_MaxValue
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ManualResetEventSlim.NativeFieldInfoPtr_NumWaitersState_MaxValue, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ManualResetEventSlim.NativeFieldInfoPtr_NumWaitersState_MaxValue, (void*)(&value));
			}
		}

		// Token: 0x17000A12 RID: 2578
		// (get) Token: 0x06002AD3 RID: 10963 RVA: 0x000DF6CC File Offset: 0x000DD8CC
		// (set) Token: 0x06002AD4 RID: 10964 RVA: 0x0000EC89 File Offset: 0x0000CE89
		public unsafe static Action<Object> s_cancellationTokenCallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ManualResetEventSlim.NativeFieldInfoPtr_s_cancellationTokenCallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ManualResetEventSlim.NativeFieldInfoPtr_s_cancellationTokenCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002573 RID: 9587
		private static readonly IntPtr NativeFieldInfoPtr_DEFAULT_SPIN_SP;

		// Token: 0x04002574 RID: 9588
		private static readonly IntPtr NativeFieldInfoPtr_DEFAULT_SPIN_MP;

		// Token: 0x04002575 RID: 9589
		private static readonly IntPtr NativeFieldInfoPtr_m_lock;

		// Token: 0x04002576 RID: 9590
		private static readonly IntPtr NativeFieldInfoPtr_m_eventObj;

		// Token: 0x04002577 RID: 9591
		private static readonly IntPtr NativeFieldInfoPtr_m_combinedState;

		// Token: 0x04002578 RID: 9592
		private static readonly IntPtr NativeFieldInfoPtr_SignalledState_BitMask;

		// Token: 0x04002579 RID: 9593
		private static readonly IntPtr NativeFieldInfoPtr_SignalledState_ShiftCount;

		// Token: 0x0400257A RID: 9594
		private static readonly IntPtr NativeFieldInfoPtr_Dispose_BitMask;

		// Token: 0x0400257B RID: 9595
		private static readonly IntPtr NativeFieldInfoPtr_SpinCountState_BitMask;

		// Token: 0x0400257C RID: 9596
		private static readonly IntPtr NativeFieldInfoPtr_SpinCountState_ShiftCount;

		// Token: 0x0400257D RID: 9597
		private static readonly IntPtr NativeFieldInfoPtr_SpinCountState_MaxValue;

		// Token: 0x0400257E RID: 9598
		private static readonly IntPtr NativeFieldInfoPtr_NumWaitersState_BitMask;

		// Token: 0x0400257F RID: 9599
		private static readonly IntPtr NativeFieldInfoPtr_NumWaitersState_ShiftCount;

		// Token: 0x04002580 RID: 9600
		private static readonly IntPtr NativeFieldInfoPtr_NumWaitersState_MaxValue;

		// Token: 0x04002581 RID: 9601
		private static readonly IntPtr NativeFieldInfoPtr_s_cancellationTokenCallback;

		// Token: 0x04002582 RID: 9602
		private static readonly IntPtr NativeMethodInfoPtr_get_WaitHandle_Public_get_WaitHandle_0;

		// Token: 0x04002583 RID: 9603
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSet_Public_get_Boolean_0;

		// Token: 0x04002584 RID: 9604
		private static readonly IntPtr NativeMethodInfoPtr_set_IsSet_Private_set_Void_Boolean_0;

		// Token: 0x04002585 RID: 9605
		private static readonly IntPtr NativeMethodInfoPtr_get_SpinCount_Public_get_Int32_0;

		// Token: 0x04002586 RID: 9606
		private static readonly IntPtr NativeMethodInfoPtr_set_SpinCount_Private_set_Void_Int32_0;

		// Token: 0x04002587 RID: 9607
		private static readonly IntPtr NativeMethodInfoPtr_get_Waiters_Private_get_Int32_0;

		// Token: 0x04002588 RID: 9608
		private static readonly IntPtr NativeMethodInfoPtr_set_Waiters_Private_set_Void_Int32_0;

		// Token: 0x04002589 RID: 9609
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x0400258A RID: 9610
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Int32_0;

		// Token: 0x0400258B RID: 9611
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Private_Void_Boolean_Int32_0;

		// Token: 0x0400258C RID: 9612
		private static readonly IntPtr NativeMethodInfoPtr_EnsureLockObjectCreated_Private_Void_0;

		// Token: 0x0400258D RID: 9613
		private static readonly IntPtr NativeMethodInfoPtr_LazyInitializeEvent_Private_Boolean_0;

		// Token: 0x0400258E RID: 9614
		private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Void_0;

		// Token: 0x0400258F RID: 9615
		private static readonly IntPtr NativeMethodInfoPtr_Set_Private_Void_Boolean_0;

		// Token: 0x04002590 RID: 9616
		private static readonly IntPtr NativeMethodInfoPtr_Wait_Public_Boolean_Int32_CancellationToken_0;

		// Token: 0x04002591 RID: 9617
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04002592 RID: 9618
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x04002593 RID: 9619
		private static readonly IntPtr NativeMethodInfoPtr_ThrowIfDisposed_Private_Void_0;

		// Token: 0x04002594 RID: 9620
		private static readonly IntPtr NativeMethodInfoPtr_CancellationTokenCallback_Private_Static_Void_Object_0;

		// Token: 0x04002595 RID: 9621
		private static readonly IntPtr NativeMethodInfoPtr_UpdateStateAtomically_Private_Void_Int32_Int32_0;

		// Token: 0x04002596 RID: 9622
		private static readonly IntPtr NativeMethodInfoPtr_ExtractStatePortionAndShiftRight_Private_Static_Int32_Int32_Int32_Int32_0;

		// Token: 0x04002597 RID: 9623
		private static readonly IntPtr NativeMethodInfoPtr_ExtractStatePortion_Private_Static_Int32_Int32_Int32_0;
	}
}
