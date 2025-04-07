
using Adapter;

LegacyPaymentSystemAdapter legacyPaymentSystemAdapter = new LegacyPaymentSystemAdapter(new LegacyPaymentSystem());
legacyPaymentSystemAdapter.Payment("Legacy");

ModernPaymentSystemAdapter modernPaymentSystemAdapter = new ModernPaymentSystemAdapter(new ModernPaymentSystem());
modernPaymentSystemAdapter.Payment("Modern");





