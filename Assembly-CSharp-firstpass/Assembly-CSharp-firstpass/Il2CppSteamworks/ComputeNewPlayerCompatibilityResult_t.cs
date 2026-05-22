using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000045 RID: 69
	[StructLayout(2)]
	public struct ComputeNewPlayerCompatibilityResult_t
	{
		// Token: 0x06000541 RID: 1345 RVA: 0x00027984 File Offset: 0x00025B84
		// Note: this type is marked as 'beforefieldinit'.
		static ComputeNewPlayerCompatibilityResult_t()
		{
			Il2CppClassPointerStore<ComputeNewPlayerCompatibilityResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "ComputeNewPlayerCompatibilityResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ComputeNewPlayerCompatibilityResult_t>.NativeClassPtr);
			ComputeNewPlayerCompatibilityResult_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputeNewPlayerCompatibilityResult_t>.NativeClassPtr, "k_iCallback");
			ComputeNewPlayerCompatibilityResult_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputeNewPlayerCompatibilityResult_t>.NativeClassPtr, "m_eResult");
			ComputeNewPlayerCompatibilityResult_t.NativeFieldInfoPtr_m_cPlayersThatDontLikeCandidate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputeNewPlayerCompatibilityResult_t>.NativeClassPtr, "m_cPlayersThatDontLikeCandidate");
			ComputeNewPlayerCompatibilityResult_t.NativeFieldInfoPtr_m_cPlayersThatCandidateDoesntLike = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputeNewPlayerCompatibilityResult_t>.NativeClassPtr, "m_cPlayersThatCandidateDoesntLike");
			ComputeNewPlayerCompatibilityResult_t.NativeFieldInfoPtr_m_cClanPlayersThatDontLikeCandidate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputeNewPlayerCompatibilityResult_t>.NativeClassPtr, "m_cClanPlayersThatDontLikeCandidate");
			ComputeNewPlayerCompatibilityResult_t.NativeFieldInfoPtr_m_SteamIDCandidate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputeNewPlayerCompatibilityResult_t>.NativeClassPtr, "m_SteamIDCandidate");
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x00003242 File Offset: 0x00001442
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ComputeNewPlayerCompatibilityResult_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000543 RID: 1347 RVA: 0x00027A2C File Offset: 0x00025C2C
		// (set) Token: 0x06000544 RID: 1348 RVA: 0x00003254 File Offset: 0x00001454
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ComputeNewPlayerCompatibilityResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ComputeNewPlayerCompatibilityResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x040004A0 RID: 1184
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x040004A1 RID: 1185
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x040004A2 RID: 1186
		private static readonly IntPtr NativeFieldInfoPtr_m_cPlayersThatDontLikeCandidate;

		// Token: 0x040004A3 RID: 1187
		private static readonly IntPtr NativeFieldInfoPtr_m_cPlayersThatCandidateDoesntLike;

		// Token: 0x040004A4 RID: 1188
		private static readonly IntPtr NativeFieldInfoPtr_m_cClanPlayersThatDontLikeCandidate;

		// Token: 0x040004A5 RID: 1189
		private static readonly IntPtr NativeFieldInfoPtr_m_SteamIDCandidate;

		// Token: 0x040004A6 RID: 1190
		[FieldOffset(0)]
		public EResult m_eResult;

		// Token: 0x040004A7 RID: 1191
		[FieldOffset(4)]
		public int m_cPlayersThatDontLikeCandidate;

		// Token: 0x040004A8 RID: 1192
		[FieldOffset(8)]
		public int m_cPlayersThatCandidateDoesntLike;

		// Token: 0x040004A9 RID: 1193
		[FieldOffset(12)]
		public int m_cClanPlayersThatDontLikeCandidate;

		// Token: 0x040004AA RID: 1194
		[FieldOffset(16)]
		public CSteamID m_SteamIDCandidate;
	}
}
