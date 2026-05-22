using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020001C3 RID: 451
	public class TaughtCable : MonoBehaviour
	{
		// Token: 0x06003199 RID: 12697 RVA: 0x000BCA38 File Offset: 0x000BAC38
		// Note: this type is marked as 'beforefieldinit'.
		static TaughtCable()
		{
			Il2CppClassPointerStore<TaughtCable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "TaughtCable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaughtCable>.NativeClassPtr);
			TaughtCable.NativeFieldInfoPtr_line = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaughtCable>.NativeClassPtr, "line");
			TaughtCable.NativeFieldInfoPtr_sockets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaughtCable>.NativeClassPtr, "sockets");
			TaughtCable.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaughtCable>.NativeClassPtr, 100667166);
			TaughtCable.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaughtCable>.NativeClassPtr, 100667167);
			TaughtCable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaughtCable>.NativeClassPtr, 100667168);
		}

		// Token: 0x0600319A RID: 12698 RVA: 0x000BCACC File Offset: 0x000BACCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85419, XrefRangeEnd = 85422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaughtCable.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600319B RID: 12699 RVA: 0x000BCB00 File Offset: 0x000BAD00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85422, XrefRangeEnd = 85430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaughtCable.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600319C RID: 12700 RVA: 0x000BCB34 File Offset: 0x000BAD34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TaughtCable()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaughtCable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaughtCable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600319D RID: 12701 RVA: 0x00022052 File Offset: 0x00020252
		public TaughtCable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170011A4 RID: 4516
		// (get) Token: 0x0600319E RID: 12702 RVA: 0x000BCB70 File Offset: 0x000BAD70
		// (set) Token: 0x0600319F RID: 12703 RVA: 0x0002205B File Offset: 0x0002025B
		public unsafe LineRenderer line
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaughtCable.NativeFieldInfoPtr_line);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LineRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaughtCable.NativeFieldInfoPtr_line), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011A5 RID: 4517
		// (get) Token: 0x060031A0 RID: 12704 RVA: 0x000BCBA0 File Offset: 0x000BADA0
		// (set) Token: 0x060031A1 RID: 12705 RVA: 0x0002207A File Offset: 0x0002027A
		public unsafe Il2CppReferenceArray<Transform> sockets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaughtCable.NativeFieldInfoPtr_sockets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaughtCable.NativeFieldInfoPtr_sockets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001D0F RID: 7439
		private static readonly IntPtr NativeFieldInfoPtr_line;

		// Token: 0x04001D10 RID: 7440
		private static readonly IntPtr NativeFieldInfoPtr_sockets;

		// Token: 0x04001D11 RID: 7441
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x04001D12 RID: 7442
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x04001D13 RID: 7443
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
