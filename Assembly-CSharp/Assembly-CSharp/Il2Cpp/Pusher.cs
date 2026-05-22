using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200016A RID: 362
	public class Pusher : MonoBehaviour
	{
		// Token: 0x06002BB9 RID: 11193 RVA: 0x000AD304 File Offset: 0x000AB504
		// Note: this type is marked as 'beforefieldinit'.
		static Pusher()
		{
			Il2CppClassPointerStore<Pusher>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Pusher");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Pusher>.NativeClassPtr);
			Pusher.NativeFieldInfoPtr_speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pusher>.NativeClassPtr, "speed");
			Pusher.NativeFieldInfoPtr_pushed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pusher>.NativeClassPtr, "pushed");
			Pusher.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pusher>.NativeClassPtr, 100666732);
			Pusher.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pusher>.NativeClassPtr, 100666733);
		}

		// Token: 0x06002BBA RID: 11194 RVA: 0x000AD384 File Offset: 0x000AB584
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pusher.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BBB RID: 11195 RVA: 0x000AD3B8 File Offset: 0x000AB5B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Pusher()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Pusher>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pusher.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BBC RID: 11196 RVA: 0x0001E504 File Offset: 0x0001C704
		public Pusher(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000FB7 RID: 4023
		// (get) Token: 0x06002BBD RID: 11197 RVA: 0x000AD3F4 File Offset: 0x000AB5F4
		// (set) Token: 0x06002BBE RID: 11198 RVA: 0x0001E50D File Offset: 0x0001C70D
		public unsafe Vector2 speed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pusher.NativeFieldInfoPtr_speed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pusher.NativeFieldInfoPtr_speed)) = value;
			}
		}

		// Token: 0x17000FB8 RID: 4024
		// (get) Token: 0x06002BBF RID: 11199 RVA: 0x000AD41C File Offset: 0x000AB61C
		// (set) Token: 0x06002BC0 RID: 11200 RVA: 0x0001E528 File Offset: 0x0001C728
		public unsafe bool pushed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pusher.NativeFieldInfoPtr_pushed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pusher.NativeFieldInfoPtr_pushed)) = value;
			}
		}

		// Token: 0x040019C9 RID: 6601
		private static readonly IntPtr NativeFieldInfoPtr_speed;

		// Token: 0x040019CA RID: 6602
		private static readonly IntPtr NativeFieldInfoPtr_pushed;

		// Token: 0x040019CB RID: 6603
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x040019CC RID: 6604
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
