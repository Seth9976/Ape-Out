using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppSanford.Multimedia.Midi
{
	// Token: 0x02000191 RID: 401
	public class PpqnClock : Object
	{
		// Token: 0x0600124F RID: 4687 RVA: 0x00057604 File Offset: 0x00055804
		// Note: this type is marked as 'beforefieldinit'.
		static PpqnClock()
		{
			Il2CppClassPointerStore<PpqnClock>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Sanford.Multimedia.Midi", "PpqnClock");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PpqnClock>.NativeClassPtr);
			PpqnClock.NativeFieldInfoPtr_DefaultTempo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PpqnClock>.NativeClassPtr, "DefaultTempo");
			PpqnClock.NativeFieldInfoPtr_PpqnMinValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PpqnClock>.NativeClassPtr, "PpqnMinValue");
			PpqnClock.NativeFieldInfoPtr_MicrosecondsPerMillisecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PpqnClock>.NativeClassPtr, "MicrosecondsPerMillisecond");
			PpqnClock.NativeFieldInfoPtr_ppqn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PpqnClock>.NativeClassPtr, "ppqn");
			PpqnClock.NativeFieldInfoPtr_tempo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PpqnClock>.NativeClassPtr, "tempo");
			PpqnClock.NativeFieldInfoPtr_periodResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PpqnClock>.NativeClassPtr, "periodResolution");
			PpqnClock.NativeFieldInfoPtr_ticksPerClock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PpqnClock>.NativeClassPtr, "ticksPerClock");
			PpqnClock.NativeFieldInfoPtr_fractionalTicks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PpqnClock>.NativeClassPtr, "fractionalTicks");
			PpqnClock.NativeFieldInfoPtr_timerPeriod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PpqnClock>.NativeClassPtr, "timerPeriod");
			PpqnClock.NativeFieldInfoPtr_running = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PpqnClock>.NativeClassPtr, "running");
			PpqnClock.NativeFieldInfoPtr_Tick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PpqnClock>.NativeClassPtr, "Tick");
			PpqnClock.NativeFieldInfoPtr_Started = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PpqnClock>.NativeClassPtr, "Started");
			PpqnClock.NativeFieldInfoPtr_Continued = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PpqnClock>.NativeClassPtr, "Continued");
			PpqnClock.NativeFieldInfoPtr_Stopped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PpqnClock>.NativeClassPtr, "Stopped");
			PpqnClock.NativeMethodInfoPtr__ctor_Protected_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PpqnClock>.NativeClassPtr, 100665945);
			PpqnClock.NativeMethodInfoPtr_GetTempo_Protected_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PpqnClock>.NativeClassPtr, 100665946);
			PpqnClock.NativeMethodInfoPtr_SetTempo_Protected_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PpqnClock>.NativeClassPtr, 100665947);
			PpqnClock.NativeMethodInfoPtr_Reset_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PpqnClock>.NativeClassPtr, 100665948);
			PpqnClock.NativeMethodInfoPtr_GenerateTicks_Protected_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PpqnClock>.NativeClassPtr, 100665949);
			PpqnClock.NativeMethodInfoPtr_CalculatePeriodResolution_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PpqnClock>.NativeClassPtr, 100665950);
			PpqnClock.NativeMethodInfoPtr_CalculateTicksPerClock_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PpqnClock>.NativeClassPtr, 100665951);
			PpqnClock.NativeMethodInfoPtr_OnTick_Protected_Virtual_New_Void_EventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PpqnClock>.NativeClassPtr, 100665952);
			PpqnClock.NativeMethodInfoPtr_OnStarted_Protected_Virtual_New_Void_EventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PpqnClock>.NativeClassPtr, 100665953);
			PpqnClock.NativeMethodInfoPtr_OnStopped_Protected_Virtual_New_Void_EventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PpqnClock>.NativeClassPtr, 100665954);
			PpqnClock.NativeMethodInfoPtr_OnContinued_Protected_Virtual_New_Void_EventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PpqnClock>.NativeClassPtr, 100665955);
			PpqnClock.NativeMethodInfoPtr_get_Ppqn_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PpqnClock>.NativeClassPtr, 100665956);
			PpqnClock.NativeMethodInfoPtr_set_Ppqn_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PpqnClock>.NativeClassPtr, 100665957);
			PpqnClock.NativeMethodInfoPtr_get_Ticks_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PpqnClock>.NativeClassPtr, 100665958);
			PpqnClock.NativeMethodInfoPtr_get_TicksPerClock_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PpqnClock>.NativeClassPtr, 100665959);
			PpqnClock.NativeMethodInfoPtr_add_Tick_Public_Virtual_Final_New_add_Void_EventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PpqnClock>.NativeClassPtr, 100665960);
			PpqnClock.NativeMethodInfoPtr_remove_Tick_Public_Virtual_Final_New_rem_Void_EventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PpqnClock>.NativeClassPtr, 100665961);
			PpqnClock.NativeMethodInfoPtr_add_Started_Public_Virtual_Final_New_add_Void_EventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PpqnClock>.NativeClassPtr, 100665962);
			PpqnClock.NativeMethodInfoPtr_remove_Started_Public_Virtual_Final_New_rem_Void_EventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PpqnClock>.NativeClassPtr, 100665963);
			PpqnClock.NativeMethodInfoPtr_add_Continued_Public_Virtual_Final_New_add_Void_EventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PpqnClock>.NativeClassPtr, 100665964);
			PpqnClock.NativeMethodInfoPtr_remove_Continued_Public_Virtual_Final_New_rem_Void_EventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PpqnClock>.NativeClassPtr, 100665965);
			PpqnClock.NativeMethodInfoPtr_add_Stopped_Public_Virtual_Final_New_add_Void_EventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PpqnClock>.NativeClassPtr, 100665966);
			PpqnClock.NativeMethodInfoPtr_remove_Stopped_Public_Virtual_Final_New_rem_Void_EventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PpqnClock>.NativeClassPtr, 100665967);
			PpqnClock.NativeMethodInfoPtr_get_IsRunning_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PpqnClock>.NativeClassPtr, 100665968);
		}

		// Token: 0x06001250 RID: 4688 RVA: 0x0005792C File Offset: 0x00055B2C
		[CallerCount(0)]
		public unsafe PpqnClock(int timerPeriod)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PpqnClock>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref timerPeriod;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PpqnClock.NativeMethodInfoPtr__ctor_Protected_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001251 RID: 4689 RVA: 0x00057974 File Offset: 0x00055B74
		[CallerCount(0)]
		public unsafe int GetTempo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PpqnClock.NativeMethodInfoPtr_GetTempo_Protected_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001252 RID: 4690 RVA: 0x000579B0 File Offset: 0x00055BB0
		[CallerCount(0)]
		public unsafe void SetTempo(int tempo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref tempo;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PpqnClock.NativeMethodInfoPtr_SetTempo_Protected_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001253 RID: 4691 RVA: 0x000579F0 File Offset: 0x00055BF0
		[CallerCount(0)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PpqnClock.NativeMethodInfoPtr_Reset_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001254 RID: 4692 RVA: 0x00057A24 File Offset: 0x00055C24
		[CallerCount(0)]
		public unsafe int GenerateTicks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PpqnClock.NativeMethodInfoPtr_GenerateTicks_Protected_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001255 RID: 4693 RVA: 0x00057A60 File Offset: 0x00055C60
		[CallerCount(0)]
		public unsafe void CalculatePeriodResolution()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PpqnClock.NativeMethodInfoPtr_CalculatePeriodResolution_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001256 RID: 4694 RVA: 0x00057A94 File Offset: 0x00055C94
		[CallerCount(0)]
		public unsafe void CalculateTicksPerClock()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PpqnClock.NativeMethodInfoPtr_CalculateTicksPerClock_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001257 RID: 4695 RVA: 0x00057AC8 File Offset: 0x00055CC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14923, XrefRangeEnd = 14928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnTick(EventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PpqnClock.NativeMethodInfoPtr_OnTick_Protected_Virtual_New_Void_EventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001258 RID: 4696 RVA: 0x00057B18 File Offset: 0x00055D18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14928, XrefRangeEnd = 14929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnStarted(EventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PpqnClock.NativeMethodInfoPtr_OnStarted_Protected_Virtual_New_Void_EventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001259 RID: 4697 RVA: 0x00057B68 File Offset: 0x00055D68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnStopped(EventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PpqnClock.NativeMethodInfoPtr_OnStopped_Protected_Virtual_New_Void_EventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600125A RID: 4698 RVA: 0x00057BB8 File Offset: 0x00055DB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnContinued(EventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PpqnClock.NativeMethodInfoPtr_OnContinued_Protected_Virtual_New_Void_EventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x0600125B RID: 4699 RVA: 0x00057C08 File Offset: 0x00055E08
		// (set) Token: 0x0600125C RID: 4700 RVA: 0x00057C44 File Offset: 0x00055E44
		public unsafe int Ppqn
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 896, RefRangeEnd = 897, XrefRangeStart = 896, XrefRangeEnd = 897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PpqnClock.NativeMethodInfoPtr_get_Ppqn_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PpqnClock.NativeMethodInfoPtr_set_Ppqn_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x0600125D RID: 4701 RVA: 0x00057C84 File Offset: 0x00055E84
		public unsafe virtual int Ticks
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PpqnClock.NativeMethodInfoPtr_get_Ticks_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x0600125E RID: 4702 RVA: 0x00057CCC File Offset: 0x00055ECC
		public unsafe int TicksPerClock
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PpqnClock.NativeMethodInfoPtr_get_TicksPerClock_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600125F RID: 4703 RVA: 0x00057D08 File Offset: 0x00055F08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14929, XrefRangeEnd = 14932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void add_Tick(EventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PpqnClock.NativeMethodInfoPtr_add_Tick_Public_Virtual_Final_New_add_Void_EventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001260 RID: 4704 RVA: 0x00057D4C File Offset: 0x00055F4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14932, XrefRangeEnd = 14935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void remove_Tick(EventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PpqnClock.NativeMethodInfoPtr_remove_Tick_Public_Virtual_Final_New_rem_Void_EventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001261 RID: 4705 RVA: 0x00057D90 File Offset: 0x00055F90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14935, XrefRangeEnd = 14938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void add_Started(EventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PpqnClock.NativeMethodInfoPtr_add_Started_Public_Virtual_Final_New_add_Void_EventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001262 RID: 4706 RVA: 0x00057DD4 File Offset: 0x00055FD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14938, XrefRangeEnd = 14941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void remove_Started(EventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PpqnClock.NativeMethodInfoPtr_remove_Started_Public_Virtual_Final_New_rem_Void_EventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001263 RID: 4707 RVA: 0x00057E18 File Offset: 0x00056018
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14941, XrefRangeEnd = 14944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void add_Continued(EventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PpqnClock.NativeMethodInfoPtr_add_Continued_Public_Virtual_Final_New_add_Void_EventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001264 RID: 4708 RVA: 0x00057E5C File Offset: 0x0005605C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14944, XrefRangeEnd = 14947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void remove_Continued(EventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PpqnClock.NativeMethodInfoPtr_remove_Continued_Public_Virtual_Final_New_rem_Void_EventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001265 RID: 4709 RVA: 0x00057EA0 File Offset: 0x000560A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14947, XrefRangeEnd = 14950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void add_Stopped(EventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PpqnClock.NativeMethodInfoPtr_add_Stopped_Public_Virtual_Final_New_add_Void_EventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001266 RID: 4710 RVA: 0x00057EE4 File Offset: 0x000560E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14950, XrefRangeEnd = 14953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void remove_Stopped(EventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PpqnClock.NativeMethodInfoPtr_remove_Stopped_Public_Virtual_Final_New_rem_Void_EventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x06001267 RID: 4711 RVA: 0x00057F28 File Offset: 0x00056128
		public unsafe virtual bool IsRunning
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PpqnClock.NativeMethodInfoPtr_get_IsRunning_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001268 RID: 4712 RVA: 0x000077F2 File Offset: 0x000059F2
		public PpqnClock(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x06001269 RID: 4713 RVA: 0x00057F64 File Offset: 0x00056164
		// (set) Token: 0x0600126A RID: 4714 RVA: 0x000077FB File Offset: 0x000059FB
		public unsafe static int DefaultTempo
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(PpqnClock.NativeFieldInfoPtr_DefaultTempo, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PpqnClock.NativeFieldInfoPtr_DefaultTempo, (void*)(&value));
			}
		}

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x0600126B RID: 4715 RVA: 0x00057F80 File Offset: 0x00056180
		// (set) Token: 0x0600126C RID: 4716 RVA: 0x00007809 File Offset: 0x00005A09
		public unsafe static int PpqnMinValue
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(PpqnClock.NativeFieldInfoPtr_PpqnMinValue, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PpqnClock.NativeFieldInfoPtr_PpqnMinValue, (void*)(&value));
			}
		}

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x0600126D RID: 4717 RVA: 0x00057F9C File Offset: 0x0005619C
		// (set) Token: 0x0600126E RID: 4718 RVA: 0x00007817 File Offset: 0x00005A17
		public unsafe static int MicrosecondsPerMillisecond
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(PpqnClock.NativeFieldInfoPtr_MicrosecondsPerMillisecond, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PpqnClock.NativeFieldInfoPtr_MicrosecondsPerMillisecond, (void*)(&value));
			}
		}

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x0600126F RID: 4719 RVA: 0x00057FB8 File Offset: 0x000561B8
		// (set) Token: 0x06001270 RID: 4720 RVA: 0x00007825 File Offset: 0x00005A25
		public unsafe int ppqn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PpqnClock.NativeFieldInfoPtr_ppqn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PpqnClock.NativeFieldInfoPtr_ppqn)) = value;
			}
		}

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x06001271 RID: 4721 RVA: 0x00057FE0 File Offset: 0x000561E0
		// (set) Token: 0x06001272 RID: 4722 RVA: 0x00007840 File Offset: 0x00005A40
		public unsafe int tempo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PpqnClock.NativeFieldInfoPtr_tempo);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PpqnClock.NativeFieldInfoPtr_tempo)) = value;
			}
		}

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x06001273 RID: 4723 RVA: 0x00058008 File Offset: 0x00056208
		// (set) Token: 0x06001274 RID: 4724 RVA: 0x0000785B File Offset: 0x00005A5B
		public unsafe int periodResolution
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PpqnClock.NativeFieldInfoPtr_periodResolution);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PpqnClock.NativeFieldInfoPtr_periodResolution)) = value;
			}
		}

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x06001275 RID: 4725 RVA: 0x00058030 File Offset: 0x00056230
		// (set) Token: 0x06001276 RID: 4726 RVA: 0x00007876 File Offset: 0x00005A76
		public unsafe int ticksPerClock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PpqnClock.NativeFieldInfoPtr_ticksPerClock);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PpqnClock.NativeFieldInfoPtr_ticksPerClock)) = value;
			}
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x06001277 RID: 4727 RVA: 0x00058058 File Offset: 0x00056258
		// (set) Token: 0x06001278 RID: 4728 RVA: 0x00007891 File Offset: 0x00005A91
		public unsafe int fractionalTicks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PpqnClock.NativeFieldInfoPtr_fractionalTicks);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PpqnClock.NativeFieldInfoPtr_fractionalTicks)) = value;
			}
		}

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x06001279 RID: 4729 RVA: 0x00058080 File Offset: 0x00056280
		// (set) Token: 0x0600127A RID: 4730 RVA: 0x000078AC File Offset: 0x00005AAC
		public unsafe int timerPeriod
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PpqnClock.NativeFieldInfoPtr_timerPeriod);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PpqnClock.NativeFieldInfoPtr_timerPeriod)) = value;
			}
		}

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x0600127B RID: 4731 RVA: 0x000580A8 File Offset: 0x000562A8
		// (set) Token: 0x0600127C RID: 4732 RVA: 0x000078C7 File Offset: 0x00005AC7
		public unsafe bool running
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PpqnClock.NativeFieldInfoPtr_running);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PpqnClock.NativeFieldInfoPtr_running)) = value;
			}
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x0600127D RID: 4733 RVA: 0x000580D0 File Offset: 0x000562D0
		// (set) Token: 0x0600127E RID: 4734 RVA: 0x000078E2 File Offset: 0x00005AE2
		public unsafe EventHandler Tick
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PpqnClock.NativeFieldInfoPtr_Tick);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PpqnClock.NativeFieldInfoPtr_Tick), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x0600127F RID: 4735 RVA: 0x00058100 File Offset: 0x00056300
		// (set) Token: 0x06001280 RID: 4736 RVA: 0x00007901 File Offset: 0x00005B01
		public unsafe EventHandler Started
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PpqnClock.NativeFieldInfoPtr_Started);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PpqnClock.NativeFieldInfoPtr_Started), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x06001281 RID: 4737 RVA: 0x00058130 File Offset: 0x00056330
		// (set) Token: 0x06001282 RID: 4738 RVA: 0x00007920 File Offset: 0x00005B20
		public unsafe EventHandler Continued
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PpqnClock.NativeFieldInfoPtr_Continued);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PpqnClock.NativeFieldInfoPtr_Continued), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x06001283 RID: 4739 RVA: 0x00058160 File Offset: 0x00056360
		// (set) Token: 0x06001284 RID: 4740 RVA: 0x0000793F File Offset: 0x00005B3F
		public unsafe EventHandler Stopped
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PpqnClock.NativeFieldInfoPtr_Stopped);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PpqnClock.NativeFieldInfoPtr_Stopped), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001450 RID: 5200
		private static readonly IntPtr NativeFieldInfoPtr_DefaultTempo;

		// Token: 0x04001451 RID: 5201
		private static readonly IntPtr NativeFieldInfoPtr_PpqnMinValue;

		// Token: 0x04001452 RID: 5202
		private static readonly IntPtr NativeFieldInfoPtr_MicrosecondsPerMillisecond;

		// Token: 0x04001453 RID: 5203
		private static readonly IntPtr NativeFieldInfoPtr_ppqn;

		// Token: 0x04001454 RID: 5204
		private static readonly IntPtr NativeFieldInfoPtr_tempo;

		// Token: 0x04001455 RID: 5205
		private static readonly IntPtr NativeFieldInfoPtr_periodResolution;

		// Token: 0x04001456 RID: 5206
		private static readonly IntPtr NativeFieldInfoPtr_ticksPerClock;

		// Token: 0x04001457 RID: 5207
		private static readonly IntPtr NativeFieldInfoPtr_fractionalTicks;

		// Token: 0x04001458 RID: 5208
		private static readonly IntPtr NativeFieldInfoPtr_timerPeriod;

		// Token: 0x04001459 RID: 5209
		private static readonly IntPtr NativeFieldInfoPtr_running;

		// Token: 0x0400145A RID: 5210
		private static readonly IntPtr NativeFieldInfoPtr_Tick;

		// Token: 0x0400145B RID: 5211
		private static readonly IntPtr NativeFieldInfoPtr_Started;

		// Token: 0x0400145C RID: 5212
		private static readonly IntPtr NativeFieldInfoPtr_Continued;

		// Token: 0x0400145D RID: 5213
		private static readonly IntPtr NativeFieldInfoPtr_Stopped;

		// Token: 0x0400145E RID: 5214
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_Int32_0;

		// Token: 0x0400145F RID: 5215
		private static readonly IntPtr NativeMethodInfoPtr_GetTempo_Protected_Int32_0;

		// Token: 0x04001460 RID: 5216
		private static readonly IntPtr NativeMethodInfoPtr_SetTempo_Protected_Void_Int32_0;

		// Token: 0x04001461 RID: 5217
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Protected_Void_0;

		// Token: 0x04001462 RID: 5218
		private static readonly IntPtr NativeMethodInfoPtr_GenerateTicks_Protected_Int32_0;

		// Token: 0x04001463 RID: 5219
		private static readonly IntPtr NativeMethodInfoPtr_CalculatePeriodResolution_Private_Void_0;

		// Token: 0x04001464 RID: 5220
		private static readonly IntPtr NativeMethodInfoPtr_CalculateTicksPerClock_Private_Void_0;

		// Token: 0x04001465 RID: 5221
		private static readonly IntPtr NativeMethodInfoPtr_OnTick_Protected_Virtual_New_Void_EventArgs_0;

		// Token: 0x04001466 RID: 5222
		private static readonly IntPtr NativeMethodInfoPtr_OnStarted_Protected_Virtual_New_Void_EventArgs_0;

		// Token: 0x04001467 RID: 5223
		private static readonly IntPtr NativeMethodInfoPtr_OnStopped_Protected_Virtual_New_Void_EventArgs_0;

		// Token: 0x04001468 RID: 5224
		private static readonly IntPtr NativeMethodInfoPtr_OnContinued_Protected_Virtual_New_Void_EventArgs_0;

		// Token: 0x04001469 RID: 5225
		private static readonly IntPtr NativeMethodInfoPtr_get_Ppqn_Public_get_Int32_0;

		// Token: 0x0400146A RID: 5226
		private static readonly IntPtr NativeMethodInfoPtr_set_Ppqn_Public_set_Void_Int32_0;

		// Token: 0x0400146B RID: 5227
		private static readonly IntPtr NativeMethodInfoPtr_get_Ticks_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x0400146C RID: 5228
		private static readonly IntPtr NativeMethodInfoPtr_get_TicksPerClock_Public_get_Int32_0;

		// Token: 0x0400146D RID: 5229
		private static readonly IntPtr NativeMethodInfoPtr_add_Tick_Public_Virtual_Final_New_add_Void_EventHandler_0;

		// Token: 0x0400146E RID: 5230
		private static readonly IntPtr NativeMethodInfoPtr_remove_Tick_Public_Virtual_Final_New_rem_Void_EventHandler_0;

		// Token: 0x0400146F RID: 5231
		private static readonly IntPtr NativeMethodInfoPtr_add_Started_Public_Virtual_Final_New_add_Void_EventHandler_0;

		// Token: 0x04001470 RID: 5232
		private static readonly IntPtr NativeMethodInfoPtr_remove_Started_Public_Virtual_Final_New_rem_Void_EventHandler_0;

		// Token: 0x04001471 RID: 5233
		private static readonly IntPtr NativeMethodInfoPtr_add_Continued_Public_Virtual_Final_New_add_Void_EventHandler_0;

		// Token: 0x04001472 RID: 5234
		private static readonly IntPtr NativeMethodInfoPtr_remove_Continued_Public_Virtual_Final_New_rem_Void_EventHandler_0;

		// Token: 0x04001473 RID: 5235
		private static readonly IntPtr NativeMethodInfoPtr_add_Stopped_Public_Virtual_Final_New_add_Void_EventHandler_0;

		// Token: 0x04001474 RID: 5236
		private static readonly IntPtr NativeMethodInfoPtr_remove_Stopped_Public_Virtual_Final_New_rem_Void_EventHandler_0;

		// Token: 0x04001475 RID: 5237
		private static readonly IntPtr NativeMethodInfoPtr_get_IsRunning_Public_Virtual_Final_New_get_Boolean_0;
	}
}
