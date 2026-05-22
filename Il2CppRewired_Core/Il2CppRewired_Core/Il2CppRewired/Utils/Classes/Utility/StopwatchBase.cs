using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppRewired.Utils.Classes.Utility
{
	// Token: 0x0200020B RID: 523
	public class StopwatchBase : Object
	{
		// Token: 0x0600365B RID: 13915 RVA: 0x0010D268 File Offset: 0x0010B468
		// Note: this type is marked as 'beforefieldinit'.
		static StopwatchBase()
		{
			Il2CppClassPointerStore<StopwatchBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Utils.Classes.Utility", "StopwatchBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StopwatchBase>.NativeClassPtr);
			StopwatchBase.NativeMethodInfoPtr_get_offsetSeconds_Public_Abstract_Virtual_New_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopwatchBase>.NativeClassPtr, 100676714);
			StopwatchBase.NativeMethodInfoPtr_set_offsetSeconds_Public_Abstract_Virtual_New_set_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopwatchBase>.NativeClassPtr, 100676715);
			StopwatchBase.NativeMethodInfoPtr_get_offsetTicks_Public_Abstract_Virtual_New_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopwatchBase>.NativeClassPtr, 100676716);
			StopwatchBase.NativeMethodInfoPtr_set_offsetTicks_Public_Abstract_Virtual_New_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopwatchBase>.NativeClassPtr, 100676717);
			StopwatchBase.NativeMethodInfoPtr_get_elapsedSeconds_Public_Abstract_Virtual_New_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopwatchBase>.NativeClassPtr, 100676718);
			StopwatchBase.NativeMethodInfoPtr_get_elapsedSecondsRaw_Public_Abstract_Virtual_New_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopwatchBase>.NativeClassPtr, 100676719);
			StopwatchBase.NativeMethodInfoPtr_get_elapsedMilliseconds_Public_Abstract_Virtual_New_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopwatchBase>.NativeClassPtr, 100676720);
			StopwatchBase.NativeMethodInfoPtr_get_elapsedMillisecondsRaw_Public_Abstract_Virtual_New_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopwatchBase>.NativeClassPtr, 100676721);
			StopwatchBase.NativeMethodInfoPtr_get_elapsedTicks_Public_Abstract_Virtual_New_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopwatchBase>.NativeClassPtr, 100676722);
			StopwatchBase.NativeMethodInfoPtr_get_elapsedTicksRaw_Public_Abstract_Virtual_New_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopwatchBase>.NativeClassPtr, 100676723);
			StopwatchBase.NativeMethodInfoPtr_get_isRunning_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopwatchBase>.NativeClassPtr, 100676724);
			StopwatchBase.NativeMethodInfoPtr_Stop_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopwatchBase>.NativeClassPtr, 100676725);
			StopwatchBase.NativeMethodInfoPtr_Start_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopwatchBase>.NativeClassPtr, 100676726);
			StopwatchBase.NativeMethodInfoPtr_Reset_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopwatchBase>.NativeClassPtr, 100676727);
			StopwatchBase.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopwatchBase>.NativeClassPtr, 100676728);
		}

		// Token: 0x17001032 RID: 4146
		// (get) Token: 0x0600365C RID: 13916 RVA: 0x0010D3C4 File Offset: 0x0010B5C4
		// (set) Token: 0x0600365D RID: 13917 RVA: 0x0010D40C File Offset: 0x0010B60C
		public unsafe virtual double offsetSeconds
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StopwatchBase.NativeMethodInfoPtr_get_offsetSeconds_Public_Abstract_Virtual_New_get_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StopwatchBase.NativeMethodInfoPtr_set_offsetSeconds_Public_Abstract_Virtual_New_set_Void_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001033 RID: 4147
		// (get) Token: 0x0600365E RID: 13918 RVA: 0x0010D458 File Offset: 0x0010B658
		// (set) Token: 0x0600365F RID: 13919 RVA: 0x0010D4A0 File Offset: 0x0010B6A0
		public unsafe virtual long offsetTicks
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StopwatchBase.NativeMethodInfoPtr_get_offsetTicks_Public_Abstract_Virtual_New_get_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StopwatchBase.NativeMethodInfoPtr_set_offsetTicks_Public_Abstract_Virtual_New_set_Void_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001034 RID: 4148
		// (get) Token: 0x06003660 RID: 13920 RVA: 0x0010D4EC File Offset: 0x0010B6EC
		public unsafe virtual double elapsedSeconds
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StopwatchBase.NativeMethodInfoPtr_get_elapsedSeconds_Public_Abstract_Virtual_New_get_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001035 RID: 4149
		// (get) Token: 0x06003661 RID: 13921 RVA: 0x0010D534 File Offset: 0x0010B734
		public unsafe virtual double elapsedSecondsRaw
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StopwatchBase.NativeMethodInfoPtr_get_elapsedSecondsRaw_Public_Abstract_Virtual_New_get_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001036 RID: 4150
		// (get) Token: 0x06003662 RID: 13922 RVA: 0x0010D57C File Offset: 0x0010B77C
		public unsafe virtual long elapsedMilliseconds
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StopwatchBase.NativeMethodInfoPtr_get_elapsedMilliseconds_Public_Abstract_Virtual_New_get_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001037 RID: 4151
		// (get) Token: 0x06003663 RID: 13923 RVA: 0x0010D5C4 File Offset: 0x0010B7C4
		public unsafe virtual long elapsedMillisecondsRaw
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StopwatchBase.NativeMethodInfoPtr_get_elapsedMillisecondsRaw_Public_Abstract_Virtual_New_get_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001038 RID: 4152
		// (get) Token: 0x06003664 RID: 13924 RVA: 0x0010D60C File Offset: 0x0010B80C
		public unsafe virtual long elapsedTicks
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StopwatchBase.NativeMethodInfoPtr_get_elapsedTicks_Public_Abstract_Virtual_New_get_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001039 RID: 4153
		// (get) Token: 0x06003665 RID: 13925 RVA: 0x0010D654 File Offset: 0x0010B854
		public unsafe virtual long elapsedTicksRaw
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StopwatchBase.NativeMethodInfoPtr_get_elapsedTicksRaw_Public_Abstract_Virtual_New_get_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700103A RID: 4154
		// (get) Token: 0x06003666 RID: 13926 RVA: 0x0010D69C File Offset: 0x0010B89C
		public unsafe virtual bool isRunning
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StopwatchBase.NativeMethodInfoPtr_get_isRunning_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003667 RID: 13927 RVA: 0x0010D6E4 File Offset: 0x0010B8E4
		[CallerCount(0)]
		public unsafe virtual void Stop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StopwatchBase.NativeMethodInfoPtr_Stop_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003668 RID: 13928 RVA: 0x0010D720 File Offset: 0x0010B920
		[CallerCount(0)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StopwatchBase.NativeMethodInfoPtr_Start_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003669 RID: 13929 RVA: 0x0010D75C File Offset: 0x0010B95C
		[CallerCount(0)]
		public unsafe virtual void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StopwatchBase.NativeMethodInfoPtr_Reset_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600366A RID: 13930 RVA: 0x0010D798 File Offset: 0x0010B998
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StopwatchBase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StopwatchBase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StopwatchBase.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600366B RID: 13931 RVA: 0x00012C91 File Offset: 0x00010E91
		public StopwatchBase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002E16 RID: 11798
		private static readonly IntPtr NativeMethodInfoPtr_get_offsetSeconds_Public_Abstract_Virtual_New_get_Double_0;

		// Token: 0x04002E17 RID: 11799
		private static readonly IntPtr NativeMethodInfoPtr_set_offsetSeconds_Public_Abstract_Virtual_New_set_Void_Double_0;

		// Token: 0x04002E18 RID: 11800
		private static readonly IntPtr NativeMethodInfoPtr_get_offsetTicks_Public_Abstract_Virtual_New_get_Int64_0;

		// Token: 0x04002E19 RID: 11801
		private static readonly IntPtr NativeMethodInfoPtr_set_offsetTicks_Public_Abstract_Virtual_New_set_Void_Int64_0;

		// Token: 0x04002E1A RID: 11802
		private static readonly IntPtr NativeMethodInfoPtr_get_elapsedSeconds_Public_Abstract_Virtual_New_get_Double_0;

		// Token: 0x04002E1B RID: 11803
		private static readonly IntPtr NativeMethodInfoPtr_get_elapsedSecondsRaw_Public_Abstract_Virtual_New_get_Double_0;

		// Token: 0x04002E1C RID: 11804
		private static readonly IntPtr NativeMethodInfoPtr_get_elapsedMilliseconds_Public_Abstract_Virtual_New_get_Int64_0;

		// Token: 0x04002E1D RID: 11805
		private static readonly IntPtr NativeMethodInfoPtr_get_elapsedMillisecondsRaw_Public_Abstract_Virtual_New_get_Int64_0;

		// Token: 0x04002E1E RID: 11806
		private static readonly IntPtr NativeMethodInfoPtr_get_elapsedTicks_Public_Abstract_Virtual_New_get_Int64_0;

		// Token: 0x04002E1F RID: 11807
		private static readonly IntPtr NativeMethodInfoPtr_get_elapsedTicksRaw_Public_Abstract_Virtual_New_get_Int64_0;

		// Token: 0x04002E20 RID: 11808
		private static readonly IntPtr NativeMethodInfoPtr_get_isRunning_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04002E21 RID: 11809
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04002E22 RID: 11810
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04002E23 RID: 11811
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04002E24 RID: 11812
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
