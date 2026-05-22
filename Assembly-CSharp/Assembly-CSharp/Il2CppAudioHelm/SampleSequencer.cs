using System;
using Il2Cpp;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppAudioHelm
{
	// Token: 0x02000287 RID: 647
	public class SampleSequencer : Sequencer
	{
		// Token: 0x060047ED RID: 18413 RVA: 0x0010D028 File Offset: 0x0010B228
		// Note: this type is marked as 'beforefieldinit'.
		static SampleSequencer()
		{
			Il2CppClassPointerStore<SampleSequencer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "AudioHelm", "SampleSequencer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SampleSequencer>.NativeClassPtr);
			SampleSequencer.NativeFieldInfoPtr_lastWindowTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SampleSequencer>.NativeClassPtr, "lastWindowTime");
			SampleSequencer.NativeFieldInfoPtr_Sampler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SampleSequencer>.NativeClassPtr, "Sampler");
			SampleSequencer.NativeFieldInfoPtr_LTM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SampleSequencer>.NativeClassPtr, "LTM");
			SampleSequencer.NativeFieldInfoPtr_MTM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SampleSequencer>.NativeClassPtr, "MTM");
			SampleSequencer.NativeFieldInfoPtr_numCycles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SampleSequencer>.NativeClassPtr, "numCycles");
			SampleSequencer.NativeFieldInfoPtr_waitTillNextCycle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SampleSequencer>.NativeClassPtr, "waitTillNextCycle");
			SampleSequencer.NativeFieldInfoPtr_RandomNumGen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SampleSequencer>.NativeClassPtr, "RandomNumGen");
			SampleSequencer.NativeFieldInfoPtr_lookaheadTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SampleSequencer>.NativeClassPtr, "lookaheadTime");
			SampleSequencer.NativeFieldInfoPtr_selectedTransition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SampleSequencer>.NativeClassPtr, "selectedTransition");
			SampleSequencer.NativeFieldInfoPtr_updateStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SampleSequencer>.NativeClassPtr, "updateStartTime");
			SampleSequencer.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SampleSequencer>.NativeClassPtr, "position");
			SampleSequencer.NativeFieldInfoPtr_sixteenthTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SampleSequencer>.NativeClassPtr, "sixteenthTime");
			SampleSequencer.NativeFieldInfoPtr_currentTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SampleSequencer>.NativeClassPtr, "currentTime");
			SampleSequencer.NativeFieldInfoPtr_sequencerTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SampleSequencer>.NativeClassPtr, "sequencerTime");
			SampleSequencer.NativeFieldInfoPtr_windowMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SampleSequencer>.NativeClassPtr, "windowMax");
			SampleSequencer.NativeFieldInfoPtr_internalLastWindowMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SampleSequencer>.NativeClassPtr, "internalLastWindowMax");
			SampleSequencer.NativeFieldInfoPtr_internalWindowMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SampleSequencer>.NativeClassPtr, "internalWindowMax");
			SampleSequencer.NativeFieldInfoPtr_startSearch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SampleSequencer>.NativeClassPtr, "startSearch");
			SampleSequencer.NativeFieldInfoPtr_endSearch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SampleSequencer>.NativeClassPtr, "endSearch");
			SampleSequencer.NativeFieldInfoPtr_theseNotes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SampleSequencer>.NativeClassPtr, "theseNotes");
			SampleSequencer.NativeFieldInfoPtr_startTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SampleSequencer>.NativeClassPtr, "startTime");
			SampleSequencer.NativeFieldInfoPtr_endTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SampleSequencer>.NativeClassPtr, "endTime");
			SampleSequencer.NativeFieldInfoPtr_timeToStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SampleSequencer>.NativeClassPtr, "timeToStart");
			SampleSequencer.NativeFieldInfoPtr_timeToEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SampleSequencer>.NativeClassPtr, "timeToEnd");
			SampleSequencer.NativeFieldInfoPtr_sendVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SampleSequencer>.NativeClassPtr, "sendVelocity");
			SampleSequencer.NativeFieldInfoPtr_altBools = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SampleSequencer>.NativeClassPtr, "altBools");
			SampleSequencer.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SampleSequencer>.NativeClassPtr, 100670715);
			SampleSequencer.NativeMethodInfoPtr_FindTransitionManagers_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SampleSequencer>.NativeClassPtr, 100670716);
			SampleSequencer.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SampleSequencer>.NativeClassPtr, 100670717);
			SampleSequencer.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SampleSequencer>.NativeClassPtr, 100670718);
			SampleSequencer.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SampleSequencer>.NativeClassPtr, 100670719);
			SampleSequencer.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SampleSequencer>.NativeClassPtr, 100670720);
			SampleSequencer.NativeMethodInfoPtr_AllNotesOff_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SampleSequencer>.NativeClassPtr, 100670721);
			SampleSequencer.NativeMethodInfoPtr_NoteOn_Public_Virtual_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SampleSequencer>.NativeClassPtr, 100670722);
			SampleSequencer.NativeMethodInfoPtr_NoteOff_Public_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SampleSequencer>.NativeClassPtr, 100670723);
			SampleSequencer.NativeMethodInfoPtr_EnableComponent_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SampleSequencer>.NativeClassPtr, 100670724);
			SampleSequencer.NativeMethodInfoPtr_StartOnNextCycle_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SampleSequencer>.NativeClassPtr, 100670725);
			SampleSequencer.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SampleSequencer>.NativeClassPtr, 100670726);
			SampleSequencer.NativeMethodInfoPtr_DoUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SampleSequencer>.NativeClassPtr, 100670727);
			SampleSequencer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SampleSequencer>.NativeClassPtr, 100670728);
		}

		// Token: 0x060047EE RID: 18414 RVA: 0x0010D378 File Offset: 0x0010B578
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117014, XrefRangeEnd = 117029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SampleSequencer.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047EF RID: 18415 RVA: 0x0010D3AC File Offset: 0x0010B5AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117029, XrefRangeEnd = 117033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FindTransitionManagers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SampleSequencer.NativeMethodInfoPtr_FindTransitionManagers_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047F0 RID: 18416 RVA: 0x0010D3E0 File Offset: 0x0010B5E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117033, XrefRangeEnd = 117042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SampleSequencer.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047F1 RID: 18417 RVA: 0x0010D414 File Offset: 0x0010B614
		[CallerCount(0)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SampleSequencer.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047F2 RID: 18418 RVA: 0x0010D448 File Offset: 0x0010B648
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117042, XrefRangeEnd = 117047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SampleSequencer.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047F3 RID: 18419 RVA: 0x0010D484 File Offset: 0x0010B684
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117047, XrefRangeEnd = 117048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SampleSequencer.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047F4 RID: 18420 RVA: 0x0010D4C0 File Offset: 0x0010B6C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117048, XrefRangeEnd = 117049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void AllNotesOff()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SampleSequencer.NativeMethodInfoPtr_AllNotesOff_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047F5 RID: 18421 RVA: 0x0010D4FC File Offset: 0x0010B6FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117049, XrefRangeEnd = 117050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NoteOn(int note, float velocity = 1f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref note;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref velocity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SampleSequencer.NativeMethodInfoPtr_NoteOn_Public_Virtual_Void_Int32_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047F6 RID: 18422 RVA: 0x0010D554 File Offset: 0x0010B754
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117050, XrefRangeEnd = 117052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NoteOff(int note)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref note;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SampleSequencer.NativeMethodInfoPtr_NoteOff_Public_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060047F7 RID: 18423 RVA: 0x0010D5A0 File Offset: 0x0010B7A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117052, XrefRangeEnd = 117056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnableComponent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SampleSequencer.NativeMethodInfoPtr_EnableComponent_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047F8 RID: 18424 RVA: 0x0010D5D4 File Offset: 0x0010B7D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117056, XrefRangeEnd = 117058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StartOnNextCycle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SampleSequencer.NativeMethodInfoPtr_StartOnNextCycle_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047F9 RID: 18425 RVA: 0x0010D610 File Offset: 0x0010B810
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117058, XrefRangeEnd = 117059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SampleSequencer.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047FA RID: 18426 RVA: 0x0010D644 File Offset: 0x0010B844
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 117085, RefRangeEnd = 117086, XrefRangeStart = 117059, XrefRangeEnd = 117085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SampleSequencer.NativeMethodInfoPtr_DoUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047FB RID: 18427 RVA: 0x0010D678 File Offset: 0x0010B878
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117086, XrefRangeEnd = 117093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SampleSequencer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SampleSequencer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SampleSequencer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047FC RID: 18428 RVA: 0x0002A49B File Offset: 0x0002869B
		public SampleSequencer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001A26 RID: 6694
		// (get) Token: 0x060047FD RID: 18429 RVA: 0x0010D6B4 File Offset: 0x0010B8B4
		// (set) Token: 0x060047FE RID: 18430 RVA: 0x0002A4A4 File Offset: 0x000286A4
		public unsafe double lastWindowTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SampleSequencer.NativeFieldInfoPtr_lastWindowTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SampleSequencer.NativeFieldInfoPtr_lastWindowTime)) = value;
			}
		}

		// Token: 0x17001A27 RID: 6695
		// (get) Token: 0x060047FF RID: 18431 RVA: 0x0010D6DC File Offset: 0x0010B8DC
		// (set) Token: 0x06004800 RID: 18432 RVA: 0x0002A4BF File Offset: 0x000286BF
		public unsafe Sampler Sampler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SampleSequencer.NativeFieldInfoPtr_Sampler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sampler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SampleSequencer.NativeFieldInfoPtr_Sampler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A28 RID: 6696
		// (get) Token: 0x06004801 RID: 18433 RVA: 0x0010D70C File Offset: 0x0010B90C
		// (set) Token: 0x06004802 RID: 18434 RVA: 0x0002A4DE File Offset: 0x000286DE
		public unsafe LevelTransitionManager LTM
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SampleSequencer.NativeFieldInfoPtr_LTM);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LevelTransitionManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SampleSequencer.NativeFieldInfoPtr_LTM), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A29 RID: 6697
		// (get) Token: 0x06004803 RID: 18435 RVA: 0x0010D73C File Offset: 0x0010B93C
		// (set) Token: 0x06004804 RID: 18436 RVA: 0x0002A4FD File Offset: 0x000286FD
		public unsafe MusicTransitionManager MTM
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SampleSequencer.NativeFieldInfoPtr_MTM);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MusicTransitionManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SampleSequencer.NativeFieldInfoPtr_MTM), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A2A RID: 6698
		// (get) Token: 0x06004805 RID: 18437 RVA: 0x0010D76C File Offset: 0x0010B96C
		// (set) Token: 0x06004806 RID: 18438 RVA: 0x0002A51C File Offset: 0x0002871C
		public unsafe int numCycles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SampleSequencer.NativeFieldInfoPtr_numCycles);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SampleSequencer.NativeFieldInfoPtr_numCycles)) = value;
			}
		}

		// Token: 0x17001A2B RID: 6699
		// (get) Token: 0x06004807 RID: 18439 RVA: 0x0010D794 File Offset: 0x0010B994
		// (set) Token: 0x06004808 RID: 18440 RVA: 0x0002A537 File Offset: 0x00028737
		public unsafe bool waitTillNextCycle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SampleSequencer.NativeFieldInfoPtr_waitTillNextCycle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SampleSequencer.NativeFieldInfoPtr_waitTillNextCycle)) = value;
			}
		}

		// Token: 0x17001A2C RID: 6700
		// (get) Token: 0x06004809 RID: 18441 RVA: 0x0010D7BC File Offset: 0x0010B9BC
		// (set) Token: 0x0600480A RID: 18442 RVA: 0x0002A552 File Offset: 0x00028752
		public unsafe Random RandomNumGen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SampleSequencer.NativeFieldInfoPtr_RandomNumGen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Random>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SampleSequencer.NativeFieldInfoPtr_RandomNumGen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A2D RID: 6701
		// (get) Token: 0x0600480B RID: 18443 RVA: 0x0010D7EC File Offset: 0x0010B9EC
		// (set) Token: 0x0600480C RID: 18444 RVA: 0x0002A571 File Offset: 0x00028771
		public unsafe static float lookaheadTime
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(SampleSequencer.NativeFieldInfoPtr_lookaheadTime, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SampleSequencer.NativeFieldInfoPtr_lookaheadTime, (void*)(&value));
			}
		}

		// Token: 0x17001A2E RID: 6702
		// (get) Token: 0x0600480D RID: 18445 RVA: 0x0010D808 File Offset: 0x0010BA08
		// (set) Token: 0x0600480E RID: 18446 RVA: 0x0002A57F File Offset: 0x0002877F
		public unsafe int selectedTransition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SampleSequencer.NativeFieldInfoPtr_selectedTransition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SampleSequencer.NativeFieldInfoPtr_selectedTransition)) = value;
			}
		}

		// Token: 0x17001A2F RID: 6703
		// (get) Token: 0x0600480F RID: 18447 RVA: 0x0010D830 File Offset: 0x0010BA30
		// (set) Token: 0x06004810 RID: 18448 RVA: 0x0002A59A File Offset: 0x0002879A
		public unsafe double updateStartTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SampleSequencer.NativeFieldInfoPtr_updateStartTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SampleSequencer.NativeFieldInfoPtr_updateStartTime)) = value;
			}
		}

		// Token: 0x17001A30 RID: 6704
		// (get) Token: 0x06004811 RID: 18449 RVA: 0x0010D858 File Offset: 0x0010BA58
		// (set) Token: 0x06004812 RID: 18450 RVA: 0x0002A5B5 File Offset: 0x000287B5
		public unsafe double position
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SampleSequencer.NativeFieldInfoPtr_position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SampleSequencer.NativeFieldInfoPtr_position)) = value;
			}
		}

		// Token: 0x17001A31 RID: 6705
		// (get) Token: 0x06004813 RID: 18451 RVA: 0x0010D880 File Offset: 0x0010BA80
		// (set) Token: 0x06004814 RID: 18452 RVA: 0x0002A5D0 File Offset: 0x000287D0
		public unsafe float sixteenthTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SampleSequencer.NativeFieldInfoPtr_sixteenthTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SampleSequencer.NativeFieldInfoPtr_sixteenthTime)) = value;
			}
		}

		// Token: 0x17001A32 RID: 6706
		// (get) Token: 0x06004815 RID: 18453 RVA: 0x0010D8A8 File Offset: 0x0010BAA8
		// (set) Token: 0x06004816 RID: 18454 RVA: 0x0002A5EB File Offset: 0x000287EB
		public unsafe double currentTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SampleSequencer.NativeFieldInfoPtr_currentTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SampleSequencer.NativeFieldInfoPtr_currentTime)) = value;
			}
		}

		// Token: 0x17001A33 RID: 6707
		// (get) Token: 0x06004817 RID: 18455 RVA: 0x0010D8D0 File Offset: 0x0010BAD0
		// (set) Token: 0x06004818 RID: 18456 RVA: 0x0002A606 File Offset: 0x00028806
		public unsafe double sequencerTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SampleSequencer.NativeFieldInfoPtr_sequencerTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SampleSequencer.NativeFieldInfoPtr_sequencerTime)) = value;
			}
		}

		// Token: 0x17001A34 RID: 6708
		// (get) Token: 0x06004819 RID: 18457 RVA: 0x0010D8F8 File Offset: 0x0010BAF8
		// (set) Token: 0x0600481A RID: 18458 RVA: 0x0002A621 File Offset: 0x00028821
		public unsafe double windowMax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SampleSequencer.NativeFieldInfoPtr_windowMax);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SampleSequencer.NativeFieldInfoPtr_windowMax)) = value;
			}
		}

		// Token: 0x17001A35 RID: 6709
		// (get) Token: 0x0600481B RID: 18459 RVA: 0x0010D920 File Offset: 0x0010BB20
		// (set) Token: 0x0600481C RID: 18460 RVA: 0x0002A63C File Offset: 0x0002883C
		public unsafe double internalLastWindowMax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SampleSequencer.NativeFieldInfoPtr_internalLastWindowMax);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SampleSequencer.NativeFieldInfoPtr_internalLastWindowMax)) = value;
			}
		}

		// Token: 0x17001A36 RID: 6710
		// (get) Token: 0x0600481D RID: 18461 RVA: 0x0010D948 File Offset: 0x0010BB48
		// (set) Token: 0x0600481E RID: 18462 RVA: 0x0002A657 File Offset: 0x00028857
		public unsafe double internalWindowMax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SampleSequencer.NativeFieldInfoPtr_internalWindowMax);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SampleSequencer.NativeFieldInfoPtr_internalWindowMax)) = value;
			}
		}

		// Token: 0x17001A37 RID: 6711
		// (get) Token: 0x0600481F RID: 18463 RVA: 0x0010D970 File Offset: 0x0010BB70
		// (set) Token: 0x06004820 RID: 18464 RVA: 0x0002A672 File Offset: 0x00028872
		public new unsafe float startSearch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SampleSequencer.NativeFieldInfoPtr_startSearch);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SampleSequencer.NativeFieldInfoPtr_startSearch)) = value;
			}
		}

		// Token: 0x17001A38 RID: 6712
		// (get) Token: 0x06004821 RID: 18465 RVA: 0x0010D998 File Offset: 0x0010BB98
		// (set) Token: 0x06004822 RID: 18466 RVA: 0x0002A68D File Offset: 0x0002888D
		public new unsafe float endSearch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SampleSequencer.NativeFieldInfoPtr_endSearch);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SampleSequencer.NativeFieldInfoPtr_endSearch)) = value;
			}
		}

		// Token: 0x17001A39 RID: 6713
		// (get) Token: 0x06004823 RID: 18467 RVA: 0x0010D9C0 File Offset: 0x0010BBC0
		// (set) Token: 0x06004824 RID: 18468 RVA: 0x0002A6A8 File Offset: 0x000288A8
		public unsafe Il2CppStructArray<Note> theseNotes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SampleSequencer.NativeFieldInfoPtr_theseNotes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Note>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SampleSequencer.NativeFieldInfoPtr_theseNotes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A3A RID: 6714
		// (get) Token: 0x06004825 RID: 18469 RVA: 0x0010D9F0 File Offset: 0x0010BBF0
		// (set) Token: 0x06004826 RID: 18470 RVA: 0x0002A6C7 File Offset: 0x000288C7
		public unsafe double startTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SampleSequencer.NativeFieldInfoPtr_startTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SampleSequencer.NativeFieldInfoPtr_startTime)) = value;
			}
		}

		// Token: 0x17001A3B RID: 6715
		// (get) Token: 0x06004827 RID: 18471 RVA: 0x0010DA18 File Offset: 0x0010BC18
		// (set) Token: 0x06004828 RID: 18472 RVA: 0x0002A6E2 File Offset: 0x000288E2
		public unsafe double endTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SampleSequencer.NativeFieldInfoPtr_endTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SampleSequencer.NativeFieldInfoPtr_endTime)) = value;
			}
		}

		// Token: 0x17001A3C RID: 6716
		// (get) Token: 0x06004829 RID: 18473 RVA: 0x0010DA40 File Offset: 0x0010BC40
		// (set) Token: 0x0600482A RID: 18474 RVA: 0x0002A6FD File Offset: 0x000288FD
		public unsafe double timeToStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SampleSequencer.NativeFieldInfoPtr_timeToStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SampleSequencer.NativeFieldInfoPtr_timeToStart)) = value;
			}
		}

		// Token: 0x17001A3D RID: 6717
		// (get) Token: 0x0600482B RID: 18475 RVA: 0x0010DA68 File Offset: 0x0010BC68
		// (set) Token: 0x0600482C RID: 18476 RVA: 0x0002A718 File Offset: 0x00028918
		public unsafe double timeToEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SampleSequencer.NativeFieldInfoPtr_timeToEnd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SampleSequencer.NativeFieldInfoPtr_timeToEnd)) = value;
			}
		}

		// Token: 0x17001A3E RID: 6718
		// (get) Token: 0x0600482D RID: 18477 RVA: 0x0010DA90 File Offset: 0x0010BC90
		// (set) Token: 0x0600482E RID: 18478 RVA: 0x0002A733 File Offset: 0x00028933
		public unsafe float sendVelocity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SampleSequencer.NativeFieldInfoPtr_sendVelocity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SampleSequencer.NativeFieldInfoPtr_sendVelocity)) = value;
			}
		}

		// Token: 0x17001A3F RID: 6719
		// (get) Token: 0x0600482F RID: 18479 RVA: 0x0010DAB8 File Offset: 0x0010BCB8
		// (set) Token: 0x06004830 RID: 18480 RVA: 0x0002A74E File Offset: 0x0002894E
		public unsafe Il2CppStructArray<bool> altBools
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SampleSequencer.NativeFieldInfoPtr_altBools);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SampleSequencer.NativeFieldInfoPtr_altBools), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002E24 RID: 11812
		private static readonly IntPtr NativeFieldInfoPtr_lastWindowTime;

		// Token: 0x04002E25 RID: 11813
		private static readonly IntPtr NativeFieldInfoPtr_Sampler;

		// Token: 0x04002E26 RID: 11814
		private static readonly IntPtr NativeFieldInfoPtr_LTM;

		// Token: 0x04002E27 RID: 11815
		private static readonly IntPtr NativeFieldInfoPtr_MTM;

		// Token: 0x04002E28 RID: 11816
		private static readonly IntPtr NativeFieldInfoPtr_numCycles;

		// Token: 0x04002E29 RID: 11817
		private static readonly IntPtr NativeFieldInfoPtr_waitTillNextCycle;

		// Token: 0x04002E2A RID: 11818
		private static readonly IntPtr NativeFieldInfoPtr_RandomNumGen;

		// Token: 0x04002E2B RID: 11819
		private static readonly IntPtr NativeFieldInfoPtr_lookaheadTime;

		// Token: 0x04002E2C RID: 11820
		private static readonly IntPtr NativeFieldInfoPtr_selectedTransition;

		// Token: 0x04002E2D RID: 11821
		private static readonly IntPtr NativeFieldInfoPtr_updateStartTime;

		// Token: 0x04002E2E RID: 11822
		private static readonly IntPtr NativeFieldInfoPtr_position;

		// Token: 0x04002E2F RID: 11823
		private static readonly IntPtr NativeFieldInfoPtr_sixteenthTime;

		// Token: 0x04002E30 RID: 11824
		private static readonly IntPtr NativeFieldInfoPtr_currentTime;

		// Token: 0x04002E31 RID: 11825
		private static readonly IntPtr NativeFieldInfoPtr_sequencerTime;

		// Token: 0x04002E32 RID: 11826
		private static readonly IntPtr NativeFieldInfoPtr_windowMax;

		// Token: 0x04002E33 RID: 11827
		private static readonly IntPtr NativeFieldInfoPtr_internalLastWindowMax;

		// Token: 0x04002E34 RID: 11828
		private static readonly IntPtr NativeFieldInfoPtr_internalWindowMax;

		// Token: 0x04002E35 RID: 11829
		private static readonly IntPtr NativeFieldInfoPtr_startSearch;

		// Token: 0x04002E36 RID: 11830
		private static readonly IntPtr NativeFieldInfoPtr_endSearch;

		// Token: 0x04002E37 RID: 11831
		private static readonly IntPtr NativeFieldInfoPtr_theseNotes;

		// Token: 0x04002E38 RID: 11832
		private static readonly IntPtr NativeFieldInfoPtr_startTime;

		// Token: 0x04002E39 RID: 11833
		private static readonly IntPtr NativeFieldInfoPtr_endTime;

		// Token: 0x04002E3A RID: 11834
		private static readonly IntPtr NativeFieldInfoPtr_timeToStart;

		// Token: 0x04002E3B RID: 11835
		private static readonly IntPtr NativeFieldInfoPtr_timeToEnd;

		// Token: 0x04002E3C RID: 11836
		private static readonly IntPtr NativeFieldInfoPtr_sendVelocity;

		// Token: 0x04002E3D RID: 11837
		private static readonly IntPtr NativeFieldInfoPtr_altBools;

		// Token: 0x04002E3E RID: 11838
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04002E3F RID: 11839
		private static readonly IntPtr NativeMethodInfoPtr_FindTransitionManagers_Public_Void_0;

		// Token: 0x04002E40 RID: 11840
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04002E41 RID: 11841
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04002E42 RID: 11842
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

		// Token: 0x04002E43 RID: 11843
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;

		// Token: 0x04002E44 RID: 11844
		private static readonly IntPtr NativeMethodInfoPtr_AllNotesOff_Public_Virtual_Void_0;

		// Token: 0x04002E45 RID: 11845
		private static readonly IntPtr NativeMethodInfoPtr_NoteOn_Public_Virtual_Void_Int32_Single_0;

		// Token: 0x04002E46 RID: 11846
		private static readonly IntPtr NativeMethodInfoPtr_NoteOff_Public_Virtual_Void_Int32_0;

		// Token: 0x04002E47 RID: 11847
		private static readonly IntPtr NativeMethodInfoPtr_EnableComponent_Private_Void_0;

		// Token: 0x04002E48 RID: 11848
		private static readonly IntPtr NativeMethodInfoPtr_StartOnNextCycle_Public_Virtual_Void_0;

		// Token: 0x04002E49 RID: 11849
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04002E4A RID: 11850
		private static readonly IntPtr NativeMethodInfoPtr_DoUpdate_Private_Void_0;

		// Token: 0x04002E4B RID: 11851
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
