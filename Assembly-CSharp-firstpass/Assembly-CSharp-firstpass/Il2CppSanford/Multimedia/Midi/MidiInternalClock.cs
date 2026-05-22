using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSanford.Multimedia.Timers;
using Il2CppSystem;
using Il2CppSystem.ComponentModel;

namespace Il2CppSanford.Multimedia.Midi
{
	// Token: 0x02000190 RID: 400
	public class MidiInternalClock : PpqnClock
	{
		// Token: 0x0600122F RID: 4655 RVA: 0x00056E4C File Offset: 0x0005504C
		// Note: this type is marked as 'beforefieldinit'.
		static MidiInternalClock()
		{
			Il2CppClassPointerStore<MidiInternalClock>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Sanford.Multimedia.Midi", "MidiInternalClock");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MidiInternalClock>.NativeClassPtr);
			MidiInternalClock.NativeFieldInfoPtr_timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MidiInternalClock>.NativeClassPtr, "timer");
			MidiInternalClock.NativeFieldInfoPtr_builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MidiInternalClock>.NativeClassPtr, "builder");
			MidiInternalClock.NativeFieldInfoPtr_ticks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MidiInternalClock>.NativeClassPtr, "ticks");
			MidiInternalClock.NativeFieldInfoPtr_disposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MidiInternalClock>.NativeClassPtr, "disposed");
			MidiInternalClock.NativeFieldInfoPtr_site = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MidiInternalClock>.NativeClassPtr, "site");
			MidiInternalClock.NativeFieldInfoPtr_Disposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MidiInternalClock>.NativeClassPtr, "Disposed");
			MidiInternalClock.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MidiInternalClock>.NativeClassPtr, 100665927);
			MidiInternalClock.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MidiInternalClock>.NativeClassPtr, 100665928);
			MidiInternalClock.NativeMethodInfoPtr__ctor_Public_Void_IContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MidiInternalClock>.NativeClassPtr, 100665929);
			MidiInternalClock.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MidiInternalClock>.NativeClassPtr, 100665930);
			MidiInternalClock.NativeMethodInfoPtr_Continue_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MidiInternalClock>.NativeClassPtr, 100665931);
			MidiInternalClock.NativeMethodInfoPtr_Stop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MidiInternalClock>.NativeClassPtr, 100665932);
			MidiInternalClock.NativeMethodInfoPtr_SetTicks_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MidiInternalClock>.NativeClassPtr, 100665933);
			MidiInternalClock.NativeMethodInfoPtr_Process_Public_Void_MetaMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MidiInternalClock>.NativeClassPtr, 100665934);
			MidiInternalClock.NativeMethodInfoPtr_OnDisposed_Protected_Virtual_New_Void_EventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MidiInternalClock>.NativeClassPtr, 100665935);
			MidiInternalClock.NativeMethodInfoPtr_HandleTick_Private_Void_Object_EventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MidiInternalClock>.NativeClassPtr, 100665936);
			MidiInternalClock.NativeMethodInfoPtr_get_Tempo_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MidiInternalClock>.NativeClassPtr, 100665937);
			MidiInternalClock.NativeMethodInfoPtr_set_Tempo_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MidiInternalClock>.NativeClassPtr, 100665938);
			MidiInternalClock.NativeMethodInfoPtr_get_Ticks_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MidiInternalClock>.NativeClassPtr, 100665939);
			MidiInternalClock.NativeMethodInfoPtr_add_Disposed_Public_Virtual_Final_New_add_Void_EventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MidiInternalClock>.NativeClassPtr, 100665940);
			MidiInternalClock.NativeMethodInfoPtr_remove_Disposed_Public_Virtual_Final_New_rem_Void_EventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MidiInternalClock>.NativeClassPtr, 100665941);
			MidiInternalClock.NativeMethodInfoPtr_get_Site_Public_Virtual_Final_New_get_ISite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MidiInternalClock>.NativeClassPtr, 100665942);
			MidiInternalClock.NativeMethodInfoPtr_set_Site_Public_Virtual_Final_New_set_Void_ISite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MidiInternalClock>.NativeClassPtr, 100665943);
			MidiInternalClock.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MidiInternalClock>.NativeClassPtr, 100665944);
		}

		// Token: 0x06001230 RID: 4656 RVA: 0x0005705C File Offset: 0x0005525C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14802, XrefRangeEnd = 14803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MidiInternalClock()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MidiInternalClock>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MidiInternalClock.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001231 RID: 4657 RVA: 0x00057098 File Offset: 0x00055298
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 14845, RefRangeEnd = 14848, XrefRangeStart = 14803, XrefRangeEnd = 14845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MidiInternalClock(int timerPeriod)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MidiInternalClock>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref timerPeriod;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MidiInternalClock.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001232 RID: 4658 RVA: 0x000570E0 File Offset: 0x000552E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14848, XrefRangeEnd = 14853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MidiInternalClock(IContainer container)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MidiInternalClock>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(container);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MidiInternalClock.NativeMethodInfoPtr__ctor_Public_Void_IContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001233 RID: 4659 RVA: 0x0005712C File Offset: 0x0005532C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14853, XrefRangeEnd = 14860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MidiInternalClock.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001234 RID: 4660 RVA: 0x00057160 File Offset: 0x00055360
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14860, XrefRangeEnd = 14867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Continue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MidiInternalClock.NativeMethodInfoPtr_Continue_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001235 RID: 4661 RVA: 0x00057194 File Offset: 0x00055394
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 14874, RefRangeEnd = 14877, XrefRangeStart = 14867, XrefRangeEnd = 14874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Stop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MidiInternalClock.NativeMethodInfoPtr_Stop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001236 RID: 4662 RVA: 0x000571C8 File Offset: 0x000553C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14877, XrefRangeEnd = 14878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTicks(int ticks)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ticks;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MidiInternalClock.NativeMethodInfoPtr_SetTicks_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001237 RID: 4663 RVA: 0x00057208 File Offset: 0x00055408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14878, XrefRangeEnd = 14882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Process(MetaMessage message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MidiInternalClock.NativeMethodInfoPtr_Process_Public_Void_MetaMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001238 RID: 4664 RVA: 0x0005724C File Offset: 0x0005544C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14882, XrefRangeEnd = 14883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDisposed(EventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MidiInternalClock.NativeMethodInfoPtr_OnDisposed_Protected_Virtual_New_Void_EventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001239 RID: 4665 RVA: 0x0005729C File Offset: 0x0005549C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14883, XrefRangeEnd = 14887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleTick(Object sender, EventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MidiInternalClock.NativeMethodInfoPtr_HandleTick_Private_Void_Object_EventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x0600123A RID: 4666 RVA: 0x000572F0 File Offset: 0x000554F0
		// (set) Token: 0x0600123B RID: 4667 RVA: 0x0005732C File Offset: 0x0005552C
		public unsafe int Tempo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MidiInternalClock.NativeMethodInfoPtr_get_Tempo_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MidiInternalClock.NativeMethodInfoPtr_set_Tempo_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x0600123C RID: 4668 RVA: 0x0005736C File Offset: 0x0005556C
		public unsafe override int Ticks
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MidiInternalClock.NativeMethodInfoPtr_get_Ticks_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600123D RID: 4669 RVA: 0x000573B4 File Offset: 0x000555B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14887, XrefRangeEnd = 14890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void add_Disposed(EventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MidiInternalClock.NativeMethodInfoPtr_add_Disposed_Public_Virtual_Final_New_add_Void_EventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600123E RID: 4670 RVA: 0x000573F8 File Offset: 0x000555F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14890, XrefRangeEnd = 14893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void remove_Disposed(EventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MidiInternalClock.NativeMethodInfoPtr_remove_Disposed_Public_Virtual_Final_New_rem_Void_EventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x0600123F RID: 4671 RVA: 0x0005743C File Offset: 0x0005563C
		// (set) Token: 0x06001240 RID: 4672 RVA: 0x0005747C File Offset: 0x0005567C
		public unsafe virtual ISite Site
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MidiInternalClock.NativeMethodInfoPtr_get_Site_Public_Virtual_Final_New_get_ISite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISite>(intPtr3) : null;
			}
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 14893, RefRangeEnd = 14909, XrefRangeStart = 14893, XrefRangeEnd = 14893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MidiInternalClock.NativeMethodInfoPtr_set_Site_Public_Virtual_Final_New_set_Void_ISite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001241 RID: 4673 RVA: 0x000574C0 File Offset: 0x000556C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14909, XrefRangeEnd = 14923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MidiInternalClock.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001242 RID: 4674 RVA: 0x00007737 File Offset: 0x00005937
		public MidiInternalClock(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x06001243 RID: 4675 RVA: 0x000574F4 File Offset: 0x000556F4
		// (set) Token: 0x06001244 RID: 4676 RVA: 0x00007740 File Offset: 0x00005940
		public unsafe ITimer timer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MidiInternalClock.NativeFieldInfoPtr_timer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ITimer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MidiInternalClock.NativeFieldInfoPtr_timer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x06001245 RID: 4677 RVA: 0x00057524 File Offset: 0x00055724
		// (set) Token: 0x06001246 RID: 4678 RVA: 0x0000775F File Offset: 0x0000595F
		public unsafe TempoChangeBuilder builder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MidiInternalClock.NativeFieldInfoPtr_builder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TempoChangeBuilder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MidiInternalClock.NativeFieldInfoPtr_builder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x06001247 RID: 4679 RVA: 0x00057554 File Offset: 0x00055754
		// (set) Token: 0x06001248 RID: 4680 RVA: 0x0000777E File Offset: 0x0000597E
		public unsafe int ticks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MidiInternalClock.NativeFieldInfoPtr_ticks);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MidiInternalClock.NativeFieldInfoPtr_ticks)) = value;
			}
		}

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06001249 RID: 4681 RVA: 0x0005757C File Offset: 0x0005577C
		// (set) Token: 0x0600124A RID: 4682 RVA: 0x00007799 File Offset: 0x00005999
		public unsafe bool disposed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MidiInternalClock.NativeFieldInfoPtr_disposed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MidiInternalClock.NativeFieldInfoPtr_disposed)) = value;
			}
		}

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x0600124B RID: 4683 RVA: 0x000575A4 File Offset: 0x000557A4
		// (set) Token: 0x0600124C RID: 4684 RVA: 0x000077B4 File Offset: 0x000059B4
		public unsafe ISite site
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MidiInternalClock.NativeFieldInfoPtr_site);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MidiInternalClock.NativeFieldInfoPtr_site), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x0600124D RID: 4685 RVA: 0x000575D4 File Offset: 0x000557D4
		// (set) Token: 0x0600124E RID: 4686 RVA: 0x000077D3 File Offset: 0x000059D3
		public unsafe EventHandler Disposed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MidiInternalClock.NativeFieldInfoPtr_Disposed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MidiInternalClock.NativeFieldInfoPtr_Disposed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001438 RID: 5176
		private static readonly IntPtr NativeFieldInfoPtr_timer;

		// Token: 0x04001439 RID: 5177
		private static readonly IntPtr NativeFieldInfoPtr_builder;

		// Token: 0x0400143A RID: 5178
		private static readonly IntPtr NativeFieldInfoPtr_ticks;

		// Token: 0x0400143B RID: 5179
		private static readonly IntPtr NativeFieldInfoPtr_disposed;

		// Token: 0x0400143C RID: 5180
		private static readonly IntPtr NativeFieldInfoPtr_site;

		// Token: 0x0400143D RID: 5181
		private static readonly IntPtr NativeFieldInfoPtr_Disposed;

		// Token: 0x0400143E RID: 5182
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400143F RID: 5183
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001440 RID: 5184
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IContainer_0;

		// Token: 0x04001441 RID: 5185
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x04001442 RID: 5186
		private static readonly IntPtr NativeMethodInfoPtr_Continue_Public_Void_0;

		// Token: 0x04001443 RID: 5187
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Void_0;

		// Token: 0x04001444 RID: 5188
		private static readonly IntPtr NativeMethodInfoPtr_SetTicks_Public_Void_Int32_0;

		// Token: 0x04001445 RID: 5189
		private static readonly IntPtr NativeMethodInfoPtr_Process_Public_Void_MetaMessage_0;

		// Token: 0x04001446 RID: 5190
		private static readonly IntPtr NativeMethodInfoPtr_OnDisposed_Protected_Virtual_New_Void_EventArgs_0;

		// Token: 0x04001447 RID: 5191
		private static readonly IntPtr NativeMethodInfoPtr_HandleTick_Private_Void_Object_EventArgs_0;

		// Token: 0x04001448 RID: 5192
		private static readonly IntPtr NativeMethodInfoPtr_get_Tempo_Public_get_Int32_0;

		// Token: 0x04001449 RID: 5193
		private static readonly IntPtr NativeMethodInfoPtr_set_Tempo_Public_set_Void_Int32_0;

		// Token: 0x0400144A RID: 5194
		private static readonly IntPtr NativeMethodInfoPtr_get_Ticks_Public_Virtual_get_Int32_0;

		// Token: 0x0400144B RID: 5195
		private static readonly IntPtr NativeMethodInfoPtr_add_Disposed_Public_Virtual_Final_New_add_Void_EventHandler_0;

		// Token: 0x0400144C RID: 5196
		private static readonly IntPtr NativeMethodInfoPtr_remove_Disposed_Public_Virtual_Final_New_rem_Void_EventHandler_0;

		// Token: 0x0400144D RID: 5197
		private static readonly IntPtr NativeMethodInfoPtr_get_Site_Public_Virtual_Final_New_get_ISite_0;

		// Token: 0x0400144E RID: 5198
		private static readonly IntPtr NativeMethodInfoPtr_set_Site_Public_Virtual_Final_New_set_Void_ISite_0;

		// Token: 0x0400144F RID: 5199
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
	}
}
